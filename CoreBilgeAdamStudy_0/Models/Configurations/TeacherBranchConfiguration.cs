using CoreBilgeAdamStudy_0.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreBilgeAdamStudy_0.Models.Configurations
{
    public class TeacherBranchConfiguration : BaseConfiguration<TeacherBranch>
    {
        public override void Configure(EntityTypeBuilder<TeacherBranch> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new
            {
                x.TeacherID,
                x.BranchID
            });
        }
    }
}
