using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeCV.Models.Entity;
using ProjeCV.Models.Sinif;
namespace ProjeCV.Controllers
{
    public class DeneyimController : Controller
    {
        // GET: Deneyim
        blogWebDbEntities db = new blogWebDbEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger2 = db.tbl_deneyim.ToList();
            return View(cs);
        }
        [HttpGet]
        public ActionResult YeniDeneyim()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniDeneyim(tbl_deneyim p)
        {
            db.tbl_deneyim.Add(p);
            db.SaveChanges();
            return View();
        }
        public ActionResult DeneyimSil(int id)
        {
            var deneyim = db.tbl_deneyim.Find(id);
            db.tbl_deneyim.Remove(deneyim);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeneyimGetir(int id)
        {
            var deneyim = db.tbl_deneyim.Find(id);
            return View("DeneyimGetir", deneyim);
        }
        public ActionResult Guncelle(tbl_deneyim d)
        {
            var veriler = db.tbl_deneyim.Find(d.ID);
            veriler.BASLIK = d.BASLIK;
            veriler.ALT_BASLIK = d.ALT_BASLIK;
            veriler.ACIKLAMA = d.ACIKLAMA;
            veriler.TARIH = d.TARIH;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}