using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using Avensia.Data.Models;

namespace Avensia.Data.Mappings
{
    public class ProductPriceMap : ClassMap<ProductPrice>
    {
        public ProductPriceMap()
        {
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.QuantityFrom);
            Map(x => x.QuantityTo);
            Map(x => x.Price);
        }
    }
}