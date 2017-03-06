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

        private IProductService productService;

        public ProductController(
            IProductService productService)
        {
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
            productService.SaveOrUpdate(model);
            return View(model);
        }
    }
}
