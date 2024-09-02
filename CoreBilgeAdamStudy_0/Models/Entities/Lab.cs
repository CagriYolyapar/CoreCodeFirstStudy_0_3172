namespace CoreBilgeAdamStudy_0.Models.Entities
{
    public class Lab : BaseEntity
    {
        public string No { get; set; }

        //Relational Properties
        public virtual ICollection<LessonPackage> LessonPackages { get; set; }

    }
}
