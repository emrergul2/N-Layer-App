using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace NLayer.Core.DTOs
{
    public class CategoryByIdWithProductsDto : CategoryDto
    {
        public List<ProductDto> Products { get; set; }
    }
}