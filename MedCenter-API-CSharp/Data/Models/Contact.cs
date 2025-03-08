namespace MedCenter_API_CSharp.Data.Models
{
    public class Contact
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }


        //Navigation
        public Client Client { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; } = null!;

    }
}
