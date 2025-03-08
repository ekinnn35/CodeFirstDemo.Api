using CodeFirstDemo.Api.Data;
using CodeFirstDemo.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstDemo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly PatikaFirstDbContext _context;

        public GameController(PatikaFirstDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetGames()
        {
            var games = _context.Games.ToList();
            return Ok(games);
        }

        [HttpPost]
        public IActionResult AddGame(Game game)
        {
            _context.Games.Add(game);
            _context.SaveChanges();
            return Ok(game);
        }
    }
}
