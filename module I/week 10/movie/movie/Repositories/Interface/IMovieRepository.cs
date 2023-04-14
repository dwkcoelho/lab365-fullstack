using Microsoft.EntityFrameworkCore;
using movie.Context;
using movie.Models;

namespace movie.Repositories.Interface
{

    public interface IMovieRepository
    {

        void Add(Movie movie);
    }
}
