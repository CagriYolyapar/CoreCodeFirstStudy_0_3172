namespace CoreBilgeAdamStudy_0.Models.Entities
{
    public class OrderDetail : BaseEntity
    {
        public int OrderID { get; set; }
        public int PackageID { get; set; }

        //Relational Properties
        public virtual Order Order { get; set; }
        public virtual LessonPackage Package { get; set; }

    }
}
