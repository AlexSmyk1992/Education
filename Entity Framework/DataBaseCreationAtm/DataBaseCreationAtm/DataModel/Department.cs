using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseCreationAtm.DataModel
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string ObjectName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string WorkTime { get; set; }        
        public double Latitude { get; set; }
        public double Longitude { get; set; }        
        public int BankId { get; set; }
        public virtual Bank Bank { get; set; }
    }
}
