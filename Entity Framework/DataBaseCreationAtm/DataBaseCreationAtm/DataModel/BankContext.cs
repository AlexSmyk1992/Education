namespace DataBaseCreationAtm.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BankContext : DbContext
    {
        public BankContext()
            : base("DBConnection")
        {
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<ExchangeRate> ExchangeRates { get; set; }
    }
}