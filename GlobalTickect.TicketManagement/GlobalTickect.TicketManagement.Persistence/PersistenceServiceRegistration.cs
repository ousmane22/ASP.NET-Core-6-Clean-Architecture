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
            services.AddDbContext<GloboTicketDbContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("GlobalTicketManagementConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>),typeof(BaseRepository<>));


            services.AddScoped<ICategoryRepositoty,CategoryRepository>();
            services.AddScoped<IEventRepository,EventRepository>();
            services.AddScoped<IOrderRepository,OrderRepository>();

            return services;
        }
    }
}
