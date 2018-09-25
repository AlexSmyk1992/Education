using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Linq2Xml
{
    class Program
    {
        private static string path = "countries.xml";
        static void Main(string[] args)
        {            
            Console.WriteLine("Запросы из файла " + path + "\n\n");
            int menu;
            do
            {
                Message();
                if(Int32.TryParse(Console.ReadLine(),out menu)) //если не распарсило menu = 0
                switch (menu)
                {                    
                    case 1:
                        query1();
                        break;
                    case 2:
                        query2();
                        break;
                    case 3:
                        query3();
                        break;
                    case 4:
                        query4();
                        break;
                    case 5:
                        query5();
                        break;
                    default:
                        menu = 0;
                        break;
                }
            }
            while (menu != 0); 
        }
        public static void query1()
        {
            XDocument xmlDoc = XDocument.Load(path);
            Console.WriteLine("Вывод списка всех стран:");
            IEnumerable<XElement> countries = from t in xmlDoc.Root.Elements("country") //from t in xmlDoc.Descendants("country")
                                              select t;
            foreach (var xmlItem in countries)
            {
                Console.WriteLine("Страна: {0} - {1} человек", xmlItem.Attribute("name").Value, xmlItem.Attribute("population").Value);
            }
            
        }
        public static void query2()
        {
            XDocument xmlDoc = XDocument.Load(path);
            Console.WriteLine("Информация о городах с населением больше 100000 человек:");
            var cities = (from t in xmlDoc.Root.Elements("country").Elements("city")       //from t in xmlDoc.Descendants("city")
                          where t.Elements("population").Any() && Int32.Parse(t.Element("population").Value) > 100000
                          select new
                          {
                              Name = t.Element("name").Value.Trim(),
                              Population = t.Element("population").Value.Trim()
                          }).ToList();
            foreach (var item in cities)
            {
                Console.WriteLine("Город: {0} - {1} человек", item.Name, item.Population);
            }
            
        }
        public static void query3()
        {            
            XDocument xmlDoc = XDocument.Load(path);
            Console.WriteLine("Вывести информацию о континентах и обобщенную информацию по странам:");           
            int number = 0;
            var info = xmlDoc.Descendants("country").Where(p => int.TryParse(p.Attribute("population").Value, out number)
                                                         //&&(int.TryParse(p.Attribute("total_area").Value, out number))
            )
                .GroupBy(t => t.Element("encompassed").Attribute("continent").Value.Trim())
                .Select(g => new
                {
                    Continent = g.Key,
                    Count = g.Count(),
                    Population = g.Sum(p => (XmlConvert.ToInt64(p.Attribute("population").Value ?? null))),
                    Area = g.Sum((p => (XmlConvert.ToDecimal(p.Attribute("total_area").Value ?? null))))
                }).ToList();
            foreach (var item in info)
            {
                Console.WriteLine("Континент: {0}  Стран - {1} шт.   Население : {2} человек  Площадь: {3} км ", item.Continent, item.Count, item.Population, item.Area);
            }            
        }
        public static void query4()
        {
            XDocument xmlDoc = XDocument.Load(path);
            var info = xmlDoc.Descendants("country").
               Where(c => c.Elements("city").Elements("name").Any() && c.Element("city").Attribute("id").Value == c.Attribute("capital").Value).
               Select(i => new {
                   Country = i.Attribute("name").Value.Trim(),
                   Capital = i.Element("city").Element("name").Value.Trim()
               }).ToList();
            foreach (var item in info)
            {
                Console.WriteLine("Страна: {0}  Столица: {1}", item.Country, item.Capital);
            }            
        }
        public static void query5()
        {

            XDocument xmlDoc = XDocument.Load(path);
            var info = (from a in xmlDoc.Descendants("country")
                        where a.Elements("border").Any()
                        select new
                        {
                            Country = a.Element("name").Value.Trim(),
                            BorderCountry = (from bc in xmlDoc.Descendants("country")
                                             join cl in a.Elements("border")
                                             on bc.Attribute("id").Value
                                             equals cl.Attribute("country").Value
                                             select new
                                             {
                                                 BorderCountryName = bc.Element("name").Value.Trim().ToString()
                                             })
                        }).ToList(); 
            foreach (var item in info)
            {
                Console.WriteLine("Страна: {0}", item.Country);
                Console.WriteLine("Количество граничащих стран: {0}", item.BorderCountry.Count());
                for (int i = 0; i < item.BorderCountry.Count(); i++)
                {
                    Console.WriteLine("Граничащая страна: {0}", item.BorderCountry.ElementAt(i).BorderCountryName);
                }
            }                
        }
        public static void Message()
        {
            Console.WriteLine("Нажмите:\n");
            Console.WriteLine("'1' Вывести список всех стран");
            Console.WriteLine("'2' Вывести информацию о городах с населением больше 100000 человек.");
            Console.WriteLine("'3' Вывести информацию о континентах и обобщенную информацию по странам.");
            Console.WriteLine("'4' Вывести список стран со столицами.");
            Console.WriteLine("'5' Вывести название страны, которая граничит с наибольшим количеством стран, и названия этих стран.");
            Console.WriteLine("'0' Выход из программы");
        }         
    }
}
