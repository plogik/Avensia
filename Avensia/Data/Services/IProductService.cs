using Avensia.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avensia.Data.Services
{
    public interface IProductService
    {
        ProductViewModel GetFrontPageProduct();
        ProductViewModel GetById(string id);
        ProductEditViewModel GetEditModel(string id);
        void SaveOrUpdate(ProductEditViewModel productViewModel);
    }
}
