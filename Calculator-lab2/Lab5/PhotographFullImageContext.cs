using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Calculator_lab2.Lab5
{
    public class PhotographFullImageContext: DbContext
    {
        public DbSet<PhotographFullImage> PhotographFullImages { get; set; }
    }
}
