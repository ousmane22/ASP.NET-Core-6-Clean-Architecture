using GlobalTickect.TicketManagement.Application.Contracts.Infrastructure;
using GlobalTickect.TicketManagement.Application.Models;
using GlobalTickect.TicketManagement.Infrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTickect.TicketManagement.Infrastructure
{
    public static class InfrastructureServiceRegistation
    {
        public static IServiceCollection AddInfrastructureSevices(this
            IServiceCollection services,IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection
                ("EmailSetting"));

            services.AddTransient<IEmailService,EmailService>();

            return services;
        }
    }
}
