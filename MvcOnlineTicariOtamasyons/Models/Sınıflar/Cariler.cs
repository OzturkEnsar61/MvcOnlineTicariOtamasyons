﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtamasyons.Models.Sınıflar
{
    public class Cariler
    {
        [Key]
        public int CariAd  { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CariSoyad  { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)] 
        public string CariSehir { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CariMail { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}