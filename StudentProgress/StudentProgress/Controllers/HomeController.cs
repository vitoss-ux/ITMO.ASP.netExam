using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentProgress.Models;

namespace StudentProgress.Controllers
{
    public class HomeController : Controller
    {
        private StudentContext db = new StudentContext();

        public ActionResult Index()
        {
            GiveStudents();
            return View();
        }

        private void GiveStudents()
        {
            var allStudents = db.Students.ToList<Student>();
            ViewBag.Students = allStudents;
        }

        [HttpGet]
        public ActionResult CreateStud()
        {
            GiveStudents();
            var allStudents = db.Students.ToList<Student>();
            ViewBag.Students = allStudents;
            return View();
        }

        [HttpPost]
        public string CreateStud(Student newStudent)
        {
            db.Students.Add(newStudent);
            db.SaveChanges();
            return "Новый студент добавлен.";
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}