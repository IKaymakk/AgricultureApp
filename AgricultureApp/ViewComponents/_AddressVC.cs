using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.ViewComponents
{
    public class _AddressVC : ViewComponent
    {
        private readonly IAddressService _address;

        public _AddressVC(IAddressService address)
        {
            _address = address;
        }

        public IViewComponentResult Invoke()
        {
            var values = _address.GetListAll();
            return View(values);
        }
    }
}
