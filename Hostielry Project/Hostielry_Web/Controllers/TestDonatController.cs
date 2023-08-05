using Microsoft.AspNetCore.Mvc;

namespace HostelryWeb.Controllers
{
    public class TestDonatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
