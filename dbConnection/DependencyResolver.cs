using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace dbConnection
{
    public static class DependencyResolver
    {
        public static IServiceCollection AddDatabaseContext(this IServiceCollection services, IConfiguration configuration, string connectionStringName)
        {

            services.AddDbContext<CustomDBContext>
            (options => options.
                UseSqlServer(configuration.GetConnectionString(connectionStringName)));
            return services;
        }
    }
}
