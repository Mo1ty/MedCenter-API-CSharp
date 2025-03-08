namespace MedCenter_API_CSharp.Data.Models
{
    public class Benefit
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        //Navigation
        public List<Client_Benefit> Client_Benefits { get; set; }

    }
}
