using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.ViewComponents
{
    public class _DashboardTableVC : ViewComponent
    {
        private readonly IContactService _service;

        public _DashboardTableVC(IContactService service)
        {
            _service = service;
        }

        public IViewComponentResult Invoke()
        {
            var values = _service.GetListAll().OrderByDescending(x => x.Date).Take(1);
            return View(values);
        }
    }
}
