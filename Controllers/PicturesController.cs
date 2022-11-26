using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class Pictures : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
