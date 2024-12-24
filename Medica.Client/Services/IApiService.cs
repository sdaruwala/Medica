// <copyright file="IApiService.cs" company="Medica">
// Copyright (c) Medica. All rights reserved.
// </copyright>

namespace Medica.Client.Services
{
    using Medica.Application.DTOs;

    /// <summary>
    /// Interface for API Service.
    /// </summary>
    public interface IApiService
    {
        /// <summary>
        /// Get employee record via API.
        /// </summary>
        /// <returns>Employee List.</returns>
        Task<List<EmployeeRecordDto>> GetEmployeeRecordsAsync();
    }
}
