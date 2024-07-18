using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.ViewComponents
{
	public class _HeadVC : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
