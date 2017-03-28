using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projekat_ITS.Models
{
    public class Ucenik
    {
        //naknadno sam hteo da ubacim required polja, ali nisam se snasao zbog migracija

        [Key]
        public int id { get; set; }
        
        public string Ime { get; set; }
        public string Prezime { get; set; }
        [DisplayName("Ime Roditelja")]
        public string ImeRoditelja { get; set; }
        public int JMBG { get; set; }
        [DisplayName("Datum rodjenja")]
        public string DatumRodjenja { get; set; }
        [DisplayName("Mesto rodjenja")]
        public string MestoRodjenja { get; set; }
        [DisplayName("Opstina rodjenja")]
        public string OpstinaRodjenja { get; set; }
        public string Pol { get; set; }
        [DisplayName("Broj licne karte")]
        public int BrojLicneKarte { get; set; }
        [DisplayName("Broj telefona")]
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public string Adresa{ get; set; }
        public string Beleska { get; set; }  
    }
   
}