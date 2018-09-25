using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using XmlReadArtists.ProducerInfo;

namespace XmlReadArtists.ProducerRepository1
{
    public static class ProducerRepository
    {
        private static List<ProducerInform> ProducerList;
        static ProducerRepository()
        {
            ProducerList = new List <ProducerInform>();
        }
        /// <summary>
        /// Method returns list of producers from xml-file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<ProducerInform> ReadXmlCallProd(string path)
        {
            try
            {
                ProducerList = (from el in XDocument.Load(path).Root.Elements("PRODUCER")
                                select new ProducerInform
                                {
                                    Id = (int)el.Element("ID"),
                                    Name = (string)el.Element("NAME"),
                                    Date = DateTime.Parse(el.Element("DATE").Value),
                                    Fee = (int)el.Element("FEE")
                                }).ToList();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message.ToString() + "\nПриложение будет закрыто, после нажатия кнопки 'OK'");
                Environment.Exit(0);
            }            
            return ProducerList;
        }
    }
}
