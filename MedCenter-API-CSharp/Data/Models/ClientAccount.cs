namespace MedCenter_API_CSharp.Data.Models
{
    public class ClientAccount
    {        

        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }


        //Navigation
        public int ClientId { get; set; }
        public Client Client { get; set; } = null!;


        public ClientAccount(string email, string login, string password, int clientId)
        {
            Email = email;
            Login = login;
            Password = password;
            ClientId = clientId;
        }

    }
}
