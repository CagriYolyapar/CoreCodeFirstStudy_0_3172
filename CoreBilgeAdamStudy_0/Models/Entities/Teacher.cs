namespace CoreBilgeAdamStudy_0.Models.Entities
{
    public class Teacher : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties
        public virtual ICollection<TeacherBranch> TeacherBranches { get; set; }
        public virtual ICollection<LessonPackage> LessonPackages { get; set; }


    }
}
