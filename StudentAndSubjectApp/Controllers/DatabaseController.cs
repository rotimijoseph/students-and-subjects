using Microsoft.AspNetCore.Mvc;

namespace StudentAndSubjectApp.Controllers
{
    public class DatabaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

