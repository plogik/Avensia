using Avensia.Data.Models;
using FluentNHibernate.Mapping;

namespace Avensia.Data.Mappings
{
	class ProductCategoryMap : ClassMap<ProductCategory> 
	{
		public ProductCategoryMap()
		{
			Id(x => x.Id).GeneratedBy.Increment();
			Map(x => x.Name);
		}
	}
}
