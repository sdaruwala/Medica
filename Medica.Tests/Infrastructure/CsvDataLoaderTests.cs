using Medica.Infrastructure.DataServices;

namespace Medica.Tests.Infrastructure;

public class CsvDataLoaderTests
{

    [Fact]
    public void LoadDataFromCsv_ShouldReturnEmployeeRecords()
    {
        // Arrange
        var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "dataset.csv");
        var csvDataLoader = new CsvDataLoader();

        // Act
        var result = csvDataLoader.LoadDataFromCsv(filePath);

        // Assert
        Assert.NotNull(result);
        Assert.All(result, record => Assert.NotNull(record.FirstName));
    }

}
