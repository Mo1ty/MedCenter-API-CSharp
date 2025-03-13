using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Data.Models
{
    public class Contact : GenericEntity
    {        

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public string PhoneNumber { get; set; }


        //Navigation
        public long AddressId { get; set; }
        public Address Address { get; set; } = null!;


        public Contact(long id, string firstName, string lastName, DateOnly birthDate, string phoneNumber, long addressId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
            AddressId = addressId;
        }

    }
}
