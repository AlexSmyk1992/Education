using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataBaseCreationAtm
{
    [XmlRoot("banks")]
    public class XmlRate
    {
        [XmlElement("bank-id")]
        public List<XmlRateBank> Banks { get; set; }
    }

    public class XmlRateBank
    {
        [XmlElement("idbank")] public int BankId { get; set; }

        [XmlElement("date", DataType = "date")]
        public DateTime Date { get; set; }

        [XmlElement("time", DataType = "time")]
        public DateTime Time { get; set; }

        [XmlElement("usd")] public XmlRateCurrency Usd { get; set; }
        [XmlElement("eur")] public XmlRateCurrency Eur { get; set; }
        [XmlElement("rur")] public XmlRateCurrency Rur { get; set; }
    }

    public class XmlRateCurrency
    {
        [XmlElement("sell")]
        public decimal Sell { get; set; }
        [XmlElement("buy")]
        public decimal Buy { get; set; }
    }
}
