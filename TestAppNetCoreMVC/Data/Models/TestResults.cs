using Microsoft.AspNetCore.Identity;

namespace TestAppNetCoreMVC.Data.Models
{
    public class TestResults
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public Tests Test { get; set; }
        public IdentityUser User { get; set; }
    }
}
