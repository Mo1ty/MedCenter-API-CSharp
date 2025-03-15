using MedCenter_API_CSharp.Data.Dtos;
using MedCenter_API_CSharp.Services;
using Microsoft.AspNetCore.Mvc;

namespace MedCenter_API_CSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressesController : ControllerBase
    {

        private readonly IAddressService _addressService;


        public AddressesController(IAddressService addressService)
        {
            _addressService = addressService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<AddressDto>>> GetAllAddresses()
        {
            var addresses = await _addressService.GetAllAddressesAsync();
            return Ok(addresses);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<AddressDto>> GetAddressById(long id)
        {
            var address = await _addressService.GetAddressByIdAsync(id);

            if (address is null) return NotFound();

            return Ok(address);
        }


        [HttpPost]
        public async Task<ActionResult<AddressDto>> CreateAddress(CreateUpdateAddressDto createAddressDto)
        {
            var address = await _addressService.CreateAddressAsync(createAddressDto);
            return CreatedAtAction(
                nameof(GetAddressById), 
                new { id = address.Id }, 
                address);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAddress(long id, CreateUpdateAddressDto updatedAddressDto)
        {
            var address = await _addressService.GetAddressByIdAsync(id);

            if (address is null) return NotFound();

            await _addressService.UpdateAddressAsync(id, updatedAddressDto);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(long id)
        {
            await _addressService.DeleteAddressAsync(id);
            return NoContent();
        }

    }
}
