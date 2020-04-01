namespace TestAppNetCoreMVC.Data.Models
{
    public class TestAnsweres
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public bool IsRight { get; set; }
        public TestQuestions TestQuestion { get; set; }
    }
}
