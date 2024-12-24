// <copyright file="EmployeeRecordsController.cs" company="Medica">
// Copyright (c) Medica. All rights reserved.
// </copyright>

namespace Medica.API.Controllers
{
    using Medica.Application.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Get Employee records API.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeRecordsController(IEmployeeRecordService employeeRecordService) : ControllerBase
    {
        private readonly IEmployeeRecordService employeeRecordService = employeeRecordService;

        /// <summary>
        /// Get Employee Records.
        /// </summary>
        /// <param name="path">File path.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        [HttpGet]
        public async Task<IActionResult> GetEmployeeRecords()
        {
            try
            {
                var records = await this.employeeRecordService.GetEmployeeRecordsAsync();
                return this.Ok(records);
            }
            catch (Exception ex)
            {

                return this.BadRequest($"Error : {ex.Message}");
            }
        }
    }
}
