using AgricultureApp.Models;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<ContactModel> MessageList()
        {
            List<ContactModel> contactModels = new List<ContactModel>();
            using (var context = new AgricultureContext())
            {
                contactModels = context.Contacts.Select(x => new ContactModel
                {
                    ContactID = x.ContactID,
                    Date = x.Date,
                    Mail = x.Mail,
                    Message = x.Message
                }).ToList();
            }
            return contactModels;
        }
        public IActionResult MessageReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Mesaj Listesi");
                workSheet.Cell(1, 1).Value = "Mesaj ID";
                workSheet.Cell(1, 2).Value = "Mesaj Tarihi";
                workSheet.Cell(1, 3).Value = "Gönderen Mail Adresi";
                workSheet.Cell(1, 4).Value = "Mesaj İçeriği";

                int contactRowCount = 2;
                foreach (var x in MessageList())
                {
                    workSheet.Cell(contactRowCount, 1).Value = x.ContactID;
                    workSheet.Cell(contactRowCount, 2).Value = x.Date;
                    workSheet.Cell(contactRowCount, 3).Value = x.Mail;
                    workSheet.Cell(contactRowCount, 4).Value = x.Message;
                    contactRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Mesaj_Raporu.xlsx");
                }
            }
        }
    }
}
