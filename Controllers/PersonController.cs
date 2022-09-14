using Microsoft.AspNetCore.Mvc;
using NguyenThuyDungBTH.Models;

namespace NguyenThuyDungBTH.Controllers
{
    public class PersonController: Controller
{
    
    public IActionResult Index(Person std)
    {
        ViewBag.Ps = std.PersonID + "-"+ std.PersonName + "-"+ std.PersonBir + "-" + std.Address; 
       return View();
    }
  public class EmployeeController : Controller
    {
        // Viết các phương thức
        public IActionResult List()
{
    
    // khoi tao list Student
     List<Person> listPerson = new List<Person>()
     {
         new Person {PersonID = 1, PersonName = "Nguyen Van A", PersonBir="11/03/2001", Address = "Hà Nội"},
         new Person {PersonID = 2, PersonName = "Nguyen Van B", PersonBir="26/05/2001", Address = "Hải Phòng"},
         new Person {PersonID = 3, PersonName = "Nguyen Van C", PersonBir="11/12/2001", Address= "Nam Định"}
         
     };
     ViewData["Persons"] = listPerson;
    return View(listPerson);
}
[HttpPost]
 public IActionResult Create(Person std)
        {
            string mess = std.PersonID + "-";
            mess += std.PersonName + "-";
            mess += std.PersonBir + "-";
            mess += std.Address;
            ViewBag.EMPL = mess;
            return View();
        }
    }
}

}
