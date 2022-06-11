using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using NLayer.Core.DTOs;
namespace NLayer.Service.Validation
{
    public class ProductDtoValidator : AbstractValidator<ProductDto>
    {
        public ProductDtoValidator()
        {
            RuleFor(p => p.CategoryId).GreaterThan(0).WithMessage("{PropertyName} must be greater then 0");
            RuleFor(p => p.Name).NotNull().NotEmpty();
            RuleFor(p => p.Price).GreaterThan(0).WithMessage("{PropertyName} must be greater then 0");
            RuleFor(p => p.Stock).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater then 0");
        }
    }
}