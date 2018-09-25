using System.Collections.Generic;

namespace WeatherXML
{
    public static class DictionaryCodes
    {
        public static Dictionary<string, string> GetCodes(string[] text)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            char delimiter = ' ';
            string[] substrings;
            for (int i = 0; i < text.Length; i++)
            {
                substrings = text[i].Split(delimiter);
                dict[substrings[1]] = substrings[0];
            }
         return dict;
         }
    }
}


