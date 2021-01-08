using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApi.Model
{
    public partial class WeatherData
    {


        public class WeatherDataRoot
        {
            public Consolidated_Weather[] consolidated_weather { get; set; }
            public DateTime time { get; set; }
            public DateTime sun_rise { get; set; }
            public DateTime sun_set { get; set; }
            public string timezone_name { get; set; }
            
           
            public string title { get; set; }
            public string location_type { get; set; }
            public int woeid { get; set; }
            public string latt_long { get; set; }
            public string timezone { get; set; }
        }

       
    }
}
