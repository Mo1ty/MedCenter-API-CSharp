using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MedCenter_API_CSharp.Data.Models
{

    [PrimaryKey(nameof(ClientId), nameof(BenefitId))]
    public class ClientBenefit
    {

        public long ClientId { get; set; }
        public Client Client { get; set; } = null!;

        public long BenefitId { get; set; }
        public Benefit Benefit { get; set; } = null!;

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        /*public ClientBenefit(long clientId, long benefitId, DateTime startDate, DateTime endDate)
        {
            ClientId = clientId;
            BenefitId = benefitId;
            StartDate = startDate;
            EndDate = endDate;
        }*/

    }
}
