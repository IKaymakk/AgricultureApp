using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureApp.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamservice;

        public TeamController(ITeamService teamservice)
        {
            _teamservice = teamservice;
        }

        public IActionResult Index()
        {
            var values = _teamservice.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTeam(Team t)
        {
            TeamValidator tv = new TeamValidator();
            ValidationResult results = tv.Validate(t);
            if (results.IsValid)
            {
                _teamservice.Insert(t);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var x in results.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
                return View();
            }

        }
        public IActionResult DeleteTeam(int id)
        {
            var values = _teamservice.GetById(id);
            _teamservice.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditTeam(int id)
        {
            var values = _teamservice.GetById(id);
            ViewBag.ID = values.TeamID;
            return View(values);
        }
        [HttpPost]
        public IActionResult EditTeam(Team t)
        {
            TeamValidator tv = new TeamValidator();
            ValidationResult results = tv.Validate(t);
            if (results.IsValid)
            {
                _teamservice.Update(t);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var x in results.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
                return View();
            }
        }
    }
}
