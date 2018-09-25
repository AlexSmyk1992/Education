using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseCreationAtm.DataModel
{
    public class Bank
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string BankName { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<ExchangeRate> ExchangeRates { get; set; }
        public Bank()
        {
            Departments = new List<Department>();
            ExchangeRates = new List<ExchangeRate>();
        }

    }
}
