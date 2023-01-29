using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchoolMicroServices.Web.Models.Catalogs;

namespace UpSchoolMicroServices.Web.Services.Abstract
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetAllCategoryAsync();
    }
}
