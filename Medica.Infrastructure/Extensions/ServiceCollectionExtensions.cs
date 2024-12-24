// <copyright file="ServiceCollectionExtensions.cs" company="Medica">
// Copyright (c) Medica. All rights reserved.
// </copyright>

namespace Medica.Infrastructure.Extensions
{
    using Medica.Infrastructure.DataServices;
    using Medica.Infrastructure.Interfaces;
    using Medica.Infrastructure.Repositories;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Service layer extensions to register services.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Infrastructure services.
        /// </summary>
        /// <param name="services">ServiceCollection.</param>
        /// <returns>Return register services.</returns>
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            // Register repositories
            services.AddScoped<IEmployeeRecordRepository, EmployeeRecordRepository>();
            services.AddScoped<ICsvDataLoader, CsvDataLoader>();

            return services;
        }
    }
}
