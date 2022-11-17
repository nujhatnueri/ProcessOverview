using System.Linq;
using ProcessOverview.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ProcessOverview.Infrastructure.Context
{
    public class ProcessOverviewDbContext : DbContext
    {
        public ProcessOverviewDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Process> Processes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
                //property.SetColumnType("varchar(150)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProcessOverviewDbContext).Assembly);

           // foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}