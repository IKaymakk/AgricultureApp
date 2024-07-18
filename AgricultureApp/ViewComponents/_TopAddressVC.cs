using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.ViewComponents
{
    public class _TopAddressVC : ViewComponent
    {
        private readonly IAddressService _iservice;

        public _TopAddressVC(IAddressService iservice)
        {
            _iservice = iservice;
        }

        public IViewComponentResult Invoke()
        {
            var values = _iservice.GetListAll();
            return View(values);
        }
    }
}
