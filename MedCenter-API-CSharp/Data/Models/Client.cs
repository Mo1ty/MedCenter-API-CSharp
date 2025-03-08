namespace MedCenter_API_CSharp.Data.Models
{
    public class Client
    {

        public int Id { get; set; }
        public DateTime RegistrationDate { get; set; }


        //Navigation
        public ClientAccount ClientAccount { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; } = null!;

        public List<Client_Benefit> Client_Benefits { get; set; }

    }
}
