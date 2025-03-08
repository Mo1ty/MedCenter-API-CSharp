namespace MedCenter_API_CSharp.Data.Models
{
    public class Address
    {

        public int Id { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }


        //Navigation
        public Contact Contact { get; set; }

    }
}
