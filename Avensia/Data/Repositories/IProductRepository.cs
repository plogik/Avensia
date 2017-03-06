using Avensia.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avensia.Data.Repositories
{
    public interface IProductRepository
    {
        Product GetFirst();
        Product GetById(string id);
        void SaveOrUpdate(Product product);
    }
}
