namespace CoreBilgeAdamStudy_0.Models.Entities
{
    public class Branch : BaseEntity
    {
        public string Name { get; set; }

        //Relational Properties
        public virtual ICollection<TeacherBranch> TeacherBranches { get; set; }

    }
}
