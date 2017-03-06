using Avensia.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Avensia.Data.ViewModels
{
    public class ProductEditViewModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public int ProductCategoryId { get; set; }
        public int QuantityMin { get; set; }
        public int QuantityMax { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int PriceNow { get; set; }

        public static ProductEditViewModel From(Product product)
        {
            return new ProductEditViewModel()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                ProductCategoryId = product.Category.Id,
                QuantityMin = product.QuantityMin,
                QuantityMax = product.QuantityMax,
                Price = (int)product.Price,
                PriceNow = (int)product.PriceNow
            };
        }
    }
}