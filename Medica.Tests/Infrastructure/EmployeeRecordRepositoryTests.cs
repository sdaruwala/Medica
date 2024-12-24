using Medica.Domain.Entities;
using Medica.Infrastructure.Interfaces;
using Moq;

namespace Medica.Tests.Infrastructure
{
    public class EmployeeRecordRepositoryTests
    {
        [Fact]
        public async Task GetEmployeeRecordAsync_ShouldReturnRecords()
        {
            // Arrange
            var mockRepository = new Mock<IEmployeeRecordRepository>();
            mockRepository
                .Setup(repo => repo.GetEmployeeRecordAsync())
                .ReturnsAsync(new List<EmployeeRecord> { new EmployeeRecord { FirstName = "John" } });

            var repository = mockRepository.Object;

            // Act
            var records = await repository.GetEmployeeRecordAsync();

            // Assert
            Assert.NotNull(records);
            Assert.NotEmpty(records);
        }
    }
}
