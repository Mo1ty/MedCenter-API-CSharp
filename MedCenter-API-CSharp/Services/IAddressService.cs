using MedCenter_API_CSharp.Data;
using MedCenter_API_CSharp.Data.Dtos;

namespace MedCenter_API_CSharp.Services
{
    public interface IAddressService
    {

        Task<AddressDto> CreateAddressAsync(CreateUpdateAddressDto createAddressDto);
        Task<AddressDto?> GetAddressByIdAsync(long id);
        Task<IEnumerable<AddressDto>> GetAllAddressesAsync();
        Task UpdateAddressAsync(long id, CreateUpdateAddressDto updatedAddressDto);
        Task DeleteAddressAsync(long id);

    }
}
