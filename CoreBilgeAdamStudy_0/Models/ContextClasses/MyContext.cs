using CoreBilgeAdamStudy_0.Models.Configurations;
using CoreBilgeAdamStudy_0.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreBilgeAdamStudy_0.Models.ContextClasses
{
    public class MyContext : DbContext
    {

        public MyContext(DbContextOptions<MyContext> opt): base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new LabConfiguration());
            modelBuilder.ApplyConfiguration(new PackageConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherBranchConfiguration());
            modelBuilder.ApplyConfiguration(new ConsultantConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new BranchConfiguration());
          
        }

        public DbSet<Lab> Labs { get; set; }
        public DbSet<LessonPackage> Packages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherBranch> TeacherBranches { get; set; }
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Branch> Branches { get; set; }


    }
}
