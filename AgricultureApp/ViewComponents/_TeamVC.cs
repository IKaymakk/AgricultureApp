using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.ViewComponents
{
    public class _TeamVC : ViewComponent
    {
        private readonly ITeamDal _teamdal;

        public _TeamVC(ITeamDal teamdal)
        {
            _teamdal = teamdal;
        }

        public IViewComponentResult Invoke()
        {
            var values = _teamdal.GetListAll();
            return View(values);
        }
    }
}
