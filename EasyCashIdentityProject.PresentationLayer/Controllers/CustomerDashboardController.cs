using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    public class CustomerDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
