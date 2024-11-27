using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StokTakipSistemi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var userRole = Convert.ToInt32(Session["KulTIP"]); // Varsayılan olarak 'Guest' olarak kabul ediyoruz

            // Eğer depo yetkilisi (Role ID = 2) ise özel görünüme yönlendirme
            if (userRole == 2)
            {
                return View("WarehouseManagerView");
            }
            else
            {
                return View("Index");
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}