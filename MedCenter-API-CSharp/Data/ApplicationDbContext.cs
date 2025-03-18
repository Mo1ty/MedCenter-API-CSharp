using MedCenter_API_CSharp.Data.Models;
using MedCenter_API_CSharp.Models;
using Microsoft.EntityFrameworkCore;

namespace MedCenter_API_CSharp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Benefit> Benefits { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientBenefit> Client_Benefits { get; set; }
        public DbSet<ClientAccount> ClientAccounts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Promocode> Promocodes { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorAccount> DoctorAccounts { get; set; }
        public DbSet<Leave> DoctorLeaves { get; set; }
        public DbSet<LeaveReason> LeaveReasons { get; set; }
        public DbSet<ShiftType> ShiftTypes { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Treatment> Treatments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasOne(a => a.Contact)
                .WithOne(c => c.Address)
                .HasForeignKey<Contact>(c => c.AddressId); 

            modelBuilder.Entity<Contact>()
                .HasOne(c => c.Client)
                .WithOne(c => c.Contact)
                .HasForeignKey<Client>(c => c.ContactId);

            modelBuilder.Entity<Client>()
                .HasOne(c => c.ClientAccount)
                .WithOne(ca => ca.Client)
                .HasForeignKey<ClientAccount>(ca => ca.ClientId);

            modelBuilder.Entity<ClientBenefit>()
                .HasOne(c => c.Client)
                .WithMany(cb => cb.ClientBenefits)
                .HasForeignKey(c => c.ClientId);

            modelBuilder.Entity<ClientBenefit>()
                .HasOne(b => b.Benefit)
                .WithMany(cb => cb.ClientBenefits)
                .HasForeignKey(b => b.BenefitId);

            base.OnModelCreating(modelBuilder);
        }        

    }
}
