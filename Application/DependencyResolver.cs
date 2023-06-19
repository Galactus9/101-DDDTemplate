using Application.Mapper;
using Application.Services.Implmentaitions;
using Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class DependencyResolver
    {
        public static IServiceCollection AddApplication(
           this IServiceCollection services)
        {
            services.AddScoped<IServicesUnitOfWork, ServicesUnitOfWork>();
            services.AutoMapperConfig();
            return services;
        }
    }
}
