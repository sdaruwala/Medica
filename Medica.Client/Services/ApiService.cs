// <copyright file="ApiService.cs" company="Medica">
// Copyright (c) Medica. All rights reserved.
// </copyright>

namespace Medica.Client.Services
{
    using Medica.Application.DTOs;

    /// <summary>
    /// HTTP Client Service.
    /// </summary>
    public class ApiService : IApiService
    {
        private readonly HttpClient httpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiService"/> class.
        /// </summary>
        /// <param name="httpClient">httpClient instance.</param>
        public ApiService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        /// <inheritdoc/>
        public async Task<List<EmployeeRecordDto>> GetEmployeeRecordsAsync()
        {
            return await this.httpClient.GetFromJsonAsync<List<EmployeeRecordDto>>("api/EmployeeRecords") ?? [];
        }
    }
}
