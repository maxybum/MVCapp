using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestAppNetCoreMVC.Data.Models;

namespace TestAppNetCoreMVC.Data.Configurations
{
    public class TestAnsweresConfiguraion : IEntityTypeConfiguration<TestAnsweres>
    {
        public void Configure(EntityTypeBuilder<TestAnsweres> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
