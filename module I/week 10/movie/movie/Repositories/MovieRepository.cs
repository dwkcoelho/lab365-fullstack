using movie.Context;
using movie.Models;
using movie.Repositories.Interface;

namespace movie.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContext _context;

        public MovieController(MovieContext context)
        {
            _context = context;
        }
        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);   
        }
    }
}
