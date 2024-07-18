using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.ViewComponents
{
    public class _DashboardOverviewVC : ViewComponent
    {
        AgricultureContext c = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.teamCount = c.Teams.Count();
            ViewBag.serviceCount = c.Services.Count();
            ViewBag.messageCount = c.Contacts.Count();
            ViewBag.messageCount = c.Contacts.Count();
            ViewBag.currentMonthMessage = c.Contacts.Where(x => x.Date.Month == DateTime.Now.Month).Count();

            ViewBag.announcementTrue = c.Announcements.Where(x => x.Status == true).Count();
            ViewBag.announcementFalse = c.Announcements.Where(x => x.Status == false).Count();

            ViewBag.mudur = c.Teams.Where(x => x.Title == "Müdür").Select(x => x.PersonName).FirstOrDefault();
            ViewBag.yardimci = c.Teams.Where(x => x.Title == "Müdür Yardımcısı").Select(x => x.PersonName).FirstOrDefault();
            ViewBag.uzman = c.Teams.Where(x => x.Title == "Dış Saha Satış Uzmanı").Select(x => x.PersonName).FirstOrDefault();
            ViewBag.tedarik = c.Teams.Where(x => x.Title == "Tedarikçi").Select(x => x.PersonName).FirstOrDefault();
            ViewBag.analist = c.Teams.Where(x => x.Title == "Bölge Analisti").Select(x => x.PersonName).FirstOrDefault();
            return View();
        }
    }
}
