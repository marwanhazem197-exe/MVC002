using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC002.Entites;

namespace MVC002.Configration
{
    public class PlanConfig : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(p => p.CreateDate)
                    .HasDefaultValueSql("GETDATE()");
            builder.ToTable(p =>
            {
                p.HasCheckConstraint("PlanDurationCheck", "DurationDays between 1 and 365");
            });
        }
    }
}
