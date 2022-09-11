using Microsoft.AspNetCore.Mvc;
using NguyenThuyDungBTH.Models;

namespace NguyenThuyDungBTH.Controllers
{
    public class PersonController: Controller
{
    [HttpPost]
    public IActionResult Index(Person std)
    {
        ViewBag.Ps = std.PersonID + "-"+ std.PersonName + "-"+ std.PersonBir + "-" + std.Address; 
        return View();
    }
    public IActionResult Create ()
    {
        return View();
    }
}

}
