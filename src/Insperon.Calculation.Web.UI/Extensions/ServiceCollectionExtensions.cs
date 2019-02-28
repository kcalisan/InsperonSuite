using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Insperon.Calculation.Core.Persistence;
using Insperon.Calculation.Core.DomainModel;
using Insperon.Core.Logging;

namespace Insperon.Calculation.Web.UI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterCustomServices(this IServiceCollection services)
        {
            // New instance every time, only configuration class needs so its ok
            services.AddTransient<InsperonDbContext>();
            services.AddTransient<IPrimeNumberRepository, PrimeNumberRepository>();
            services.AddTransient<IPrimeNumberService, PrimeNumberService>();
            services.AddTransient<IPrimeNumberIndexSearchService, PrimeNumberIndexSearchService>();
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            return services;
        }
    }
}
