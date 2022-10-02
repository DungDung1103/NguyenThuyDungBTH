using Microsoft.AspNetCore.Mvc;
using NguyenThuyDungBTH.Models.Process;

namespace NguyenThuyDungBTH.Controllers
{
    public class StringProcessController : Controller
    {
        stringProcess strPro = new stringProcess();
        [HttpPost]
        public IActionResult Index ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index (string strInput)
        {
            string result = strPro.RemoveRemainingWhiteSpace(strInput);
            ViewBag.ketqua = result;
            return View();
        }
        [HttpPost]
         public IActionResult chuhoa (string strInput)
        {
            string result1 = strPro.LowerToUpper(strInput);
            ViewBag.ketqua1 = result1;
            return View();
        }[HttpPost]
         public IActionResult chuthuong (string strInput)
         {
             string result2 = strPro.UpperToLower(strInput);
            ViewBag.ketqua2 = result2;
             return View();
         }
         [HttpPost]
         public IActionResult kytudauchuoi (string strInput)
         {
             string result3 = strPro.CapitalizeOneFirstCharacter(strInput);
            ViewBag.ketqua3 = result3;
             return View();
         }
         [HttpPost]
         public IActionResult kytudaucactu (string strInput)
         {
             string result4 = strPro.CapitalizeFirstCharacter(strInput);
            ViewBag.ketqua4 = result4;
             return View();
         }
         [HttpPost]
          public IActionResult Xoadaucactu (string strInput)
         {
             string result5 = strPro.RemoveRemainingWhiteSpace(strInput);
            ViewBag.ketqua5 = result5;
             return View();
         }
    }
}