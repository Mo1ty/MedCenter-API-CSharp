using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Data.Models
{
    public class Address : GenericEntity
    {
        
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }


        public Address(long id, string city, string postalCode, string street, int houseNumber)
        {
            Id = id;
            City = city;
            PostalCode = postalCode;
            Street = street;
            HouseNumber = houseNumber;
        }

    }
}
