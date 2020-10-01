using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjeCV.Models.Entity;

namespace ProjeCV.Models.Sinif
{
    public class Class1
    {
        public IEnumerable<tbl_hakkimda>  Deger1 { get; set; }
        public IEnumerable<tbl_deneyim> Deger2 { get; set; }
        public IEnumerable<tbl_egitim> Egitim { get; set; }

        public IEnumerable<tbl_hobiler> Hobiler { get; set; }

        public IEnumerable<tbl_oduller> Oduller { get; set; }

        public IEnumerable<tbl_yetenekler> Yetenekler { get; set; }
    }
}