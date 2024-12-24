using AutoMapper;
using Medica.Application.DTOs;
using Medica.Application.Services;
using Medica.Domain.Entities;
using Medica.Infrastructure.Interfaces;
using Moq;


namespace Medica.Tests.Application
{
    public class EmployeeRecordServiceTests
    {
        private readonly Mock<IEmployeeRecordRepository> mockRepository = new();
        private readonly Mock<IMapper> mockMapper = new();

        [Fact]
        public async Task GetEmployeeRecordsAsync_ShouldReturnDtos()
        {
            // Arrange
            var employeeRecords = new List<EmployeeRecord> { new EmployeeRecord { FirstName = "John" } };
            mockRepository.Setup(repo => repo.GetEmployeeRecordAsync()).ReturnsAsync(employeeRecords);

            var dtos = new List<EmployeeRecordDto> { new EmployeeRecordDto { FirstName = "John" } };
            mockMapper.Setup(m => m.Map<List<EmployeeRecordDto>>(employeeRecords)).Returns(dtos);

            var service = new EmployeeRecordService(mockRepository.Object, mockMapper.Object);

            // Act
            var result = await service.GetEmployeeRecordsAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Equal("John", result[0].FirstName);
        }
    }
}
