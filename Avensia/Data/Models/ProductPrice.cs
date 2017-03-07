using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avensia.Data.Models
{
    public class ProductPrice
    {
        public virtual int Id { get; protected set; }
        public virtual int QuantityFrom { get; set; } = 0;
        public virtual int QuantityTo { get; set; } = int.MaxValue;
        public virtual decimal Price { get; set; }
    }
}