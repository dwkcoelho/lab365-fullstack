using Microsoft.AspNetCore.Mvc;
using movie.Context;
using movie.Dto;
using movie.Models;
using movie.Validator;

namespace movie.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly MovieContext MovieRepository;

        public MovieController(MovieContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var movies = _context.Movies.ToList();
            return Ok(movies);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetId(int id)
        {
            var movie = _context.Movies.FirstOrDefault(x => x.Id.Equals(id));

            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }
        [HttpPost]
        public IActionResult Create([FromBody] MovieDto movieDto)
        {
            var movie = new Movie();

            MovieDtoValidator movieDtoValidator = new();
            var validatorResult = movieDtoValidator.Validate(movieDto);

            if (!validatorResult.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            _context.Movies.Add(movie);
            _context.SaveChanges(); 

            return CreatedAtAction(nameof(MovieController.Get), new { id = movie.Id }, movieDto);
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] MovieDto movieDto)
        {
            var movie = _context.Movies.FirstOrDefault(x => x.Id.Equals(id));

            if (movie == null)
            {
                return NotFound();
            }
            movie.Title = movieDto.Title;
            movie.Gender = movieDto.Gender;

            _context.Movies.Update(movie);
            _context.SaveChanges();

            return CreatedAtAction(nameof(MovieController.Get), new { id = movie.Id }, movie);
        }

    }
}
