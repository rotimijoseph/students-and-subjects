using Microsoft.AspNetCore.Mvc;

namespace StudentAndSubjectApp.Controllers
{
    public class NewAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AccountCreated()
        {
            return View();
        }
    }
}

