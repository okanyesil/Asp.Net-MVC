using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeCV.Models.Entity;
using ProjeCV.Models.Sinif;
namespace ProjeCV.Controllers
{
    public class OdulController : Controller
    {
        // GET: Odul
        blogWebDbEntities db = new blogWebDbEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Oduller = db.tbl_oduller.ToList();
            return View(cs);
        }
        [HttpGet]
        public ActionResult YeniOdul()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniOdul(tbl_oduller o)
        {
            db.tbl_oduller.Add(o);
            db.SaveChanges();
            return View();
        }
        public ActionResult OdulSil(int id)
        {
            var odul = db.tbl_oduller.Find(id);
            db.tbl_oduller.Remove(odul);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult OdulGetir(int id)
        {
            var odul = db.tbl_oduller.Find(id);
            return View("OdulGetir", odul);
        }
        public ActionResult Guncelle(tbl_oduller o)
        {
            var odul = db.tbl_oduller.Find(o.ID);
            odul.ODULLER = o.ODULLER;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}