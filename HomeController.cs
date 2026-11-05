using Microsoft.AspNetCore.Mvc;
using BoardGameStore.Repositories;

namespace BoardGameStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBoardGameRepository _repository;

        public HomeController(IBoardGameRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var games = _repository.GetAllGames();
            return View(games); 
        }
    }
}
