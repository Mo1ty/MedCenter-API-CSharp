using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Data.Models
{
    public class Client : GenericEntity
    {        

        public DateTime RegistrationDate { get; set; } 


        //Navigation

        public long ContactId { get; set; }
        public Contact Contact { get; set; } = null!;

        public List<ClientBenefit>? ClientBenefits { get; set; }


        public Client(long id, DateTime registrationDate, long contactId)
        {
            Id = id;
            RegistrationDate = registrationDate;
            ContactId = contactId;
        }

    }
}
