using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using UpSchoolECommerce.Shared.Dtos;
using UpSchoolMicroServices.Web.Models.Catalogs;
using UpSchoolMicroServices.Web.Services.Abstract;

namespace UpSchoolMicroServices.Web.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;

        public ProductService(HttpClient client)
        {
            _client = client;
        }

        public async Task<bool> CreateProductAsync(ProductCreateViewModel productCreateViewModel)
        {
            var response = await _client.PostAsJsonAsync<ProductCreateViewModel>("Product", productCreateViewModel);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteProductAsync(string productId)
        {
            var response = await _client.DeleteAsync($"Product/{productId}");
            return response.IsSuccessStatusCode;
        }

        public async Task<List<ProductViewModel>> GetAllProductAsync()
        {
            var response = await _client.GetAsync("Product");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var responseSucced = await response.Content.ReadFromJsonAsync<ResponseDto<List<ProductViewModel>>>();
            return responseSucced.Data;
        }

        public async Task<bool> UpdateProductAsync(ProductUpdateViewModel productUpdateViewModel)
        {
            var response = await _client.PutAsJsonAsync<ProductUpdateViewModel>("Product", productUpdateViewModel);
            return response.IsSuccessStatusCode;
        }
    }
}
