using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestAppNetCoreMVC.Data.Models;

namespace TestAppNetCoreMVC.Data.Configurations
{
    public class TestResultsConfiguraion : IEntityTypeConfiguration<TestResults>
    {
        public void Configure(EntityTypeBuilder<TestResults> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
