using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.ViewComponents
{
    public class _DashboardScriptVC : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
