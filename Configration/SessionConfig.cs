using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC002.Entites;

namespace MVC002.Configration
{
    public class SessionConfig : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(p => p.CreateDate)
                    .HasDefaultValueSql("GETDATE()");
            builder.ToTable(p =>
            {
                p.HasCheckConstraint("CapacityCheck", "Capacity Between 1 AND 25");
                p.HasCheckConstraint("EndDateCheck", "EndDate > StartDate");
            });
        }
    }
}
