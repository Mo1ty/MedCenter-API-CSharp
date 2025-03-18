using MedCenter_API_CSharp.Data.Configurations;
using MedCenter_API_CSharp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MedCenter_API_CSharp.Data
{
    public partial class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Benefit> Benefits { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientBenefit> Client_Benefits { get; set; }
        public DbSet<ClientAccount> ClientAccounts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Promocode> Promocodes { get; set; }        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new AddressConfugiration());

            // Client Benefit relationship

            /*modelBuilder.Entity<ClientBenefit>()
                .HasKey(cb => new { cb.ClientId, cb.BenefitId });

            modelBuilder.Entity<ClientBenefit>()
                .HasOne(c => c.Client)
                .WithMany(cb => cb.ClientBenefits)
                .HasForeignKey(c => c.ClientId);

            modelBuilder.Entity<ClientBenefit>()
                .HasOne(b => b.Benefit)
                .WithMany(cb => cb.ClientBenefits)
                .HasForeignKey(b => b.BenefitId);*/

            base.OnModelCreating(modelBuilder);
        }        

    }
}
