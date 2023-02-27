using Microsoft.AspNetCore.Mvc;
using StackOverflow.Data;
using StackOverflow.Models;

namespace StackOverflow.Controllers
{
    public class CommentsController : Controller
    {
        private readonly StackOverflowContext _context;

        public CommentsController(StackOverflowContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCommentToQuestion(int? QuestionId)
        {
            return View(QuestionId);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description")] QuestionComments comment, int QuestionId)
        {
            if (ModelState.IsValid)
            {
                comment.QuestionId = QuestionId;
                _context.Add(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comment);
        }
    }
}
