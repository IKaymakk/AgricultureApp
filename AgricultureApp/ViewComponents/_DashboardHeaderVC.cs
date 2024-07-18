using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.ViewComponents
{
    public class _DashboardHeaderVC:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
