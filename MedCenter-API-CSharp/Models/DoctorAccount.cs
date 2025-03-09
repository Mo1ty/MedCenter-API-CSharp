using MedCenter_API_CSharp.Models.Generic;

namespace MedCenter_API_CSharp.Models;

public class DoctorAccount : GenericEntity
{
    private string _email;
    private string _login;
    private string _password;
    
    public string Email{get => _email; set => _email = value;}
    public string Login{get => _login; set => _login = value;}
    public string Password{get => _password; set => _password = value;}

    public DoctorAccount(string email, string login, string password) {
        _email = email;
        _login = login;
        _password = password;
    }
}