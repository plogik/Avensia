using Avensia.Data.Models;
using System;
using System.Collections.Generic;

namespace Avensia.Data.ViewModels
{
    public class ProductViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductCategory Category { get; set; }
        public int QuantityMin { get; set; } = 1;
        public int QuantityMax { get; set; } = int.MaxValue;
        public int PriceNow { get; set; }
        public IList<ProductPrice> Prices { get; set; }
        public IList<ProductViewModel> Similar { get; set; }

        public static ProductViewModel From(Product product)
        {
            return new ProductViewModel()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Category = product.Category,
                QuantityMin = product.QuantityMin,
                QuantityMax = product.QuantityMax,
                Prices = product.Prices,
                PriceNow = (int)product.PriceNow
            };
        }
    }
}