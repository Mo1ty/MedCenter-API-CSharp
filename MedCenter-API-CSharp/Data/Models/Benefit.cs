using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Data.Models
{
    public class Benefit : GenericEntity
    {      

        public string Name { get; set; }
        public string Description { get; set; }


        //Navigation
        public List<ClientBenefit>? ClientBenefits { get; set; }


        public Benefit(string name, string description)
        {
            Name = name;
            Description = description;
        }

    }
}
