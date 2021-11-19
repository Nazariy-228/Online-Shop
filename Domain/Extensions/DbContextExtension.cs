using Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions
{
    public static class DbContextExtension
    {
        public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ShopConnection");

            services.AddDbContext<ShopContext>(options =>
                options.UseSqlServer(connectionString,
                    x => x.MigrationsAssembly("Domain")));
        }
    }
}