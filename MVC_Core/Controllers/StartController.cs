using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Core.Models;

namespace MVC_Core.Controllers
{
    public class StartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var employeeList = new List<Employee>();

            var employee = new Employee();
            employee.Name = "August Sandell";
            employee.PhoneNumber = "1";
            employeeList.Add(employee);

            employee = new Employee();
            employee.Name = "Alyssa Phung";
            employee.PhoneNumber = "2";
            employeeList.Add(employee);

            employee = new Employee();
            employee.Name = "Nikola Maljenovic";
            employee.PhoneNumber = "3";
            employeeList.Add(employee);

            employee = new Employee();
            employee.Name = "Anders Kanth";
            employee.PhoneNumber = "4";
            employeeList.Add(employee);

            return View(employeeList);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Blah blah blah";

            return View();
        }
    }
}