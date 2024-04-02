using Microsoft.AspNetCore.Mvc;
using ReadyPlayerOne.Models;

namespace ReadyPlayerOne.Controllers
{
    public class PlayerController : Controller
    {
        private PlayerContext context { get; set; }

        public PlayerController(PlayerContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Player());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var player = context.Players.Find(id);
            return View(player);
        }
        [HttpPost]
        public IActionResult Edit(Player player)
        {
            if (ModelState.IsValid)
            {
                if (player.PlayerId == 0)
                    context.Players.Add(player);
                else
                    context.Players.Update(player);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action =
                    (player.PlayerId == 0) ? "Add" : "Edit";
                return View(player);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var player = context.Players.Find(id);
            return View(player);
        }
        [HttpPost]
        public IActionResult Delete(Player player)
        {
            context.Players.Remove(player);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        // GET: /Player/Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Action = "Create";
            return View("Edit", new Player());
        }

        // POST: /Player/Create
        [HttpPost]
        public IActionResult Create(Player player)
        {
            if (ModelState.IsValid)
            {
                context.Players.Add(player);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Action = "Create";
            return View("Edit", player);
        }
    }
}

