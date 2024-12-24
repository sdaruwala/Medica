// <copyright file="CustomDateTimeConverter.cs" company="Medica">
// Copyright (c) Medica. All rights reserved.
// </copyright>

namespace Medica.Domain.Validator
{
    using System;
    using System.Globalization;
    using CsvHelper;
    using CsvHelper.Configuration;
    using CsvHelper.TypeConversion;

    /// <summary>
    /// Covert Date field as per CSVHelper.
    /// </summary>
    public class CustomDateTimeConverter : DateTimeConverter
    {
        /// <inheritdoc/>
        public override object? ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData)
        {
            if (!string.IsNullOrWhiteSpace(text) &&
                DateTime.TryParseExact(text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var date))
            {
                return date;
            }
            return base.ConvertFromString(text, row, memberMapData); // Handle null or invalid formats
        }
    }
}
