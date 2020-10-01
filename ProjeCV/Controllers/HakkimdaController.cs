using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeCV.Models.Entity;
using ProjeCV.Models.Sinif;

namespace ProjeCV.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda
        
        blogWebDbEntities db = new blogWebDbEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger1 = db.tbl_hakkimda.ToList();
            return View(cs);
        }
        public ActionResult VeriGetir(int id)
        {
            var veriler = db.tbl_hakkimda.Find(id);
            return View("VeriGetir", veriler);
        }
        public ActionResult Guncelle(tbl_hakkimda p)
        {
            var degerler = db.tbl_hakkimda.Find(p.ID);
            degerler.AD = p.AD;
            degerler.SOYAD = p.SOYAD;
            degerler.MAIL = p.MAIL;
            degerler.KISANOT = p.KISANOT;
            degerler.TELEFON = p.TELEFON;
            degerler.FOTOGRAF = p.FOTOGRAF;
            degerler.ADRESS = p.ADRESS;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}