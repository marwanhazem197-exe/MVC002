using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC002.Entites;

namespace MVC002.Configration
{
    public class MemberConfig :UserConfig<Member>,IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.CreateDate)
                    .HasColumnName("JoinDate")
                    .HasDefaultValueSql("GetDate()");

        }
    }
}
