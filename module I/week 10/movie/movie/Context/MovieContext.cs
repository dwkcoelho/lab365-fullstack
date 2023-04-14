using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using movie.Models;

namespace movie.Context
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) 
        {
        
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
