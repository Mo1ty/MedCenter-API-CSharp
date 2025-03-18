using MedCenter_API_CSharp.Data.Dtos;
using MedCenter_API_CSharp.Data.Models;

namespace MedCenter_API_CSharp.Data.Mappings
{
    public static class AddressMapping
    {

        public static Address ToEntity(this AddressDto addressDto)
        {
            return new Address()
            {
                Id = addressDto.Id,
                City = addressDto.City,
                PostalCode = addressDto.PostalCode,
                Street = addressDto.Street,
                HouseNumber = addressDto.HouseNumber
            };
        }


        public static Address ToEntity(this CreateUpdateAddressDto createUpdateAddressDto)
        {
            return new Address()
            {
                City = createUpdateAddressDto.City,
                PostalCode = createUpdateAddressDto.PostalCode,
                Street = createUpdateAddressDto.Street,
                HouseNumber = createUpdateAddressDto.HouseNumber
            };
        }


        public static AddressDto ToAddressDto(this Address address)
        {
            return new AddressDto(
                address.Id,
                address.City,
                address.PostalCode,
                address.Street,
                address.HouseNumber
                );
        }

    }
}
