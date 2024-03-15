using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.ViewComponents.CustomerDashboard
{
    public class _CustomerLayoutFooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
