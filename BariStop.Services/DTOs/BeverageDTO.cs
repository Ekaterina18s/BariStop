using BariStop.Data.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BariStop.Services.DTOs
{
    public class BeverageDTO : BaseDTO 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Ingredients { get; set; }
        public string Caffeine { get; set; }
        public double Size { get; set; }
        public int ProductId { get; set; }
    }
}
