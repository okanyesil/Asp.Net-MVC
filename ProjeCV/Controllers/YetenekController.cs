using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeCV.Models.Entity;
using ProjeCV.Models.Sinif;

namespace ProjeCV.Controllers
{
    public class YetenekController : Controller
    {
        // GET: Yetenek
        blogWebDbEntities db = new blogWebDbEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Yetenekler = db.tbl_yetenekler.ToList();
            return View(cs);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYetenek(tbl_yetenekler y)
        {
            db.tbl_yetenekler.Add(y);
            db.SaveChanges();
            return View();
        }
        public ActionResult YetenekSil(int id)
        {
            var yetenek = db.tbl_yetenekler.Find(id);
            db.tbl_yetenekler.Remove(yetenek);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YetenekGetir(int id)
        {
            var yetenek = db.tbl_yetenekler.Find(id);
            return View("YetenekGetir", yetenek);
        }
        public ActionResult Guncelle(tbl_yetenekler y)
        {
            var yetenek = db.tbl_yetenekler.Find(y.ID);
            yetenek.YETENEK = y.YETENEK;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}