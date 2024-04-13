using AutoMapper;
using BariStop.Data.Data;
using BariStop.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BariStop.Services.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile() {
            CreateMap<Product, ProductDTO>().ReverseMap();
            
        }
    }
}
