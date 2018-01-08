using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCViewResults.Controllers
{
    public class JsonResulttController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        //Ajax isteği gelecek
        //View Çıktısı yok sadece js objesi döndürür.
        //like işleminin database yansıması için JsonResult yazarız
        public JsonResult Like(bool isLike=false)
        {
            //isLike = !isLike;
            //JsonRequestBehavior.AllowGet kaynağa ajax get isteği yapılmasına izin verdik.

            return Json(isLike,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SendMessage(string message)
        {
            return Json("Gerçekleşti");
        }
    }
}