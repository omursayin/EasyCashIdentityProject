using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.ViewComponents.CustomerDashboard
{
    public class _CustomerLayoutScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
