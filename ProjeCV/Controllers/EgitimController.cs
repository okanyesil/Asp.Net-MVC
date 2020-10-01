using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeCV.Models.Entity;
using ProjeCV.Models.Sinif;
namespace ProjeCV.Controllers
{
    public class EgitimController : Controller
    {
        // GET: Egitim
        blogWebDbEntities db = new blogWebDbEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Egitim = db.tbl_egitim.ToList();
            return View(cs);
        }
        [HttpGet]
        public ActionResult YeniEgitimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniEgitimEkle(tbl_egitim e)
        {
            db.tbl_egitim.Add(e);
            db.SaveChanges();
            return View();
        }
        public ActionResult EgitimSil(int id)
        {
            var egitim = db.tbl_egitim.Find(id);
            db.tbl_egitim.Remove(egitim);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EgitimGetir(int id)
        {
            var egitim = db.tbl_egitim.Find(id);
            return View("EgitimGetir", egitim);
        }
        public ActionResult Guncelle(tbl_egitim e)
        {
            var egitim = db.tbl_egitim.Find(e.ID);
            egitim.BASLIK = e.BASLIK;
            egitim.ALT_BASLIK = e.ALT_BASLIK;
            egitim.ACIKLAMA = e.ACIKLAMA;
            egitim.TARIH = e.TARIH;
            egitim.GNOT = e.GNOT;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}