// <copyright file="EmployeeRecord.cs" company="Medica">
// Copyright (c) Medica. All rights reserved.
// </copyright>

using CsvHelper.Configuration.Attributes;
using Medica.Domain.Validator;

namespace Medica.Domain.Entities
{
    /// <summary>
    /// EmployeeRecord Entity.
    /// </summary>
    public record EmployeeRecord
    {
        /// <summary>
        /// Gets the Id of the entity.
        /// </summary>
        public string? FirstName { get; init; }

        /// <summary>
        /// Gets the LastName of the entity.
        /// </summary>
        public string? LastName { get; init; }

        /// <summary>
        /// Gets the Email of the entity.
        /// </summary>
        public string? Email { get; init; }

        /// <summary>
        /// Gets the Telephone of the entity.
        /// </summary>
        public string? Telephone { get; init; }

        /// <summary>
        /// Gets the DateOfBirth of the entity.
        /// </summary>
        [TypeConverter(typeof(CustomDateTimeConverter))]
        public DateTime? DateOfBirth { get; init; }

        /// <summary>
        /// Gets the Address1 of the entity.
        /// </summary>
        public string? Address1 { get; init; }

        /// <summary>
        /// Gets the Address2 of the entity.
        /// </summary>
        public string? Address2 { get; init; }

        /// <summary>
        /// Gets the Town of the entity.
        /// </summary>
        public string? Town { get; init; }

        /// <summary>
        /// Gets the County of the entity.
        /// </summary>
        public string? County { get; init; }

        /// <summary>
        /// Gets the Postcode of the entity.
        /// </summary>
        public string? Postcode { get; init; }

        /// <summary>
        /// Gets the JobTitle of the entity.
        /// </summary>
        public string? JobTitle { get; init; }

        /// <summary>
        /// Gets the Team of the entity.
        /// </summary>
        public string? Team { get; init; }

        /// <summary>
        /// Gets the LineManager of the entity.
        /// </summary>
        public string? LineManager { get; init; }

        /// <summary>
        /// Gets the StartDate of the entity.
        /// </summary>
        [TypeConverter(typeof(CustomDateTimeConverter))]
        public DateTime? StartDate { get; init; }

        /// <summary>
        /// Gets the ProfilePicture of the entity.
        /// </summary>
        public string? ProfilePicture { get; init; }
    }
}
