// <copyright file="ICsvDataLoader.cs" company="Medica">
// Copyright (c) Medica. All rights reserved.
// </copyright>

namespace Medica.Infrastructure.Interfaces
{
    using Medica.Domain.Entities;

    /// <summary>
    /// Csv Loader interface.
    /// </summary>
    public interface ICsvDataLoader
    {
        /// <summary>
        /// Load Data from CSV file.
        /// </summary>
        /// <param name="filePath">Filepath.</param>
        /// <returns>List of Employee record.</returns>
        List<EmployeeRecord> LoadDataFromCsv(string filePath);
    }
}
