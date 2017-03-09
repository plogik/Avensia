using Avensia.Data.Models;
using Avensia.Data.Repositories;
using Avensia.Data.Services;
using Avensia.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avensia.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productRepos;
        private IProductService productService;

        public ProductController(
            IProductRepository productRepos,
            IProductService productService)
        {
            this.productRepos = productRepos;
            this.productService = productService;
        }

        // GET: Product
        public ActionResult Index()
        {
            return RedirectToRoute("ProductDetails", new { Id = productService.GetFrontPageProduct().Id });
        }

        // GET: sortiment/p_id_5
        public ActionResult Details(string id)
        {
            return View(productService.GetById(id));
        }

        // GET: Product/Edit/5
        public ActionResult Edit(string id)
        {
            return View(productService.GetEditModel(id));
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(ProductEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            // Need to pick prices again since they are not part of this edit action
            model.Prices = productService.GetEditModel(model.Id).Prices;

            productService.SaveOrUpdate(model);
            return View(model);
        }

        public ActionResult EditPrice(string id)
        {
            return View(productService.GetEditModel(id));
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult EditPrice(ProductEditViewModel model, string command)
        {
            if (command == "Add")
            {
                model.Prices.Add(new ProductPrice { });
            }
            else if (command == "Remove Selected")
            {
                // TODO: nHibernate does not update removed child records,
                // must delete them manually(?). 
                model.Prices
                    .Where(pp => pp.Delete)
                    .ToList()
                    .ForEach(pp => productRepos.Delete(pp));

                model.Prices = model.Prices.Where(pp => !pp.Delete).ToList();

            }
            productService.SaveOrUpdate(model);
            return Redirect(Request.UrlReferrer.PathAndQuery);
        }
    }
}
