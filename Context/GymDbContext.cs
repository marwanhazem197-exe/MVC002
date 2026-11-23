using Microsoft.EntityFrameworkCore;
using MVC002.Entites;
using System.Reflection;

namespace MVC002.Context
{
    public class GymDbContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = Gym; Trusted_Connection = True ; TrustServerCertificate = True");
        }
        DbSet<Member> Members { get; set; }
        DbSet<Trainer> Trainers { get; set; }
        DbSet<Session> Sessions { get; set; }
        DbSet<Plan> Plans { get; set; } 
        DbSet<MemberPlan> MemberPlans { get; set; }
    }
}
