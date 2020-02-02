using DotnetPath.Test.Services;
using System;
using Xunit;

namespace DotnetPath.Test
{
    public class HelloWorld
    {
        private readonly WeatherService _weatherService;
        public HelloWorld()
        {
            _weatherService = new WeatherService();
        }

        [Fact]
        public void TestAdd()
        {
            var a = 2 + 2;
            Assert.Equal(a, 4);
        }
        [Fact]
        public void TestTernary()
        {
            int a = 0;
            int b = 0;
            var cantBeZero = true;
            if (cantBeZero)
            {
                b += 1;
                              
            }
            cantBeZero = true;
            a = cantBeZero ? 1 : 0; 


            // Use ternary to asing 1 on a variable.

            Assert.Equal(a, b);
        }
        [Fact]
        public void TestNullCheck()
        {
            string a = null;
            string b = null;
            if (string.IsNullOrEmpty(b))
            {
                b = "Hello";
            }

            a = a ??=  "World";

            //use the ?? null check operator to asing other value to a Variable
            Assert.NotNull(b);
            Assert.NotNull(a);

        }

        [Fact]
        public void TestDefaultWeather()
        {
            //nothing to do here
            var weather = _weatherService.GetWeather();
            Assert.NotNull(weather);
            Assert.Equal(200, weather.statuscode);
            Assert.NotEqual(0, weather.main.temp);
        }

        [Fact]
        public void TestDecimaltWeather()
        {
            // Create a GetWeather overload that acept two decimal params
            // go to Services Folder and open WeatherService class
            var weather = _weatherService.GetWeather(18.478661M, -69.916360M);
            Assert.NotNull(weather);
            Assert.Equal(200, weather.statuscode);
            Assert.NotEqual(0, weather.main.temp);
        }

        [Fact]
        public void TestDoubleWeather()
        {
            // Create a GetWeather overload that acept two double params
            var weather = _weatherService.GetWeather(18.478661D, -69.916360D);
            Assert.NotNull(weather);
            Assert.Equal(200, weather.statuscode);
            Assert.NotEqual(0, weather.main.temp);
        }

        [Fact]
        public void TestJsonWeather()
        {
            // Create a GetWeather overload that acept a string, parse the json and finally extract both params
            var lanLatJson = "{\"Latitude\": 18.478661, \"Longitude\": -69.916360}";
            var weather = _weatherService.GetWeather(lanLatJson);
            Assert.NotNull(weather);
            Assert.Equal(200, weather.statuscode);
            Assert.NotEqual(0, weather.main.temp);
        }

        
        [Fact]
        public void TestStringSplitWeather()
        {
            // Create a GetWeather overload that acept two string, the first is the string that has
            // two decimal nums separeted by a character and the other string is the char or chars
            // to split the string and parse both nums to decimal return the weather
            var splitStructure = "18.478661,-69.916360}";
            var weather = _weatherService.GetWeather(splitStructure, ",");
            Assert.NotNull(weather);
            Assert.Equal(200, weather.statuscode);
            Assert.NotEqual(0, weather.main.temp);
        }

    }
}
