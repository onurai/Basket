namespace Basket.Data.Entity
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual Cart? Cart { get; set; } // one-to-one - independent side 

        //public virtual ICollection<Order>? Orders { get; set; }
    }
}
