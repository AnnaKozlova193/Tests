using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestForOski.Models;
using TestForOski.MyHelper;

namespace TestForOski.Controllers
{
    public class QuestionController : Controller
    {
        TestContext db = new TestContext();
        // out , ref  - НЕТ!!! ((( ???         - вот тут и разбились все мечты ЧТО ДЕЛАТЬ ?
        List<bool> point = new List<bool>();

        // GET: Question
        public ActionResult PageQuest1()
        {
            IEnumerable<Question> questions = db.Questions;
            ViewBag.Questions = questions;

            CheckBoxModel boxModel = new CheckBoxModel();
            return View(boxModel);
           
        }
        [HttpPost]
        public ActionResult PageQuest1(CheckBoxModel boxModel)
        {
            bool value = boxModel.Status;
            ViewBag.Status = value;
            if (value == true)
            {
                point.Add(true);
            }
         
            IEnumerable<Question> questions = db.Questions;
            ViewBag.Questions = questions;
            return View();

        }

        public ActionResult PageQuest2()
        {
           
            IEnumerable<Question> questions = db.Questions;
            ViewBag.Questions = questions;

            CheckBoxModel boxModel = new CheckBoxModel();
            return View(boxModel);
            
        }

        [HttpPost]
        public ActionResult PageQuest2(CheckBoxModel boxModel)
        {
            bool value = boxModel.Status;
            ViewBag.Status = value;

            if (value == true)
            {
                point.Add(true);
            }

            IEnumerable<Question> questions = db.Questions;
            ViewBag.Questions = questions;
            return View();

        }

        public ActionResult PageQuest3()
        {
          
            IEnumerable<Question> questions = db.Questions;
            ViewBag.Questions = questions;

            CheckBoxModel boxModel = new CheckBoxModel();
            return View(boxModel);
            
        }

        [HttpPost]
        public ActionResult PageQuest3(CheckBoxModel boxModel)
        {
            bool value = boxModel.Status;
            ViewBag.Status = value;

            if (value == true)
            {
                point.Add(true);

            }
            ViewBag.Count = point.Count();
            IEnumerable<Question> questions = db.Questions;
            ViewBag.Questions = questions;
            return View();

        }

        public RedirectToRouteResult Index()
        {
            ViewBag.Count = point.Count();
            return RedirectToRoute(new { controller = "Home", action = "Index"});
           
        }
    }
}
