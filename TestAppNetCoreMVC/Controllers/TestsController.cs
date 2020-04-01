using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestAppNetCoreMVC.Data;
using TestAppNetCoreMVC.Data.Models;
using TestAppNetCoreMVC.DTO;
using TestAppNetCoreMVC.Models;

namespace TestAppNetCoreMVC.Controllers
{
    public class TestsController : Controller
    {
        private readonly ILogger<TestsController> _logger;
        private ApplicationDbContext _db;

        public TestsController(ILogger<TestsController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Tests);
        }

        [HttpGet]
        public IActionResult ConfirmationPage(int testId)
        {

            return View(testId);
        }

        
        public IActionResult ConcreteTest(int testid)
        {

            var Questions = _db.TestQuestions.Where(w => w.Test.Id == testid).Select(s => new QuestionsDto
            {
                Id = s.Id,
                Question = s.Question,
                Answeres = _db.TestAnsweres.Where(we => we.TestQuestion.Id == s.Id).Select(sel => sel).ToList()
            }).ToList();

            Evaluation ev = new Evaluation();
            ev.Questions = Questions;
            ev.TestId = testid;
            return View(ev);
        }

        [HttpPost]
        public ActionResult SaveResults(Evaluation model)
        {
            //ToDO: Saving to Db
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
