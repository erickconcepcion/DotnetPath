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
        public WeatherResponse GetWeather(decimal a, decimal b) => GetWeatherAtPoint(a,b);

        public WeatherResponse GetWeather(double t, double y) => GetWeatherAtPoint(Convert.ToDecimal(t), Convert.ToDecimal(y));

        public WeatherResponse GetWeather(string LatLon)
        {
            var lalo = JsonConvert.DeserializeObject<LaLo>(LatLon);
            return GetWeatherAtPoint(lalo.Latitude, lalo.Longitude);
        }

        public WeatherResponse GetWeather(string latlon, string separator)
        {
            var latilongi = latlon.Split(separator);
            return GetWeatherAtPoint(decimal.Parse(latilongi[0]), decimal.Parse(latilongi[1]));   
        }
    }
}
