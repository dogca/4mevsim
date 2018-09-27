using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Iletisim()
        {
            return View();
        }
        public ActionResult Urunler()
        {
            return View();
        }
        public ActionResult Galeri()
        {
            return View();
        }
        public ActionResult CamSistemleri()
        {
            return View();
        }
        public ActionResult Dolap()
        {
            return View();
        }
        public ActionResult Kapi()
        {
            return View();
        }
        public ActionResult LaminantParke()
        {
            return View();
        }
        public ActionResult Sineklik()
        {
            return View();
        }
        public ActionResult Panjur()
        {
            return View();
        }
        public ActionResult Dusakabin()
        {
            return View();
        }
        public ActionResult Urun()
        {
            return View();
        }



        [ChildActionOnly]
        public ActionResult _Slider()
        {
            return View();
        }
        public ActionResult _Urunler()
        {
            return View();
        }
        public ActionResult _Portfolyo()
        {
            return View();
        }
        public ActionResult _AltLink()
        {
            return View();
        }
        public ActionResult _SinglePageHeader()
        {
            return View();
        }
        public ActionResult _Daireler()
        {
            return View();
        }
    }
}