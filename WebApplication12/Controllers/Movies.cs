using Microsoft.AspNetCore.Mvc;

namespace WebApplication12.Controllers
{
    public class Movies : Controller
    {
        public IActionResult Catalog()
        {
            return View();
        }
        public IActionResult Directors()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }
    }
}
