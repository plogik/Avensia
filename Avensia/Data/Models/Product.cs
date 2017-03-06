namespace Avensia.Data.Models
{
	public class Product
	{
		public virtual string Id { get; set; }
		public virtual string Name { get; set; }
		public virtual string Description { get; set; }
		public virtual ProductCategory Category { get; set; }
        public virtual int QuantityMin { get; set; } = 1;
        public virtual int QuantityMax { get; set; } = int.MaxValue;
        public virtual decimal PriceNow { get; set; }
        public virtual decimal Price { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Id:{0}, Name:{1}, Description:{2}, Category:{3}, Min:{4}, Max:{5}, Price:{6}",
                Id, Name, Description, Category.Name, QuantityMin, QuantityMax, Price);
        }

        public override bool Equals(object obj)
        {
            return obj is Product &&
                ((Product)obj).Id.Equals(Id);
        }

        public override int GetHashCode()
        {
            var hash = 17;
            hash *= 31 + Id != null ? Id.GetHashCode() : 0;
            return hash;
        }
    }
}
