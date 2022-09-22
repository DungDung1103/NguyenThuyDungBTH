using Microsoft.AspNetCore.Mvc;
using NguyenThuyDungBTH.Models.Process;

namespace NguyenThuyDungBTH.Controllers
{
    public class DemoController : Controller
    {
     // Giải phương trình bậc nhất
        Giaiphuongtrinh gpt = new Giaiphuongtrinh();
    
           public IActionResult Index(string heSoA, string heSoB)
           {
            double a = Convert.ToDouble(heSoA);
            double b = Convert.ToDouble(heSoB);
            string thongBao =  gpt.GiaiPhuongTrinhBacNhat(a,b);
            ViewBag.mess = thongBao;
              return View();
           }
         [HttpPost]
           public IActionResult Create (string a, string b, string c)
           {
            double x = Convert.ToDouble(a);
            double y = Convert.ToDouble(b);
            double z = Convert.ToDouble(c);
            string ptbac2 = gpt.GiaiPhuongTrinhBacHai(x,y,z);
            ViewBag.mes = ptbac2;
            return View();
           }
       
           
    }

    
}