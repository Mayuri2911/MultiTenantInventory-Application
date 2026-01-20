using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContextFactory
        : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            optionsBuilder.UseSqlServer(
                "Server=LAPTOP-CTDMAAC7;Database=MultiTenantInventoryDb;Trusted_Connection=True;TrustServerCertificate=True");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
