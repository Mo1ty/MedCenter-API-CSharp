using MedCenter_API_CSharp.Data;
using MedCenter_API_CSharp.Data.Dtos;
using MedCenter_API_CSharp.Data.Mappings;
using MedCenter_API_CSharp.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace MedCenter_API_CSharp.Services
{
    public class AddressService : IAddressService
    {

        private readonly ApplicationDbContext _dbContext;
        private readonly ILogger<AddressService> _logger;


        public AddressService(ApplicationDbContext dbContext, ILogger<AddressService> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }


        public async Task<AddressDto> CreateAddressAsync(CreateUpdateAddressDto createAddressDto)
        {
            var address = createAddressDto.ToEntity();

            await _dbContext.Addresses.AddAsync(address);
            await _dbContext.SaveChangesAsync();

            return address.ToAddressDto();
        }


        public async Task<IEnumerable<AddressDto>> GetAllAddressesAsync()
        {
            return await _dbContext.Addresses
                .AsNoTracking()
                .Select(address => address.ToAddressDto())
                .ToListAsync();
        }


        public async Task<AddressDto?> GetAddressByIdAsync(long id)
        {
            var address = await _dbContext.Addresses
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.Id == id);

            if (address is null) return null;

            return address.ToAddressDto();
        }


        public async Task UpdateAddressAsync(long id, CreateUpdateAddressDto updatedAddressDto)
        {
            var address = await _dbContext.Addresses.FindAsync(id)
                 ?? throw new ArgumentNullException($"Couldn't find address with id of {id}");

            _dbContext.Entry(address)
                .CurrentValues
                .SetValues(updatedAddressDto.ToEntity());

            await _dbContext.SaveChangesAsync();            
        }


        public async Task DeleteAddressAsync(long id)
        {
            var address = await _dbContext.Addresses.FindAsync(id) 
                ?? throw new ArgumentNullException($"Couldn't find address with id of {id}");

            /*await _dbContext.Addresses
                .Where(address => address.Id == id)
                .ExecuteDeleteAsync();*/

            _dbContext.Remove(address);
            await _dbContext.SaveChangesAsync();
        }

    }
}
