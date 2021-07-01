using System;
using Xunit;
using SimpleAPI.Controllers;
namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        //arrange
        WeatherForecastController wc =new WeatherForecastController ();
        [Fact]
        public void Test1()
        {
            //act
var result=wc.FetchData(1);
//assert
Assert.Equal("Rajeev Porwal",result);
        }
    }
}
