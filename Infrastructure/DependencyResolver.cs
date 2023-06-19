using Infrastructure.RepositoryImplementation;
using Microsoft.Extensions.DependencyInjection;
using RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DependencyResolver
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services)
        {
            services.AddScoped<IRepositoryUnitOfWork, RepositoryUnitOfWork>();
            return services;
        }
    }
}
