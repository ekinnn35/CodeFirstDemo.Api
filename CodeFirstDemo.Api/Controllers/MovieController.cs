using CodeFirstDemo.Api.Data;
using CodeFirstDemo.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstDemo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly PatikaFirstDbContext _context;

        public MovieController(PatikaFirstDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetMovies()
        {
            var movies = _context.Movies.ToList();
            return Ok(movies);
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return Ok(movie);
        }
    }
}
