using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedCenter_API_CSharp.Data.Models
{
    public class ClientAccount
    {        

        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }


        //Navigation
        [Key]
        [ForeignKey("Client")]
        public long ClientId { get; set; }
        public Client Client { get; set; } = null!;


        /*public ClientAccount(string email, string login, string password, long clientId)
        {
            Email = email;
            Login = login;
            Password = password;
            ClientId = clientId;
        }*/

    }
}
