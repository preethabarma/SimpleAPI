using System;
using Xunit;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController Controller =new WeatherForecast();

        [Fact]
        public void GetReturnsweather()
        {
            var returnValue  = Controller.Get(1);

            Assert.Equal("Freezing", returnValue.value);

        }
    }
}
