using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Model;
using NLayer.Core.Repositories;
namespace NLayer.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<Category> GetCategoryByIdWithProducts(int id)
        {
            return await _context.Categories.Include(x => x.Products).Where(c => c.Id == id).SingleOrDefaultAsync();
        }
    }
}