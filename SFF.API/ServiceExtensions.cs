using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using SFF.Datasource.Context;
using Microsoft.Extensions.DependencyInjection;
using SFF.Datasource.Repository;

namespace SFF.API
{
    public static class ServiceExtensions
    {
        public static void ConfigureMySqlContext(this IServiceCollection services,
                                                      IConfiguration config)
        {
            var connectionString = config["ConnectionStrings:Default"];
            services.AddDbContext<SFFContext>(o => o.UseSqlServer(connectionString));
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
