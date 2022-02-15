using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace FAQ_Api.Data.EF
{
    public class FaqDbContextFactory : IDesignTimeDbContextFactory<FaqDbContext>
    {
        public FaqDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("FaqDb");

            var optionsBuilder = new DbContextOptionsBuilder<FaqDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new FaqDbContext(optionsBuilder.Options);
        }
    }
}
