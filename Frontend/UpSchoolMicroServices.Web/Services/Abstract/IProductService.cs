using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchoolMicroServices.Web.Models.Catalogs;

namespace UpSchoolMicroServices.Web.Services.Abstract
{
    public interface IProductService
    {
        Task<List<ProductViewModel>> GetAllProductAsync();
        Task<bool> CreateProductAsync(ProductCreateViewModel productCreateViewModel);
        Task<bool> UpdateProductAsync(ProductUpdateViewModel productUpdateViewModel);
        Task<bool> DeleteProductAsync(string productId);
    }
}
