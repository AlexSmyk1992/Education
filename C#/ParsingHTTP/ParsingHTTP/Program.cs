using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ParsingHTTP
{
    class Program
    {
        static void Main(string[] args)

        {
            List<LogEntry> entries = new List<LogEntry>();
            //проверка что args.length=2;
            StringBuilder result = new StringBuilder();  //класс для построения строк  
            /*string result2;
            result2 = "";
            result2 += "top Domain"; //добавляет в конец
            result2 += "\r\n";
            result2 += // это в foreach прибавить его резалт*/
            foreach (var line in File.ReadAllLines(args[0]))
            {
                LogEntry entry = new LogEntry();
                entry.Entry = line;
                //1        //2      //3
                string pattern = @"https?://([-\w\.]+)(/[^?\s]+)?(\?\S+)?";

                var match = Regex.Match(line, pattern);
                if (match.Success)
                {

                    entry.Domain = match.Groups[1].Value;  //группа 1 ([-\w\.]+)
                    entry.Path = match.Groups[2].Success ? match.Groups[2].Value : null; //2(/[^?\s]+)
                    entry.Query = match.Groups[3].Success ? match.Groups[3].Value : null; //3(\?\S+)?                                                                                          
                    entries.Add(entry);
                }
            }
            Dictionary<string, int> dictDomain = new Dictionary<string, int>();
            foreach (var e in entries) //элемент из листа
            {
                if (dictDomain.ContainsKey(e.Domain)) //проверяет были ли такие домены 
                { // если был домен то увеличить int
                    dictDomain[e.Domain]++; // = dict[e.Domain] +1;
                }
                else //иначе добавить 1й 
                {
                    dictDomain[e.Domain] = 1;
                }
            }
            result.AppendLine("top domains");// в объект класса stringbuilder добавляет строку("") и перевод строки(Line)
            foreach (var d in dictDomain.OrderByDescending(d2 => d2.Value))// по словарю отсорт-му по убыванию по значению(int)
            {
                result.AppendLine(String.Format("{0} {1} ", d.Value, d.Key)); // append line в конце добавляет перенос строки, а append не добавляет. Здесь просто сощдается новая строка, и добавляется в конец резалта
            }
            result.AppendLine(); // перевод строки
            result.AppendLine();
            Dictionary<string, int> dictPath = new Dictionary<string, int>();

            foreach (var e in entries) //элемент из листа
            {
                if (dictPath.ContainsKey(e.Path)) //проверяет были ли такие пути 
                { // если был домен то увеличить int
                    dictPath[e.Path]++; // = dict[e.Path] +1;
                }
                else //иначе добавить 1й 
                {
                    dictPath[e.Path] = 1;
                }
            }
            result.AppendLine("top path");
            foreach (var d in dictPath.OrderByDescending(d2 => d2.Value))// по словарю отсорт-му по убыванию по значение(int)
            {
                result.AppendLine(String.Format("{0} {1} ", d.Value, d.Key));
            }
            File.WriteAllText(args[1], result.ToString()); //в файл файл добавляем выходную строку 
            // groupby path;   
        }
    }
}

/* var res = entries.GroupBy(e => e.Domain).Select(g=>new {Domain = g.Key,Count = g.Count()}).OrderByDescending(g=>g.Count).ToList();
           foreach (var r in res)
           {
           Console.WriteLine("{0} {1} ", r.Count, r.Domain);
       }*/
