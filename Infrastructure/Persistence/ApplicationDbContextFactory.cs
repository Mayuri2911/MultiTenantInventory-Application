using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using Infrastructure.Interface; // ← for ICurrentTenantService

namespace Infrastructure.Persistence
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Your local connection string
            optionsBuilder.UseSqlServer(
                "Server=LAPTOP-CTDMAAC7;Database=MultiTenantInventoryDb;Trusted_Connection=True;TrustServerCertificate=True",
                sqlOptions =>
                {
                    // Tell EF where migrations should be stored (Infrastructure project)
                    sqlOptions.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.GetName().Name);
                });

            // Temporary fake tenant service for design-time (migrations don't need real tenant)
            var fakeTenantService = new FakeCurrentTenantService();

            return new ApplicationDbContext(optionsBuilder.Options, fakeTenantService);
        }

        // Simple fake implementation for design-time only
        private class FakeCurrentTenantService : ICurrentTenantService
        {
            public Guid? TenantId => Guid.Empty; // or any dummy GUID

            public void SetCurrentTenant(Guid tenantId) { }
        }
    }
}