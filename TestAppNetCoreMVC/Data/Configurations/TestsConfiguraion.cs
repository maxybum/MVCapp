using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestAppNetCoreMVC.Data.Models;

namespace TestAppNetCoreMVC.Data.Configurations
{
    public class TestsConfiguraion : IEntityTypeConfiguration<Tests>
    {
        public void Configure(EntityTypeBuilder<Tests> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
