using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.ViewComponents
{
    public class _ServiceVC : ViewComponent
    {
        private readonly IServiceDal _servicedal;

        public _ServiceVC(IServiceDal servicedal)
        {
            _servicedal = servicedal;
        }

        public IViewComponentResult Invoke()
        {
            var values = _servicedal.GetListAll();
            return View(values);
        }
    }
}
