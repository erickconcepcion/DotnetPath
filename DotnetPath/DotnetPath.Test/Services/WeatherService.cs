using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using DotnetPath.Test.ViewModels;
using Newtonsoft.Json;

namespace DotnetPath.Test.Services
{
    public class WeatherService
    {
        public string WeatherUrl => "https://openweathermap.org/data/2.5/weather?lat={0}&lon={1}&appid=b6907d289e10d714a6e88b30761fae22";
        public decimal DefaultLat => 18.478661M;
        public decimal DefaultLong => -69.916360M;

        private WeatherResponse GetWeatherAtPoint(decimal latitude, decimal longitude)
        {
            HttpResponseMessage res = new HttpClient().GetAsync(string.Format(WeatherUrl, latitude, longitude)).Result;
            WeatherResponse wres = JsonConvert.DeserializeObject<WeatherResponse>(res.Content.ReadAsStringAsync().Result);
            wres.statuscode = (int)res.StatusCode;
            return wres;
        }

        public WeatherResponse GetWeather() => GetWeatherAtPoint(DefaultLat, DefaultLong);

    }
}
