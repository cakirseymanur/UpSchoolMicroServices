using AutoMapper;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchoolECommerce.Services.Catalog.Dtos;
using UpSchoolECommerce.Services.Catalog.Models;
using UpSchoolECommerce.Services.Catalog.Settings;
using UpSchoolECommerce.Shared.Dtos;

namespace UpSchoolECommerce.Services.Catalog.Services
{
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMapper _mapper;
        public ProductService(IDatabaseSettings databaseSettings, IMapper mapper)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _productCollection= database.GetCollection<Product>(databaseSettings.CategoryCollectionName);
            _mapper = mapper;

        }
        public Task<ResponseDto<ProductDto>> CreateAsync(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<NoContent>> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<ProductDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<ProductDto>> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<NoContent>> UpdateAsync(UpdateProductDto updateProductDto)
        {
            throw new NotImplementedException();
        }
    }
}
