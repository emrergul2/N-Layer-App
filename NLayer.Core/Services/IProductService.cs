using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NLayer.Core.DTOs;
using NLayer.Core.Model;
namespace NLayer.Core.Services
{
    public interface IProductService : IService<Product>
    {
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory();
    }
}