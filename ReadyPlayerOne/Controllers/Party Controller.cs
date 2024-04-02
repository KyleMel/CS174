//A rough Draft from ChatGPT conversation
//Looks like a Party Class may be good.

using Microsoft.AspNetCore.Mvc;
using ReadyPlayerOne.Models;
using System.IO;

namespace ReadyPlayerOne.Controllers
{
    public class PartyController : Controller
    {
        private readonly PlayerContext _context;

        public PartyController(PlayerContext context)
        {
            _context = context;
        }

        // GET: /Party/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Party/Create
        [HttpPost]
        public IActionResult Create(Party party)
        {
            if (ModelState.IsValid)
            {
                // Add party to database
                _context.Parties.Add(party);
                _context.SaveChanges();
                return RedirectToAction("Index", "Party");
            }
            // If ModelState is invalid, return to the Create view with the same model
            return View(party);
        }
    }
}
