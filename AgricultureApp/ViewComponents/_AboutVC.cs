using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.ViewComponents
{
    public class _AboutVC:ViewComponent
    {
        private readonly IAboutService _aboutservice;

        public _AboutVC(IAboutService aboutservice)
        {
            _aboutservice = aboutservice;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutservice.GetListAll();
            return View(values);
        }
    }
}
