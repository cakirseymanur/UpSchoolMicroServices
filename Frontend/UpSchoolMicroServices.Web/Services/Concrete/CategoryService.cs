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
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _client;

        public CategoryService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<CategoryViewModel>> GetAllCategoryAsync()
        {
            var response = await _client.GetAsync("Category");
            //if (!response.IsSuccessStatusCode)
            //{
            //    return null;
            //}
            var responseSucced = await response.Content.ReadFromJsonAsync<ResponseDto<List<CategoryViewModel>>>();
            return responseSucced.Data;
        }
    }
}
