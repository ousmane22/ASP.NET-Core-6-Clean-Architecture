﻿using GlobalTickect.TicketManagement.Application;
using GlobalTickect.TicketManagement.Infrastructure;
using GlobalTickect.TicketManagement.Persistence;
using System.Runtime.CompilerServices;

namespace GlobalTickect.TicketManagement.Api
{
    public static class StartupExtensions
    {
        public static WebApplication ConfigureServices(
            this WebApplicationBuilder builder)
        {
            builder.Services.AddApplicationServices();
            builder.Services.AddInfrastructureSevices(builder.Configuration);
            builder.Services.AddPersistenceServices(builder.Configuration);

            builder.Services.AddControllers();
            builder.Services.AddCors(options =>
                options.AddPolicy("Open",builder => builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod()
                ));

            return builder.Build();
        }

        public static WebApplication ConfigurePipeline(
           this WebApplication app)
        {
            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseCors("Open");
            app.MapControllers();

            return app;
        }
    }
}
