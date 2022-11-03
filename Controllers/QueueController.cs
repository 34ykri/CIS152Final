using Microsoft.AspNetCore.Mvc;
using DataStructuresFinalProjectWebAppVang.Models;

namespace DataStructuresFinalProjectWebAppVang.Controllers
{
    public class QueueController : Controller
    {
        PriorityQueue<Character, int> priorityQueue = new PriorityQueue<Character, int>();
        public IActionResult Index()
        {
            var model = priorityQueue;
            return View(model);
        }
        public IActionResult Add()
        {
            var character = new Character();

            return View(character);
        }
        [HttpPost]
        public IActionResult Add(Character character, int priority)
        {
            priorityQueue.Enqueue(character,priority);

            return RedirectToAction("Index");
        }
    }
}
