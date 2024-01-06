namespace Basket.Data.Entity
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int Stock { get; set; }

        //
        public virtual ICollection<BasketItem>? BasketItems { get; set; }
    }
}
