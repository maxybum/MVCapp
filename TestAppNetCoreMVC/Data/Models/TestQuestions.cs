namespace TestAppNetCoreMVC.Data.Models
{
    public class TestQuestions
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public Tests Test { get; set; }
    }
}
