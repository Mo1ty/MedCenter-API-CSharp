using MedCenter_API_CSharp.Models.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedCenter_API_CSharp.Data.Models
{

    public class Address
    {

        [Key]
        [Column("address_id")]
        public long Id { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [Column("postal_code")]
        public string PostalCode { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        [Column("house_number")]
        public int HouseNumber { get; set; }


        /*public Address(string city, string postalCode, string street, int houseNumber)
        {
            City = city;
            PostalCode = postalCode;
            Street = street;
            HouseNumber = houseNumber;
        }*/

    }

}
