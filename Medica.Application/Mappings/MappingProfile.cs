// <copyright file="MappingProfile.cs" company="Medica">
// Copyright (c) Medica. All rights reserved.
// </copyright>

namespace Medica.Application.Mappings
{
    using AutoMapper;
    using Medica.Application.DTOs;
    using Medica.Domain.Entities;

    /// <summary>
    /// Map entities.
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MappingProfile"/> class.
        /// </summary>
        public MappingProfile()
        {
            this.CreateMap<EmployeeRecord, EmployeeRecordDto>().ReverseMap();
        }
    }
}
