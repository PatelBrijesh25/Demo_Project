using Learing_core.Data;
using Microsoft.AspNetCore.Mvc;
using Learing_core.Models;
using System.Threading.Tasks;
using Microsoft.Build.Framework;


namespace Learing_core.Controllers
{
    public class TasksController : Controller
    {
        private ApplicationDbContext _context;
        public TasksController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            IEnumerable<Models.Task> tasks = _context.Tasks;
            var test = tasks.ToList();
            return View(tasks);
        }
        [HttpPost]
        public IActionResult Index(string action, Models.Task task)
        {

            switch (action)
            {
                case "insert":
                    return Insert(task);
                   
                case "update":
                   
                    break;
                case "delete":
                    
                    break;
               
                default:
                   
                    break;
            }

            
            return View();

        }
        [HttpPost]
        public IActionResult Insert(Models.Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges(); 
            return RedirectToAction("Index");
           
        }
    }
}