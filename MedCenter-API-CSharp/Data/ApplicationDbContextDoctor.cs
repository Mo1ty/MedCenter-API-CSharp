using MedCenter_API_CSharp.Models;
using Microsoft.EntityFrameworkCore;

namespace MedCenter_API_CSharp.Data;

public partial class ApplicationDbContext : DbContext
{
    private readonly string _connectionString = "server=localhost;user=root;password=***;database=mydb";
    private readonly ServerVersion _serverVersion = ServerVersion.Parse("8.4.4-mysql");
    
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<DoctorAccount> DoctorAccounts { get; set; }
    public DbSet<Leave> DoctorLeaves { get; set; }
    public DbSet<LeaveReason> LeaveReasons { get; set; }
    public DbSet<ShiftType> ShiftTypes { get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<Treatment> Treatments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(_connectionString, _serverVersion);
    }
}