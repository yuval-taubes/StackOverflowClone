using Microsoft.AspNetCore.Mvc;
using StackOverflow.Data;
using StackOverflow.Models.ViewModel;
using StackOverflow.Models;

namespace StackOverflow.Controllers
{
    public class AnswersController : Controller
    {
        private readonly StackOverflowContext _context;

        public AnswersController(StackOverflowContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Answers.ToList());
        }

        public IActionResult AddAnswerToQuestion(int? QuestionId)
        {
            return View(QuestionId);
        }

        [HttpPost]
        public IActionResult AddAnswerToQuestion(AnswerViewModel vm)
        {
            Answer answer = new Answer();
            answer.QuestionId = vm.QuestionId;
            answer.Title = vm.Title;
            answer.Description = vm.Description;
            answer.PostDate = DateTime.Now;
            
            _context.Answers.Add(answer);
            _context.SaveChanges();

            return Redirect($"/Questions/Details/{vm.QuestionId}");
        }
    }
}
