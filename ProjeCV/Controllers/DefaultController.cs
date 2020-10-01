using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeCV.Models.Entity;
using ProjeCV.Models.Sinif;
namespace ProjeCV.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        blogWebDbEntities db = new blogWebDbEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger1 = db.tbl_hakkimda.ToList();
            cs.Deger2 = db.tbl_deneyim.ToList();
            cs.Egitim = db.tbl_egitim.ToList();
            cs.Hobiler = db.tbl_hobiler.ToList();
            cs.Yetenekler = db.tbl_yetenekler.ToList();
            cs.Oduller = db.tbl_oduller.ToList();
            return View(cs);
            // var degerler = db.tbl_hakkimda.ToList();
            // return View(degerler);
        }
    }
}