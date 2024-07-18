using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.ViewComponents
{
    public class _DashboardNavbarVC : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
