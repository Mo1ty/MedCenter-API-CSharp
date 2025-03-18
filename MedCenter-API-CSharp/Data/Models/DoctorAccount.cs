using MedCenter_API_CSharp.Models.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MedCenter_API_CSharp.Models;

public class DoctorAccount
{

    public string Email { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }


    [Key]
    [ForeignKey("Doctor")]
    public long DoctorId { get; set; }
    public Doctor Doctor { get; set; } = null!;


    public DoctorAccount(long doctorId, string email, string login, string password)
    {
        DoctorId = doctorId;
        Email = email;
        Login = login;
        Password = password;
    }

}