using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace WeatherForecast
{
    class HTTP
    {
        public string url
        {
            get;
            set;
        }
        public string cityNum
        {
            get;
            set;
        }
        public HTTP()
        {
            this.url = "http://wthrcdn.etouch.cn/weather_mini?city=";
            this.cityNum = "北京";
        }

        public string getWeather(string cityName)
        {
            this.cityNum = cityName;
            string finalUrl = url + cityNum;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(finalUrl);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            request.UserAgent = "Mozilla/5.0 (X11; Linux i686) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.63 Safari/537.36";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream);
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;

        }
    }
}
