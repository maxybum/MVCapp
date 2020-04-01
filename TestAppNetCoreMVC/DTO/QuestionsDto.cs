using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAppNetCoreMVC.Data.Models;

namespace TestAppNetCoreMVC.DTO
{
    public class Evaluation
    {
        public int TestId { get; set; }
        public List<QuestionsDto> Questions { get; set; }

        public Evaluation()
        {
            Questions = new List<QuestionsDto>();
        }
    }

    public class QuestionsDto
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public int SelectedAnswer { get; set; }
        public List<TestAnsweres> Answeres { get; set; }

        public QuestionsDto()
        {
            Answeres = new List<TestAnsweres>();
        }
    }
}
