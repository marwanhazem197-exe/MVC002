using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC002.Entites;

namespace MVC002.Configration
{
    public class MemberPlanConfig : IEntityTypeConfiguration<MemberPlan>
    {
        public void Configure(EntityTypeBuilder<MemberPlan> builder)
        {
            builder.HasKey(p=>p.id);
            builder.Property(p => p.StartDate)
                   .HasDefaultValueSql("GETDATE()");
        }
    }
}
