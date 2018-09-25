using System.Collections.Generic;
using System.Xml.Linq;

namespace WeatherXML
{
    public static class WeatherLib
    {
        public static List<CurrentWeather> GetWeather(string url)
        {           
            XDocument doc = XDocument.Load(url);
            List<CurrentWeather> lstWeather = new List<CurrentWeather>();
            foreach (var item in doc.Root.Element("channel").Elements("item"))
            {
                var w = new CurrentWeather() // создал погоду
                {
                    Description = item.Element("description").Value, // заполнил
                    Title = item.Element("title").Value
                };
                w.Parse();  // вытащил температуру
                lstWeather.Add(w);                          
            }            
            return lstWeather;
        }
    }
}