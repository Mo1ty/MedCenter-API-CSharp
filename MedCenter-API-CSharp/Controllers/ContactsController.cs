using MedCenter_API_CSharp.Data.Dtos;
using MedCenter_API_CSharp.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace MedCenter_API_CSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {

        private readonly IContactService _contactService;


        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactDto>>> GetAllContacts()
        {
            var contacts = await _contactService.GetAllContactsAsync();
            return Ok(contacts);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ContactDto>> GetContactById(long id)
        {
            var contact = await _contactService.GetContactByIdAsync(id);

            if (contact is null) return NotFound();

            return Ok(contact);
        }


        [HttpPost]
        public async Task<ActionResult<ContactDto>> CreateContact(CreateUpdateContactDto createContactDto)
        {
            var contact = await _contactService.CreateContactAsync(createContactDto);
            return CreatedAtAction(
                nameof(GetContactById),
                new { id = contact.Id },
                contact);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateContact(long id, CreateUpdateContactDto updatedContactDto)
        {
            await _contactService.UpdateContactAsync(id, updatedContactDto);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(long id)
        {
            await _contactService.DeleteContactAsync(id);
            return NoContent();
        }

    }
}
