using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace BD
{
    public static class ConfigurationDB  
    {
        public static void Connection(this IServiceCollection services)
        {
            var connectionString = "Server=MSI\\SQLEXPRESS;Database=CapaArquitectura;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True";

            services.AddDbContext<Context>(options =>
                options.UseSqlServer(connectionString, m =>
                    m.MigrationsAssembly(typeof(Context).Assembly.FullName))
            );
        }
    }
}
