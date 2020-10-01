using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeCV.Models.Entity;
using ProjeCV.Models.Sinif;
namespace ProjeCV.Controllers
{
    public class IlgiAlanlariController : Controller
    {
        // GET: IlgiAlanlari
        blogWebDbEntities db = new blogWebDbEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Hobiler = db.tbl_hobiler.ToList();
            return View(cs);
        }
        [HttpGet]
        public ActionResult YeniIlgiAlani()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniIlgiAlani(tbl_hobiler h)
        {
            db.tbl_hobiler.Add(h);
            db.SaveChanges();
            return View();
        }
        public ActionResult IlgiSil(int id)
        {
            var ialani = db.tbl_hobiler.Find(id);
            db.tbl_hobiler.Remove(ialani);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult IlgiGetir(int id)
        {
            var iAlani = db.tbl_hobiler.Find(id);
            return View("IlgiGetir", iAlani);
        }
        public ActionResult Guncelle(tbl_hobiler h)
        {
            var hobi = db.tbl_hobiler.Find(h.ID);
            hobi.HOBI = h.HOBI;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}