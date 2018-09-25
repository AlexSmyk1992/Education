using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WeatherXML
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string[] text = File.ReadAllLines(args[0], Encoding.UTF8);
                Dictionary<string, string> dictionary = DictionaryCodes.GetCodes(text);
                int num;
                do
                {
                    Console.WriteLine("Прогноз погоды\n");
                    Console.WriteLine("Нажмите: \n");
                    Console.WriteLine("'1' Для просмотра погоды в городах (город с большой буквы) ");
                    Console.WriteLine("'2' Для поиска и вывода самой теплой погоды в городах нажмите ");
                    Console.WriteLine("'3' для выхода из программы");                    
                    if(!Int32.TryParse(Console.ReadLine(),out num))
                    {
                        Console.WriteLine("Введено неправильное значение, выберете '1','2' или '3'");
                        continue;
                    }
                    if (3<num||num<1)
                    {
                        Console.WriteLine("Введено неправильное значение, выберете '1','2' или '3'");
                        continue;
                    }
                    switch (num)
                    {
                        case 1:
                            CityWeather(dictionary);
                            break;
                        case 2:
                            MaxTemp(dictionary);
                            break;
                        case 3:
                            return;
                        default:
                            break;
                    }
                }
                while (num != 3);            
            }
            Console.Read();
        }
        public static void CityWeather(Dictionary<string, string> dictionary)
        {
            string urlPattern = @"http://informer.gismeteo.by/rss/{0}.xml";
            Console.WriteLine("Введите город");
            string p;
            do
            {
                p = Console.ReadLine();
                if (String.IsNullOrEmpty(p))
                {
                    return;
                }
                if (!dictionary.ContainsKey(p))
                {
                    Console.WriteLine("Неправильный ввод названия города, введите заново(с большой буквы)"); // если неправильный ввод, выкидывает в do       
                }                
                else
                {
                    break;
                }                
            }
            while (true);           
            var url = string.Format(urlPattern, dictionary[p]);           
            List<CurrentWeather> wList = WeatherLib.GetWeather(url);
            foreach (var w in wList)
            {
                Console.WriteLine(w.Title);
                Console.WriteLine(w.Description);
                Console.WriteLine();
            }
        }
        public static void MaxTemp(Dictionary<string, string> dictionary)
        {
            string urlPattern = @"http://informer.gismeteo.by/rss/{0}.xml";
            var dictForSortbyWeather = new Dictionary<string, List<CurrentWeather>>();
            foreach (var d in dictionary)
            {
                var cityUrl = string.Format(urlPattern, d.Value);
                var cityWlist = WeatherLib.GetWeather(cityUrl);
                dictForSortbyWeather[d.Key] = cityWlist; // по ключу(название города) положил список погод                                 
            }                                                                                               //отсортированный список currentweather у каждого города
            var res = dictForSortbyWeather.Select(d => new { City = d.Key, MaxTemp = d.Value.OrderByDescending(w => w.Temperature).First().Temperature })
                .OrderByDescending(d => d.MaxTemp).First(); // Select проходит по каждому элементу d из dictSort... и для каждого элемента создает анонимный объект
                                                            //у которого 2 поля City и MaxTemp. City = d.Key , а MaxTemp берет у d сортированные значения по температуре и берет 1ю и достает из него 
                                                            //температуру. Получившийся список анонимных объектов сортируем по температуре и достаем первый
            Console.WriteLine("Максимальная температура в городе {0} : {1} C", res.City, res.MaxTemp);
        }
    }    
}