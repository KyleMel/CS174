using Microsoft.AspNetCore.Mvc;
using ReadyPlayerOne.Models;

namespace ReadyPlayerOne.Controllers
{
    public class HomeController : Controller
    {
        private PlayerContext context { get; set; }

        public HomeController(PlayerContext ctx) =>
            context = ctx;

        public IActionResult Index()
        {
            var players = context.Players.OrderBy(
                m => m.PlayerName).ToList();
            return View(players);
        }
    }
}