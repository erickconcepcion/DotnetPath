using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetPath.Test.ViewModels
{
    public class WeatherResponse
    {
        public Weather main { get; set; }
        public int statuscode { get; set; }
        public string name { get; set; }
    }
}
