using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchoolMicroServices.Web.Services.Abstract;

namespace UpSchoolMicroServices.Web.Controllers
{
    [AllowAnonymous]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _categoryService.GetAllCategoryAsync());
        }
    }
}
