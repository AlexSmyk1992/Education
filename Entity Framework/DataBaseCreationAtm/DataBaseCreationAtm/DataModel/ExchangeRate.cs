using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseCreationAtm.DataModel
{
    public class ExchangeRate
    {
        public int Id { get; set; }
        public int BankId { get; set; }
        public string СurrencyСode { get; set; }
        public decimal Sell { get; set; }
        public decimal Buy { get; set; }
        public virtual Bank Bank { get; set; }
    }
}
