using Microsoft.AspNetCore.Mvc;
using NguyenThuyDungBTH.Models;

namespace NguyenThuyDungBTH.Controllers
{
    public class EmployeeController : Controller
    {
        // Viết các phương thức
    
       
        public IActionResult Index( Employee std)
        {
            ViewBag.Ep = std.EmployeeID +"-"+ std.EmployeeName +"-"+ std.EmployeeAddress;
       
            return View();
        }
        
        public IActionResult List()
{
    
    // khoi tao list Student
     List<Employee> listEmpl = new List<Employee>()
     {
         new Employee {EmployeeID = 1, EmployeeName = "Nguyen Van A", EmployeeAddress = "Hà Nội"},
         new Employee {EmployeeID = 2, EmployeeName = "Nguyen Van B", EmployeeAddress = "Hải Phòng"},
         new Employee {EmployeeID = 3, EmployeeName = "Nguyen Van C", EmployeeAddress = "Nam Định"}
         
     };
     ViewData["Employees"] = listEmpl;
    return View(listEmpl);
}
[HttpPost]
 public IActionResult Create(Employee std)
        {
            string mess = std.EmployeeID + "-";
            mess += std.EmployeeName + "-";
            mess += std.EmployeeAddress;
            ViewBag.EMPL = mess;
            return View();
        }
        
         
        
    }
    
}