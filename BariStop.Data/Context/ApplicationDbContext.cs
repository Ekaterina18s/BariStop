using BariStop.Data.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BariStop.Data.Context
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Beverage> Beverages { get; set; }
    }
}
