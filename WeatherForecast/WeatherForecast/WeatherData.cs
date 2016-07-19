using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    public class WeatherData
    {
        public string desc { get; set; }
        public int status
        {
            get;
            set;
        }
        public data data
        {
            get;
            set;
        }
    }
    public class data
    {
        public string wendu { get; set; }
        public string ganmao { get; set; }
        public List<forecast> forecast { get; set; }
        public yesterday yesterday { get; set; }
        public string aqi { get; set; }
        public string city { get; set; }
    }
    public class forecast
    {
        public string fengxiang;
        public string fengli;
        public string high;
        public string type;
        public string low;
        public string date;
    }
    public class yesterday
    {
        public string fl;
        public string fx;
        public string high;
        public string type;
        public string low;
        public string date;
    }
}
