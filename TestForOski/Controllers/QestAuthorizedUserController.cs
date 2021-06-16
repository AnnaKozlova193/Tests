using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestForOski.Models;
using TestForOski.MyHelper;

namespace TestForOski.Controllers
{
    public class QestAuthorizedUserController : Controller
    {
        TestContext db = new TestContext();

        public RedirectToRouteResult PageQuest()
        {
            return RedirectToRoute(new { controller = "Question", action = "PageQuest1" });
        }
   
        // GET: Question

        public ActionResult PageQuest1()
        {
            IEnumerable<Question> questions = db.Questions;
            ViewBag.Questions = questions;
            return View();

        }
        [HttpPost]
        public ActionResult PageQuest1(CheckBoxModel boxModel)
        {
            bool value = boxModel.Status;
            ViewBag.Status = value;

            if (value == true)
            {
              
            }
            IEnumerable<Question> questions = db.Questions;
            ViewBag.Questions = questions;
            return View();

        }

        public ActionResult PageQuest2()
        {
            IEnumerable<Question> questions = db.Questions;
            ViewBag.Questions = questions;
            return View();
        }
        [HttpPost]
        public ActionResult PageQuest2(CheckBoxModel boxModel)
        {
            bool value = boxModel.Status;
            ViewBag.Status = value;

            if (value == true)
            {

            }
            IEnumerable<Question> questions = db.Questions;
            ViewBag.Questions = questions;
            return View();

        }
        public ActionResult PageQuest3()
        {
            IEnumerable<Question> questions = db.Questions;
            ViewBag.Questions = questions;
            return View();
        }
        [HttpPost]
        public ActionResult PageQuest3(CheckBoxModel boxModel)
        {
            bool value = boxModel.Status;
            ViewBag.Status = value;

            if (value == true)
            {

            }
            IEnumerable<Question> questions = db.Questions;
            ViewBag.Questions = questions;
            return View();

        }
        public ActionResult PageQuest4()
        {
            IEnumerable<Question> questions = db.Questions;
            ViewBag.Questions = questions;
            return View();

        }
        [HttpPost]
        public ActionResult PageQuest4(CheckBoxModel boxModel)
        {
            bool value = boxModel.Status;
            ViewBag.Status = value;

            if (value == true)
            {

            }
            IEnumerable<Question> questions = db.Questions;
            ViewBag.Questions = questions;
            return View();

        }
        public ActionResult PageQuest5()
        {
            IEnumerable<Question> questions = db.Questions;
            ViewBag.Questions = questions;
            return View();
        }
        [HttpPost]
        public ActionResult PageQuest5(CheckBoxModel boxModel)
        {
            bool value = boxModel.Status;
            ViewBag.Status = value;

            if (value == true)
            {

            }
            IEnumerable<Question> questions = db.Questions;
            ViewBag.Questions = questions;
            return View();

        }
        public ActionResult PageQuest6()
        {
            IEnumerable<Question> questions = db.Questions;
            ViewBag.Questions = questions;
            return View();
        }
        [HttpPost]
        public ActionResult PageQuest6(CheckBoxModel boxModel)
        {
            bool value = boxModel.Status;
            ViewBag.Status = value;

            if (value == true)
            {

            }
            IEnumerable<Question> questions = db.Questions;
            ViewBag.Questions = questions;
            return View();

        }
        [HttpPost]
        public ActionResult PageQuest(CheckBoxModel boxModel)
        {
            bool value = boxModel.Status;
            ViewBag.Status = value;

            if (value == true)
            {

            }
     
            return View();

        }
        
    }
}