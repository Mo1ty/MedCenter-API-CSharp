namespace MedCenter_API_CSharp.Data.Models
{
    public class Client_Benefit
    {

        public int ClientId { get; set; }
        public Client Client { get; set; } = null!;

        public int BenefitId { get; set; }
        public Benefit Benefit { get; set; } = null!;

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
