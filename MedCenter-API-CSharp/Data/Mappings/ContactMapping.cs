using MedCenter_API_CSharp.Data.Dtos;
using MedCenter_API_CSharp.Data.Models;

namespace MedCenter_API_CSharp.Data.Mappings
{
    public static class ContactMapping
    {

        public static Contact ToEntity(this ContactDto contactDto, long id)
        {
            return new Contact(
                id,
                contactDto.FirstName,
                contactDto.LastName,
                contactDto.BirthDate,
                contactDto.PhoneNumber,
                contactDto.AddressId);
        }


        public static Contact ToEntity(this CreateUpdateContactDto createUpdateContactDto, long id)
        {
            return new Contact(
                id,
                createUpdateContactDto.FirstName,
                createUpdateContactDto.LastName,
                createUpdateContactDto.BirthDate,
                createUpdateContactDto.PhoneNumber,
                createUpdateContactDto.AddressId);
        }


        public static ContactDto ToContactDto(this Contact contact)
        {
            return new ContactDto(
                contact.Id,
                contact.FirstName,
                contact.LastName,
                contact.BirthDate,
                contact.PhoneNumber,
                contact.AddressId);
        }

    }
}
