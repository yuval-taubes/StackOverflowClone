using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StackOverflow.Data;
using StackOverflow.Models;
using StackOverflow.Models.ViewModel;

namespace StackOverflow.Controllers
{
    public class CommentsController : Controller
    {
        private readonly StackOverflowContext _context;

        public CommentsController(StackOverflowContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.QuestionComments.ToListAsync());
        }

        public IActionResult AddCommentToQuestion(int? QuestionId)
        {
            return View(QuestionId);
        }

        [HttpPost]
        public IActionResult AddCommentToQuestion(QuestionCommentViewModel vm)
        {
            QuestionComments comment = new QuestionComments();
            comment.QuestionId = vm.QuestionId;
            comment.Description = vm.Description;
            _context.Add(comment);
            _context.SaveChanges();

            return Redirect($"/Questions/Details/{vm.QuestionId}");
        }
    }
}
