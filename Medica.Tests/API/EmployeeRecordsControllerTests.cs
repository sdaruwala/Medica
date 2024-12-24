using Medica.API.Controllers;
using Medica.Application.DTOs;
using Medica.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Medica.Tests.API
{
    public class EmployeeRecordsControllerTests
    {
        [Fact]
        public async Task GetEmployeeRecords_ShouldReturnOkWithRecords()
        {
            // Arrange
            var mockService = new Mock<IEmployeeRecordService>();
            mockService
                .Setup(service => service.GetEmployeeRecordsAsync())
                .ReturnsAsync(new List<EmployeeRecordDto> { new EmployeeRecordDto { FirstName = "John" } });

            var controller = new EmployeeRecordsController(mockService.Object);

            // Act
            var result = await controller.GetEmployeeRecords();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var records = Assert.IsAssignableFrom<List<EmployeeRecordDto>>(okResult.Value);
            Assert.Single(records);
            Assert.Equal("John", records[0].FirstName);
        }

        [Fact]
        public async Task GetEmployeeRecords_ShouldReturnBadRequestOnError()
        {
            // Arrange
            var mockService = new Mock<IEmployeeRecordService>();
            mockService
                .Setup(service => service.GetEmployeeRecordsAsync())
                .ThrowsAsync(new System.Exception("Test Exception"));

            var controller = new EmployeeRecordsController(mockService.Object);

            // Act
            var result = await controller.GetEmployeeRecords();

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Contains("Test Exception", badRequestResult.Value.ToString());
        }
    }
}
