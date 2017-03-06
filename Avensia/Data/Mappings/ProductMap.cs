using Avensia.Data.Models;
using FluentNHibernate.Mapping;

namespace Avensia.Data.Mappings
{
	class ProductMap : ClassMap<Product>
	{
		public ProductMap()
		{
			Id(x => x.Id);
			Map(x => x.Name);
			Map(x => x.Description);
			References(x => x.Category).Not.LazyLoad();
            Map(x => x.QuantityMin);
            Map(x => x.QuantityMax);
            Map(x => x.Price);
            Map(x => x.PriceNow);
        }
    }
}
