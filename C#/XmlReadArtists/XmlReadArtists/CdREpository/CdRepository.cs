using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using XmlReadArtists.CdInfo;

namespace XmlReadArtists.CDREpository
{
    public static class CdRepository
    {
        private static List<CDInfo> DisksList;
        static CdRepository()
        {
            DisksList = new List<CDInfo>();
        }
        /// <summary>
        /// Method returns list of CD from xml-file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<CDInfo> ReadXmlToCollection(string path)
        {
            try
            {
                DisksList = (from el in XDocument.Load(path).Root.Elements("CD")
                             select new CDInfo
                             {
                                 Title = (string)el.Element("TITLE"),
                                 Artist = (string)el.Element("ARTIST"),
                                 Country = (string)el.Element("COUNTRY"),
                                 Company = (string)el.Element("COMPANY"),
                                 Price = (double)el.Element("PRICE"),
                                 Year = (int)el.Element("YEAR"),
                                 Producer = (int)el.Element("PRODUCER")
                             }).ToList();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message.ToString() + "\nПриложение будет закрыто, после нажатия кнопки 'OK'");
                Environment.Exit(0);
            }
            return DisksList;
        }
    }
}
