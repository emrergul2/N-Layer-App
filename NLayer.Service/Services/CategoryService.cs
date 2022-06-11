using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Model;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
namespace NLayer.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, ICategoryRepository categoryRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<CustomResponseDto<CategoryByIdWithProductsDto>> GetCategoryByIdWithProducts(int categoryId)
        {
            var categoryWithProduct = await _categoryRepository.GetCategoryByIdWithProducts(categoryId);
            var categoryWithProductDto = _mapper.Map<CategoryByIdWithProductsDto>(categoryWithProduct);
            return CustomResponseDto<CategoryByIdWithProductsDto>.Success(200, categoryWithProductDto);
        }
    }
}