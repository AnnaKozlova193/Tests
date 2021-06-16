using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestForOski.Models;
using TestForOski.MyHelper;

namespace TestForOski.Controllers
{
    public class HomeController : Controller
    {
        TestContext db = new TestContext();

        public ActionResult Index()
        {
            return View();
        }

        public RedirectToRouteResult PageQuest1()
        {
            return RedirectToRoute(new { controller = "Question", action = "PageQuest1" });
        }

        [AllowAnonymous]
        public ActionResult TestForAll()
        {
            IEnumerable<Question> questions = db.Questions;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Questions = questions;

            CheckBoxModel boxModel = new CheckBoxModel();
            return View(boxModel);

        }
        [HttpPost]
        public ActionResult TestForAll(CheckBoxModel boxModel)
        {
            bool value = boxModel.Status;
            ViewBag.Status = value;
            return View();

        }


        [Authorize]
        public ActionResult TestForAuthorizeUsers()
        {
            ViewBag.Message = "Тесты только для зарегестрированных пользователей";

            return View();
        }
    }
}
