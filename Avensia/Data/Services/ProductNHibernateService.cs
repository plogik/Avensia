using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Avensia.Data.ViewModels;
using Avensia.Data.Repositories;
using Avensia.Data.Models;
using NHibernate.Linq;

namespace Avensia.Data.Services
{
    public class ProductNHibernateService : IProductService
    {
        private IProductRepository productRepos;

        public ProductNHibernateService(IProductRepository productRepos)
        {
            this.productRepos = productRepos;
        }

        public ProductViewModel GetFrontPageProduct()
        {
            return GetById(productRepos.GetFirst().Id);
        }

        public ProductViewModel GetById(string id)
        {
            var product = productRepos.GetById(id);
            var productDetail = ProductViewModel.From(product);
            productDetail.Similar = GetSimilar(product);
            return productDetail;
        }

        public ProductEditViewModel GetEditModel(string id)
        {
            return ProductEditViewModel.From(productRepos.GetById(id));
        }

        public void SaveOrUpdate(ProductEditViewModel productViewModel)
        {
            var product = new Product();
            product.Id = productViewModel.Id;
            product.Name = productViewModel.Name;
            product.Description = productViewModel.Description;
            product.QuantityMin = productViewModel.QuantityMin;
            product.QuantityMax = productViewModel.QuantityMax;
            product.Prices = productViewModel.Prices;
            product.PriceNow = productViewModel.PriceNow;

            product.Prices = productViewModel.Prices;
            product.Category = productRepos.GetById(productViewModel.Id).Category;

            productRepos.SaveOrUpdate(product);
        }

        private static IList<ProductViewModel> GetSimilar(Product product)
        {
            var sessionFactory = FluentNHibernateSessionFactory.CreateSessionFactory();
            using (var session = sessionFactory.OpenSession())
            {
                return session.Query<Product>()
                    .Where(p => p.Id != product.Id)
                    .Select(p => ProductViewModel.From(p))
                    .ToList();
            }
        }
    }
}