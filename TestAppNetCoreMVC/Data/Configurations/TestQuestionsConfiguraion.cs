using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestAppNetCoreMVC.Data.Models;

namespace TestAppNetCoreMVC.Data.Configurations
{
    public class TestQuestionsConfiguraion : IEntityTypeConfiguration<TestQuestions>
    {
        public void Configure(EntityTypeBuilder<TestQuestions> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
