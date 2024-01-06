namespace Basket.Data.Entity
{
    public class Order : BaseEntity
    {
        public decimal Income { get; set; }
        public DateTime SaleDate { get; set; }

        //public int UserId { get; set; }
        //public User? User { get; set; }

        public int CartId { get; set; }
        public virtual Cart? Cart { get; set; }
    }
}
