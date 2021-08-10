using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetStudents()
        {
            var Students = new List<Student> { 
            
            new Student()
            {
                ID = 1,
                Name = "Maaz",
                Address ="Karachi"
            },
             new Student()
            {
                ID = 2,
                Name = "Ali",
                Address ="Hyderabad"
            },
              new Student()
            {
                ID = 3,
                Name = "hamid",
                Address ="Quetta"
            }



            };
            return View(Students);
        }
        public ActionResult GetStudentsCustomView()
        {
            var student = new Student()
            {
                ID = 1,
                Name = "Maaz",
                Address = "Karachi"
            };
            var subjects = new List<Subjects>()
            {
                new Subjects()
                {
                    Id = 1,Name = "COmputer Programming"

                },
                 new Subjects()
                 { Id = 2, Name = "Database"},

                  new Subjects()
                 {
                   Id = 3, Name = "Algorithm analysis"
                  }
            };

            var viewModel = new StudentViewModel()
            {
                Student = student,
                Subjects = subjects

            };
            return View(viewModel);
        }
        public ActionResult SingleStudent()
        {
            return View();
        }
        public ActionResult EditStudent(int id)
        {
            return Content("Student id "+ id);
        }

        [Route("student/passingyear/{month:int:range(1,12)}/{year:min(1990)}")]
        public ActionResult ByPassingYear(int month, int year)
        {
            return Content("Month: " + month + " Year: " + year);
        }

    }
}