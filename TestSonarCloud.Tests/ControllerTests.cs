using TestSonarCloud.Controllers;
using Xunit;

namespace TestSonarCloud.Tests
{
    public class ControllerTests
    {
        [Fact]
        public void Test()
        {
            var sut = new WeatherForecastController(null);

            var weathers = sut.Get();

            Assert.NotNull(weathers);
        }
    }
}
