using AutoMapper;
using BariStop.Data.Data;
using BariStop.Data.Repositories.Abstractions;
using BariStop.Services.DTOs;
using BariStop.Services.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BariStop.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public ProductService(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository; 
            _mapper = mapper;
        }
        public async Task CreateProductAsync(ProductDTO product)
        {
            var productEntity = _mapper.Map<Product>(product);
            await _repository.AddAsync(productEntity);
        }

        public async Task DeleteProductAsync(int productId)
        {
             await _repository.DeleteByIdAsync(productId);
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProductsAsync()
        {
            var products = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public Task<ProductDTO> GetProductByIdAsync(int productId)
        {
            return _mapper.Map<ProductDTO>()
        }

        public Task UpdateProductAsync(ProductDTO product)
        {
            throw new NotImplementedException();
        }
    }
}
