namespace MedCenter_API_CSharp.Data.Models
{
    public class ClientBenefit
    {        

        public int ClientId { get; set; }
        public Client Client { get; set; } = null!;

        public int BenefitId { get; set; }
        public Benefit Benefit { get; set; } = null!;

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public ClientBenefit(int clientId, int benefitId, DateTime startDate, DateTime endDate)
        {
            ClientId = clientId;
            BenefitId = benefitId;
            StartDate = startDate;
            EndDate = endDate;
        }

    }
}
