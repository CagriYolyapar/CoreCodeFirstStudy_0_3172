namespace CoreBilgeAdamStudy_0.Models.Entities
{
    public class LessonPackage : BaseEntity
    {
        public string PackageDuration { get; set; }
        public string Description { get; set; }
        public decimal PackagePrice { get; set; }
        public int? TeacherID { get; set; }
        public int? LabID { get; set; }


        //Relational Properties
        public virtual Teacher Teacher { get; set; }
        public virtual Lab Lab { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }



    }
}









