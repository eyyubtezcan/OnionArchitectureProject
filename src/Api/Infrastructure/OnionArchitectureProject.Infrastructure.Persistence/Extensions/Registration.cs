using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureProject.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureProject.Infrastructure.Persistence.Extensions
{
    public static class Registration
    {
        public static IServiceCollection AddInfrastructureRegistration(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<OnionArchitectureProjectContext>(conf =>
            {
                var connStr = configuration["OnionArchitectureProjectDbConnectionString"].ToString();
                conf.UseSqlServer("", opt =>
                {
                    opt.EnableRetryOnFailure();
                });
            });

            var seedData = new SeedData();
            seedData.SeedAsync(configuration).GetAwaiter().GetResult();  

            return services;
        }
    }
}
