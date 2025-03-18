namespace MedCenter_API_CSharp.Models;

public class DoctorAccount
{
    public long Id { get; set; }
    public string Email { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }

    public DoctorAccount(long id, string email, string login, string password)
    {
        Id = id;
        Email = email;
        Login = login;
        Password = password;
    }
}