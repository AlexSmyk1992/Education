using DataBaseCreationAtm.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace DataBaseCreationAtm
{
    class Program
    {
        static void Main(string[] args)
        {
            method();
        }
        public static void method()
        {
            try
            {
                string url = "http://www.obmennik.by/xml/kurs.xml";
                XDocument xmlDocHttp = XDocument.Load(url);
                var s = new XmlSerializer(typeof(XmlRate));
                XmlRate rate;
                using (var web = new WebClient().OpenRead(url))
                {
                    rate = (XmlRate)s.Deserialize(web);
                }

                XDocument xmlDoc = XDocument.Load("banks.xml");
                var departments = xmlDoc.Element("Banks")
                    .Elements("bank")
                    .SelectMany(t => t.Elements("departmen"), (t, d) => new { t, d })
                    .Where(x =>
                        x.t.Attribute("BankId") != null)
                    .Select(x => new
                    {
                        id = int.Parse(x.d.Element("id").Value),
                        address = x.d.Element("address").Value.ToString(),
                        latitude = double.Parse(x.d.Element("latitude").Value),
                        longtitude = double.Parse(x.d.Element("longitude").Value),
                        bankId = int.Parse(x.t.Attribute("BankId").Value),
                        bankName = x.t.Attribute("name").Value
                    }).ToList();
                //foreach (var item in departments)
                //{
                //    Console.WriteLine(
                //        "ID - {0}\n Address - {1}\n latitude - {2}\n longitude - {3}\n bankId - {4}\n Bankname - {5}",
                //        item.id, item.address,
                //        item.latitude, item.longtitude, item.bankId, item.bankName);
                //}

                var dictDeparLookup = departments.ToLookup(d => d.bankId);

                using (BankContext bc = new BankContext())
                {
                    foreach (var item in dictDeparLookup)
                    {
                        //Console.WriteLine("{0}-{1}", item.Key, item.First().bankName);
                        var bank = new Bank()
                        {
                            BankName = item.First().bankName,
                            Id = item.Key
                        };
                        //create departments
                        foreach (var dep in item)
                        {
                            var department = new Department()
                            {
                                Bank = bank,
                                Id = dep.id,
                                Address = dep.address,
                                BankId = dep.bankId,
                                Latitude = dep.latitude,
                                Longitude = dep.longtitude,
                                ObjectName = string.Format("Отделение {0}", dep.id)
                            };
                            bank.Departments.Add(department);

                            //Console.WriteLine("{0}-{1} {2} {3} Координаты: {4}-{5}", department.Id, department.Address,
                            //    department.Bank.BankName,
                            //    department.ObjectName, department.Longitude, department.Latitude);
                        }

                        //create ExchangeRates
                        foreach (var xmlBank in rate.Banks)
                        {
                            var rateUsd = new ExchangeRate()
                            {
                                СurrencyСode = "usd",
                                Buy = xmlBank.Usd.Buy,
                                Sell = xmlBank.Usd.Sell,
                                BankId = xmlBank.BankId
                            };
                            var rateEur = new ExchangeRate()
                            {
                                СurrencyСode = "eur",
                                Buy = xmlBank.Usd.Buy,
                                Sell = xmlBank.Usd.Sell,
                                BankId = xmlBank.BankId
                            };
                            var rateRur = new ExchangeRate()
                            {
                                СurrencyСode = "rur",
                                Buy = xmlBank.Usd.Buy,
                                Sell = xmlBank.Usd.Sell,
                                BankId = xmlBank.BankId
                            };
                            bank.ExchangeRates.Add(rateUsd);
                            bank.ExchangeRates.Add(rateEur);
                            bank.ExchangeRates.Add(rateRur);
                        }

                        bc.Banks.Add(bank);
                        
                       

                    }
                    bc.SaveChanges();
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }


        }
    }
}



//var rates = from b in xmlDocHttp.Element("banks").Elements("bank-id")
//            from 

//var rates = xmlDocHttp.Element("banks").Elements("bank-id").Select(t => new
//{
//    BankId = int.Parse(t.Element("idbank").Value),
//    СurrencyСode = t.Element("usd").Name,
//}).ToList();
//foreach (var itemRate in rates)
//{
//    Console.WriteLine("{0} - {1}", itemRate.BankId, itemRate.СurrencyСode);
//}