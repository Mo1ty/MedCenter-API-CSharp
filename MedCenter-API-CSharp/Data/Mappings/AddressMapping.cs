using MedCenter_API_CSharp.Data.Dtos;
using MedCenter_API_CSharp.Data.Models;

namespace MedCenter_API_CSharp.Data.Mappings
{
    public static class AddressMapping
    {

        public static Address ToEntity(this AddressDto addressDto, long id)
        {
            return new Address(
                id,
                addressDto.City,
                addressDto.PostalCode,
                addressDto.Street,
                addressDto.HouseNumber);
        }


        public static Address ToEntity(this CreateUpdateAddressDto createUpdateAddressDto, long id)
        {
            return new Address(
                id,
                createUpdateAddressDto.City,
                createUpdateAddressDto.PostalCode,
                createUpdateAddressDto.Street,
                createUpdateAddressDto.HouseNumber);
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
