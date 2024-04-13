using BariStop.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BariStop.Services.Services.Abstractions
{
    public interface IBeverageService
    {
        Task<IEnumerable<BeverageDTO>> GetAllBeveragesAsync();
        Task<IEnumerable<BeverageDTO>> GetAllBeveragesByProductIdAsync(int productId);
        Task<BeverageDTO> GetBeverageByIdAsync(int beverageId);
        Task CreateBeverageAsync(BeverageDTO beverage);
        Task UpdateBeverageAsync(BeverageDTO beverage);
        Task DeleteBeverageAsync(int beverageId);
    }
}
