using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        private static readonly log4net.ILog log =log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
       
        
        // GET: Home
        public ActionResult Index()
        {
            try {

            log.Info("the Index try block started");
            ViewBag.FirstName = "Maaz";
            ViewBag.LastName = "Munawer";
            ViewBag.Address = "Maymar karachi";
                int x, y, z;
                x = 5; y = 0;
                z = x / y;

                log.Info("the Index try block ended");
            }
            catch(Exception ex)
            {
                log.Info("your application has an exception");
                log.Error(ex.Message);
            }
      
                return View();
            
        }

        public ActionResult GetEmployee()
        {
            try {
                log.Info("the GetEmployee try block started");

                List<Employee> employees = new List<Employee>()
            {
                new Employee()
            {
                    
                EmployeeID = 1,
                EmployeeName = "Maaz",
                Address = "maymar karachi",
                DateOfJoining = System.DateTime.Now,
                MartialStatus = 1,
                IsEligibleForLoad = true,
                Salary = 10000.00m,
                CreatedBy = "intern",
                CreatedDate = System.DateTime.Now

            },

                new Employee()
            {
                EmployeeID = 2,
                EmployeeName = "Ali",
                Address = "maymar karachi",
                DateOfJoining = System.DateTime.Now,
                MartialStatus = 1,
                IsEligibleForLoad = true,
                Salary = 10000.00m,
                CreatedBy = "intern",
                CreatedDate = System.DateTime.Now

            }, 
                new Employee()
            {
                EmployeeID = 3,
                EmployeeName = "aamir",
                Address = "maymar karachi",
                DateOfJoining = System.DateTime.Now,
                MartialStatus = 1,
                IsEligibleForLoad = true,
                Salary = 10000.00m,
                CreatedBy = "intern",
                CreatedDate = System.DateTime.Now

            },

                new Employee()
            {
                EmployeeID = 4,
                EmployeeName = "asif",
                Address = "maymar karachi",
                DateOfJoining = System.DateTime.Now,
                MartialStatus = 1,
                IsEligibleForLoad = true,
                Salary = 10000.00m,
                CreatedBy = "intern",
                CreatedDate = System.DateTime.Now

            },
                
                new Employee()
            {
                EmployeeID = 5,
                EmployeeName = "aqib",
                Address = "maymar karachi",
                DateOfJoining = System.DateTime.Now,
                MartialStatus = 1,
                IsEligibleForLoad = true,
                Salary = 10000.00m,
                CreatedBy = "intern",
                CreatedDate = System.DateTime.Now

            },
            };

            ViewBag.Employees = employees;

          
                log.Info("the Get employee try block ended");
            }
            catch(Exception ex)
            {
                log.Info("your application has an exception");
                log.Error(ex.Message);
            }
            return View();
        }
    }
}