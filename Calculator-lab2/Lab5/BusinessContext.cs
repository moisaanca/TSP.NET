using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Calculator_lab2.Lab5
{
    public class BusinessContext: DbContext
    {
        public DbSet<Business> Businesses { get; set; }

        public BusinessContext() : base()
        { }
    }
}
