using GlobalTickect.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Persistence;
using GloboTicket.TicketManagement.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTickect.TicketManagement.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services ,IConfiguration configuration)
        {
           
            string connectionString = configuration.GetConnectionString("GlobalTicketManagementConnectionString");

            // Configure the MySQL server version.
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 33));

            // Add the DbContext to the services.
            services.AddDbContext<GloboTicketDbContext>(options =>
                options.UseMySql(connectionString, serverVersion)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors()
            );


            services.AddScoped(typeof(IAsyncRepository<>),typeof(BaseRepository<>));


            services.AddScoped<ICategoryRepositoty,CategoryRepository>();
            services.AddScoped<IEventRepository,EventRepository>();
            services.AddScoped<IOrderRepository,OrderRepository>();

            return services;
        }
    }
}
