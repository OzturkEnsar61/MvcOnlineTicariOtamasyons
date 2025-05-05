using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtamasyons.Models.Sınıflar
{
    public class Departman
    {
        [Key]
        public int DeparmanID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string DeparmanAd { get; set; }
        public bool Durum { get; set; } = true;
        public ICollection<Personel> Personels { get; set; }
        

    }
}