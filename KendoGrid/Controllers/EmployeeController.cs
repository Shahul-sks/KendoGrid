using KendoGrid.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace KendoGrid.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeContext employeeContext;
        public IActionResult Index()
        {
            return View();
        }
        //Grid View Controller
        public EmployeeController(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        public ActionResult GetData()
        {
            var employee = employeeContext.Employees.ToList();
            return Json(employee);
        }
       

        [HttpPost]
        public IActionResult CreateData(Employee data)
        {

            employeeContext.Employees.Add(data);
            employeeContext.SaveChanges();

            return Json(data);

        }

        [HttpPost]
        public IActionResult UpdateData(Employee data)
        {
            if (ModelState.IsValid)
            {
                employeeContext.Employees.Update(data);
                employeeContext.SaveChanges();
                return Json(data);
                //return RedirectToAction("Index");
            }
            return BadRequest(ModelState);

        }

        [HttpPost]
        public IActionResult DeleteData(int empid)
            {
            var del = employeeContext.Employees.Find(empid);
            employeeContext.Remove(del);
            employeeContext.SaveChanges();
            //return Json(new { id });
            return new JsonResult("yes");
        }

        

        //ListView Controller
             public IActionResult List()
             {
                return View();
             }

        public ActionResult GetData1()
        {
            var data = employeeContext.Employees.ToList();
            return Json(data);
        }

        [HttpPost]

        public IActionResult CreateData1(Employee data)
        {
            employeeContext.Employees.Add(data);
            employeeContext.SaveChanges();
            return Json(data);
        }

        [HttpPost]
        public IActionResult UpdateData1(Employee data)
        {
            if (ModelState.IsValid)
            {
                employeeContext.Employees.Update(data);
                employeeContext.SaveChanges();
                return Json(data);
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public IActionResult DeleteData1(int empid)
        {
            var del = employeeContext.Employees.Find(empid);
            employeeContext.Remove(del);
            employeeContext.SaveChanges();
            return Json(new { success = true });

        }






    }
}
