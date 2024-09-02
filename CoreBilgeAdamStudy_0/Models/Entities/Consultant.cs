namespace CoreBilgeAdamStudy_0.Models.Entities
{
    public class Consultant : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties
        public virtual ICollection<Student> Students { get; set; }

    }
}
