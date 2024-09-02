namespace CoreBilgeAdamStudy_0.Models.Entities
{
    public class Order : BaseEntity
    {
        public string PaymentType { get; set; }
        public int? StudentID { get; set; }


        //Relational Properties
        public virtual Student Student { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }


    }
}
