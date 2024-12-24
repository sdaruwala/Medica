// <copyright file="CsvDataLoader.cs" company="Medica">
// Copyright (c) Medica. All rights reserved.
// </copyright>

namespace Medica.Infrastructure.DataServices
{
    using System.Globalization;
    using CsvHelper;
    using CsvHelper.Configuration;
    using Medica.Domain.Entities;
    using Medica.Infrastructure.Interfaces;

    /// <summary>
    /// CSV Loader.
    /// </summary>
    public class CsvDataLoader : ICsvDataLoader
    {
        /// <summary>
        /// Load data from CSV file.
        /// </summary>
        /// <param name="filePath">File path.</param>
        /// <returns>returns data into entity.</returns>
        public List<EmployeeRecord> LoadDataFromCsv(string filePath)
        {
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture));
            return csv.GetRecords<EmployeeRecord>().ToList();
        }
    }
}
