// <copyright file="ServiceCollectionExtensions.cs" company="Medica">
// Copyright (c) Medica. All rights reserved.
// </copyright>

namespace Medica.Application.Extensions
{
    using Medica.Application.Interfaces;
    using Medica.Application.Mappings;
    using Medica.Application.Services;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Service layer extensions to register services.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Application services.
        /// </summary>
        /// <param name="services">ServiceCollection.</param>
        /// <returns>Return register services.</returns>
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Register application services
            services.AddScoped<IEmployeeRecordService, EmployeeRecordService>();

            // Register AutoMapper profiles
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
