using Microsoft.EntityFrameworkCore;
using Banking_System.Enities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Banking_System.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasKey(u => u.Id);

            entity.Property(u => u.FullName)
                .IsRequired()
                .HasMaxLength(50);

        }

    }
}
