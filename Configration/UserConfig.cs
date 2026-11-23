using Microsoft.EntityFrameworkCore;
using MVC002.Entites;

namespace MVC002.Configration
{
    public class UserConfig<T> : IEntityTypeConfiguration<T> where T : User
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<T> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.Name)
                   .HasColumnType("Varchar")
                   .HasMaxLength(50);
            builder.Property(p => p.Email)
                   .HasColumnType("Varchar")
                   .HasMaxLength(100);
            builder.ComplexProperty(p => p.Address);
            builder.HasIndex(p => p.Email).IsUnique();
            builder.HasIndex(p => p.Phone).IsUnique();
            builder.ToTable(p =>
            {
                p.HasCheckConstraint("EmailCheck", "Email Like '%_@%.com'");
                p.HasCheckConstraint("PhoneCheck", "LEN(Phone) = 11 AND (Phone Like '010%' OR Phone Like '011%' OR Phone Like '012%' OR Phone Like '015%' )");
            });
        }
    }
}
