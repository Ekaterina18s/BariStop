using BariStop.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BariStop.Services.Services.Abstractions
{
    public class IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
    }
}
