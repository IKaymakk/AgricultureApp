using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.ViewComponents
{
    public class _NavbarVC : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
