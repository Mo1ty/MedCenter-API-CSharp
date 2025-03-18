using MedCenter_API_CSharp.Data;
using MedCenter_API_CSharp.Data.Dtos;

namespace MedCenter_API_CSharp.Services.Contracts
{
    public interface IContactService
    {

        Task<ContactDto> CreateContactAsync(CreateUpdateContactDto createContactDto);
        Task<ContactDto?> GetContactByIdAsync(long id);
        Task<IEnumerable<ContactDto>> GetAllContactsAsync();
        Task UpdateContactAsync(long id, CreateUpdateContactDto updatedContactDto);
        Task DeleteContactAsync(long id);

    }
}
