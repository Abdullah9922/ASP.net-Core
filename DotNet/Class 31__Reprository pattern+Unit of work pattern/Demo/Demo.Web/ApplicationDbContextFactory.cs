using Demo.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Demo.Web
{
    public class ApplicationDbContextFactory
        : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            string? webProjectPath = null;

            while (directory is not null)
            {
                if (directory.Name.Equals("Demo.Web", StringComparison.OrdinalIgnoreCase)
                    && File.Exists(Path.Combine(directory.FullName, "appsettings.json")))
                {
                    webProjectPath = directory.FullName;
                    break;
                }

                var candidate = Path.Combine(directory.FullName, "Demo.Web");
                if (File.Exists(Path.Combine(candidate, "Demo.Web.csproj"))
                    && File.Exists(Path.Combine(candidate, "appsettings.json")))
                {
                    webProjectPath = candidate;
                    break;
                }

                directory = directory.Parent;
            }

            if (webProjectPath is null)
            {
                throw new DirectoryNotFoundException(
                    "Could not locate the Demo.Web project and its appsettings.json.");
            }

            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(webProjectPath)
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile("appsettings.Development.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            var connectionString =
                configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException(
                    "Connection string 'DefaultConnection' was not found.");

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(
                    connectionString,
                    sql => sql.MigrationsAssembly("Demo.Infrastructure"))
                .Options;

            return new ApplicationDbContext(options);
        }
    }
}
