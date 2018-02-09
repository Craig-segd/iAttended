using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iAttended.Models;
using iAttended.Models.ViewModels;

namespace iAttended.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var result = new StudentViewModel()
            {
                Student = _context.Students.ToList()
            };

            return View(result);
        }

        public ActionResult Details(int id)
        {
            ViewData["id"] = id;

            var result = new StudentViewModel()
            {
                Student = _context.Students.Where(c => c.Id == id).Include(c => c.Course).ToList(),
                Courses = _context.Courses.ToList()
            };

            return View(result);
        }
    }
}