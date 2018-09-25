using System;
using System.Text.RegularExpressions;

namespace WeatherXML
{
    public class CurrentWeather
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Temperature { get; set; }
        private static Regex TemperatureRegex = new Regex(@"температура (-?\d+)\.\.(-?\d+) С",RegexOptions.Multiline);
        public void Parse()
        {                       
            var m = TemperatureRegex.Match(Description);
            if(!m.Success)
            {
                throw new Exception("Не могу распарсить температуру");
            }
            var t1 = Int32.Parse(m.Groups[1].Value);
            var t2 = Int32.Parse(m.Groups[2].Value);
            Temperature = Math.Max(t1, t2);
        }
    }
}