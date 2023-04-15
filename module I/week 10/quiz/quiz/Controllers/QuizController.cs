using Microsoft.AspNetCore.Mvc;
using quiz.Context;

namespace quiz.Controllers
{
    public class QuizController : ControllerBase
    {
        public readonly QuizContext _context;

        public QuizController(QuizContext context)
        {
            _context = context;
        }
    }
}
