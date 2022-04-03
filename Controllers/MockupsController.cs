using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class MockupsController : Controller
    {
        private static QuizCollection quizCol = new();

        public IActionResult Index() => View();

        public IActionResult Quiz(string Action) 
         {
            if (Action == "Quiz")            
                quizCol.Clear();

            ViewData["Title"] = "Hello Quiz";
            ViewData["QuizResult"] = "Quiz";
            

            if (Action != "Finish")
            {
                var quizEl = new Quiz();
                quizCol.questionsCount++;
                quizCol.quiz.Add(quizEl);

                if (Request.Method == "POST")
                {
                    _ = int.TryParse(HttpContext.Request.Form["resAns"], out int resAns);
                    quizCol.answers.Add(resAns);
                }

                return View(quizEl);
            }
            else
            {
                _ = int.TryParse(HttpContext.Request.Form["resAns"], out int resAns);
                quizCol.answers.Add(resAns);
                quizCol.CountRightAnswers();
                ViewData["QuizResult"] = "Quiz results";
                return View(quizCol);
            }
         }
        public IActionResult QuizResult()
        {
            ViewData["Title"] = "Hello Quiz";
            return View(quizCol);
        }        
    }
}