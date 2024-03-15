using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.ViewComponents.CustomerDashboard
{
    public class _CustomerLayoutNavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
