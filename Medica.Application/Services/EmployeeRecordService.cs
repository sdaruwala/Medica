// <copyright file="EmployeeRecordService.cs" company="Medica">
// Copyright (c) Medica. All rights reserved.
// </copyright>

namespace Medica.Application.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AutoMapper;
    using Medica.Application.DTOs;
    using Medica.Application.Interfaces;
    using Medica.Infrastructure.Interfaces;

    /// <summary>
    /// Employee Record Services.
    /// </summary>
    public class EmployeeRecordService : IEmployeeRecordService
    {
        private readonly IEmployeeRecordRepository employeeRecordRepository;
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeRecordService"/> class.
        /// </summary>
        /// <param name="employeeRecordRepository">Repository.</param>
        /// <param name="mapper">Mapper.</param>
        public EmployeeRecordService(IEmployeeRecordRepository employeeRecordRepository, IMapper mapper)
        {
            this.employeeRecordRepository = employeeRecordRepository;
            this.mapper = mapper;
        }

        /// <inheritdoc/>
        public async Task<List<EmployeeRecordDto>> GetEmployeeRecordsAsync()
        {
            var records = await this.employeeRecordRepository.GetEmployeeRecordAsync();
            return this.mapper.Map<List<EmployeeRecordDto>>(records);
        }
    }
}
