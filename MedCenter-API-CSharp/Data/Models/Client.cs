namespace MedCenter_API_CSharp.Data.Models
{
    public class Client
    {

        public long Id { get; set; }
        public DateTime RegistrationDate { get; set; }


        //Navigation
        public ClientAccount ClientAccount { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; } = null!;

        public List<ClientBenefit> ClientBenefits { get; set; }

    }
}
