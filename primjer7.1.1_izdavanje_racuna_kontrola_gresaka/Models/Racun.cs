using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace primjer7._1._1_izdavanje_racuna_kontrola_gresaka.Models
{
    public class Racun
    {
        public string BrojRacuna { get; set; }
        public DateTime Datum { get; set; }
        public string Zaposlenik { get; set; }
        public string Kupac { get; set; }
        public decimal Cijena { get; set; }

    }
}