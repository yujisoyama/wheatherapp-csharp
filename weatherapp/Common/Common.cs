using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Sensors;

namespace weatherapp.Common
{
    public class Common
    {
        public static string API_LINK = "https://api.openweathermap.org/data/2.5/weather";
        public static string API_KEY = "2e2d289822ca03230b80ad9c3ba868d6";

        public static string APIRequest(string lat, string lon)
        {
            StringBuilder strBuilder = new StringBuilder(API_LINK);
            //&units=metric to convert temp to celsius
            strBuilder.AppendFormat("?lat={0}&lon={1}&appid={2}&units=metric", lat, lon, API_KEY);
            return strBuilder.ToString();
        }

        public static DateTime ConvertUnixTimeToDateTime(double unix)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dt = dt.AddSeconds(unix).ToLocalTime();
            return dt;
        }
    }
}
