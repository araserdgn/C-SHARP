using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bussines.ValidationRules.FluentValidation
{
    // fluent validation kurallarını incele
    public class ProductValidation: AbstractValidator<Product>  // BEN ÜRÜN ÜÇÜN KURALLAR YAZCAM

    {
        public ProductValidation()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün ismi BOş olamaz"); // NAme boş olmamalı
            RuleFor(p=>p.CategoryId).NotEmpty();
            RuleFor(p=>p.UnitPrice).NotEmpty();
            RuleFor(p=>p.QuantityPerUnit).NotEmpty();
            RuleFor(p=>p.UnitsInStock).NotEmpty();

            RuleFor(p=>p.UnitPrice).GreaterThan(0); // UnitPrice 0 dan büyük olmalı
            RuleFor(p=>p.UnitsInStock).GreaterThanOrEqualTo((short)0); // Ürün yok tedarik etmelisin
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);
            // Category 2 olduğunda Unit min. 10 olmalı demek

            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürün A ile başlamalı"); // NAme A ile BAŞLAMALI DEMEK
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A"); // NAME a İLE BASLIYORSA TRUE DONER
        }
    }
}
