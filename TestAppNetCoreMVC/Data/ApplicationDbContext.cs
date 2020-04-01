using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestAppNetCoreMVC.Data.Models;
using TestAppNetCoreMVC.Data.Configurations;

namespace TestAppNetCoreMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Tests> Tests { get; set; }
        public DbSet<TestAnsweres> TestAnsweres { get; set; }
        public DbSet<TestQuestions> TestQuestions { get; set; }
        public DbSet<TestResults> TestResults { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new TestsConfiguraion());
            builder.ApplyConfiguration(new TestQuestionsConfiguraion());
            builder.ApplyConfiguration(new TestAnsweresConfiguraion());
            builder.ApplyConfiguration(new TestResultsConfiguraion());
        }
    }
}
