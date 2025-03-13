using MedCenter_API_CSharp.Data;
using MedCenter_API_CSharp.Data.Dtos;
using MedCenter_API_CSharp.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace MedCenter_API_CSharp.Services
{
    public class ContactService : IContactService
    {

        private readonly ApplicationDbContext _dbContext;
        private readonly ILogger<ContactService> _logger;


        public ContactService(ApplicationDbContext dbContext, ILogger<ContactService> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }


        public async Task<ContactDto> CreateContactAsync(CreateUpdateContactDto createContactDto)
        {
            long id = _dbContext.Contacts.Max(c => c.Id) + 1;

            var contact = createContactDto.ToEntity(id);

            await _dbContext.Contacts.AddAsync(contact);
            await _dbContext.SaveChangesAsync();

            return contact.ToContactDto();
        }


        public async Task<IEnumerable<ContactDto>> GetAllContactsAsync()
        {
            return await _dbContext.Contacts
                .Include(c => c.Address) // Включаем связанный Address
                .AsNoTracking()
                .Select(contact => contact.ToContactDto())
                .ToListAsync();
        }


        public async Task<ContactDto?> GetContactByIdAsync(long id)
        {
            var contact = await _dbContext.Contacts
                .Include(c => c.Address) // Включаем связанный Address
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);

            if (contact is null) return null;

            return contact.ToContactDto();
        }


        public async Task UpdateContactAsync(long id, CreateUpdateContactDto updatedContactDto)
        {
            var contact = await _dbContext.Contacts.FindAsync(id)
                ?? throw new ArgumentNullException($"Couldn't find contact with id of {id}");

            _dbContext.Entry(contact)
                .CurrentValues
                .SetValues(updatedContactDto.ToEntity(id));

            await _dbContext.SaveChangesAsync();
        }


        public async Task DeleteContactAsync(long id)
        {
            var contact = await _dbContext.Contacts.FindAsync(id)
                ?? throw new ArgumentNullException($"Couldn't find contact with id of {id}");

            _dbContext.Remove(contact);
            await _dbContext.SaveChangesAsync();
        }

    }
}
