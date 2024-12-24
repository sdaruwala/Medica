// <copyright file="IEmployeeRecordService.cs" company="Medica">
// Copyright (c) Medica. All rights reserved.
// </copyright>

namespace Medica.Application.Interfaces
{
    using Medica.Application.DTOs;

    /// <summary>
    /// Employee record interface.
    /// </summary>
    public interface IEmployeeRecordService
    {
        /// <summary>
        /// Get Employee records.
        /// </summary>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<List<EmployeeRecordDto>> GetEmployeeRecordsAsync();
    }
}
