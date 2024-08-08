using FinancialApp.Infrastructure.Persistence;
using FinancialApp.Infrastructure.Seeders;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FinancialApp.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FinancialAppDbContext>(options =>
                 options.UseMySql(configuration.GetConnectionString("FinancialApp"), new MySqlServerVersion(new Version(10,6,18))));


            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<FinancialAppDbContext>();



            //Seeders section:

            services.AddScoped<FinancialAppUserRolseSeeder>();
            services.AddScoped<FinancialAppDefaultUserSeeder>();


        }
      


        
    }
}
