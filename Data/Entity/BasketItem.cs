namespace Basket.Data.Entity
{
    public class BasketItem : BaseEntity
    {
        public int Quantity { get; set; }

        public int ProductId { get; set; }
        public int CartId { get; set; }

        public Product? Product { get; set; }    
        public Cart? Cart { get; set; }
    }
}
