using MedCenter_API_CSharp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedCenter_API_CSharp.Data.Configurations
{
    public class AddressConfugiration : IEntityTypeConfiguration<Address>
    {

        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");
            builder.Property(a => a.Id).HasColumnName("address_id").ValueGeneratedOnAdd();
            builder.Property(a => a.PostalCode).HasColumnName("postal_code");
            builder.Property(a => a.HouseNumber).HasColumnName("house_number");
        }

    }
}
