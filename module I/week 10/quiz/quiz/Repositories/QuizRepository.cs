using Microsoft.AspNetCore.Mvc;
using quiz.Context;
using quiz.Controllers;

namespace quiz.Repositories
{
    public class QuizRepository 
    {
        private readonly QuizContext _context;

        public QuizRepository(QuizContext context)
        {
            _context = context;
        }

    
    }
}
