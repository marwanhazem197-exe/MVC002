using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC002.Entites;

namespace MVC002.Configration
{
    public class TrainerConfig :UserConfig<Trainer>, IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(p => p.CreateDate)
                    .HasColumnName("HireDate")
                    .HasDefaultValueSql("GETDATE()");
            base.Configure(builder);
        }
    }
}
