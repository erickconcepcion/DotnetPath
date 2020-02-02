using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetPath.Test.ViewModels
{
    public class Weather
    {
        //{"temp":29.77,"feels_like":30.74,"temp_min":28.89,"temp_max":31,"pressure":1017,"humidity":62}
        public decimal temp { get; set; }
        public decimal feels_like { get; set; }
        public decimal temp_min { get; set; }
        public decimal temp_max { get; set; }
        public decimal pressure { get; set; }
        public decimal humidity { get; set; }

    }
}
