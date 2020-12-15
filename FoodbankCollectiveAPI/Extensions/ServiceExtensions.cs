using System;
using Microsoft.Extensions.DependencyInjection;

namespace FoodbankCollectiveAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
    }
}

//If we want to send requests from a different domain to our application, configuring CORS is mandatory. So, to start off, we’ll add a
//    code that allows all requests from all origins to be sent to our API:
//public static void ConfigureCors(this IServiceCollection services) =>
//    services.AddCors(options =>
//    {
//        options.AddPolicy("CorsPolicy", builder =>
//            builder.AllowAnyOrigin()
//            .AllowAnyMethod()
//            .AllowAnyHeader());
//    });