using Microsoft.AspNetCore.Mvc;

namespace ToDoListTwo.Controllers
{
    public class TaskManager : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
