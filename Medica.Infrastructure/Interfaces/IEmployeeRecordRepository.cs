// <copyright file="IEmployeeRecordRepository.cs" company="Medica">
// Copyright (c) Medica. All rights reserved.
// </copyright>

namespace Medica.Infrastructure.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Medica.Domain.Entities;

    /// <summary>
    /// Employee record repository interface.
    /// </summary>
    public interface IEmployeeRecordRepository
    {
        /// <summary>
        /// Get employee record async.
        /// </summary>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<List<EmployeeRecord>> GetEmployeeRecordAsync();
    }
}
