namespace CoreBilgeAdamStudy_0.Models.Entities
{
    public class TeacherBranch : BaseEntity
    {
        public int TeacherID { get; set; }
        public int BranchID { get; set; }

        //Relational Properties
        public virtual Teacher Teacher { get; set; }
        public virtual Branch Branch { get; set; }

    }
}
