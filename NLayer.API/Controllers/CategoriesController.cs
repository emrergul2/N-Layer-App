using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLayer.Core.Services;
namespace NLayer.API.Controllers
{
    public class CategoriesController : CustomBaseController
    {
        public readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("[action]/{categoryId}")]
        public async Task<IActionResult> GetCategoryByIdWithProducts(int categoryId)
        {
            return CreateActionResult(await _categoryService.GetCategoryByIdWithProducts(categoryId));
        }
    }
}
