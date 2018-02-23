using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SqlServer.Models;
using SqlServer.Data;

namespace SqlServer.Controllers
{
    public class StudentController : Controller
    {
        TestDbContext _context;

        public StudentController(TestDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IList<Student> students = _context.Students.ToList();

            return Json(students);
        }

        public IActionResult Create()
        {
            Student student = new Student()
            {
                LastName = "Acosta",
                FirstMidName = "Nelson"
            };

            _context.Students.Add(student);
            _context.SaveChanges();

            return Json(new { result = "Ok" });
        }
    }
}
