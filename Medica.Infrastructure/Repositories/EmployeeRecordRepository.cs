// <copyright file="EmployeeRecordRepository.cs" company="Medica">
// Copyright (c) Medica. All rights reserved.
// </copyright>

namespace Medica.Infrastructure.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Medica.Domain.Entities;
    using Medica.Infrastructure.Interfaces;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Hosting;

    /// <summary>
    /// Employee record repository.
    /// </summary>
    public class EmployeeRecordRepository : IEmployeeRecordRepository
    {
        private readonly ICsvDataLoader dataLoader;
        private readonly IConfiguration configuration;
        private readonly IHostEnvironment env;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeRecordRepository"/> class.
        /// </summary>
        /// <param name="dataLoader">CSV Data loader.</param>
        /// <param name="configuration">Configuration.</param>
        /// <param name="env">HostEnvironment.</param>
        public EmployeeRecordRepository(ICsvDataLoader dataLoader, IConfiguration configuration, IHostEnvironment env)
        {
            this.dataLoader = dataLoader;
            this.configuration = configuration;
            this.env = env;
        }

        /// <summary>
        /// Get employee record from CSV and Load to EmployeeRecord entity List.
        /// </summary>
        /// <returns>List of Employee records.</returns>
        public Task<List<EmployeeRecord>> GetEmployeeRecordAsync()
        {
            var relativePath = this.configuration["CsvFilePath"];
            if (!string.IsNullOrWhiteSpace(relativePath))
            {
                var filePath = Path.Combine(this.env.ContentRootPath, "wwwroot", "data", relativePath.TrimStart('/'));
                return Task.FromResult(this.dataLoader.LoadDataFromCsv(filePath));
            }
            else
            {
                return Task.FromResult(new List<EmployeeRecord>());
            }
        }
    }
}
