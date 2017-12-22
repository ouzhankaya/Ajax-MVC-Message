using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ajaxQuizOrnegi.BL;
using ajaxQuizOrnegi.Models;

namespace ajaxQuizOrnegi.Controllers
{
    public class MesajController : Controller
    {
        public ActionResult MesajView()
        {
            return View();
        }

        public JsonResult MesajEkle(string mesaj)
        {
            return Json(MesajIslemleri.MesajEkle(mesaj));
        }

        public JsonResult MesajListele()
        {
            return Json(MesajIslemleri.MesajlariListele());
        }
    }
}