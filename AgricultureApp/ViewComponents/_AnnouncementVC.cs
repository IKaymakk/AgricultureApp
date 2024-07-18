using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.ViewComponents
{
    public class _AnnouncementVC : ViewComponent
    {
        private readonly IAnnouncementService _dal;

        public _AnnouncementVC(IAnnouncementService dal)
        {
            _dal = dal;
        }

        public IViewComponentResult Invoke()
        {
            var values = _dal.GetListAll().OrderByDescending(x => x.Date).Take(3);
            return View(values);
        }
    }
}
