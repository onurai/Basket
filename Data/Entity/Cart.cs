namespace Basket.Data.Entity
{
    public class Cart : BaseEntity
    {
        public virtual ICollection<BasketItem>? BasketItems { get; set; }

        public int UserId { get; set; }
        public virtual User? User { get; set; }  // one-to-one / dependent side 


        public virtual Order? Order { get; set; }
    }
}
