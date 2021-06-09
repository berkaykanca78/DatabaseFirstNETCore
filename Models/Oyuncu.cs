using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstCore.Models
{
    public partial class Oyuncu
    {
        public int Id { get; set; }
        public int TakimId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Yasi { get; set; }
        public int Mevki { get; set; }
        public decimal Maas { get; set; }
        public int SozlesmeSuresi { get; set; }
        public int Ulke { get; set; }

        public virtual Mevki MevkiNavigation { get; set; }
        public virtual Takim Takim { get; set; }
        public virtual Ulke UlkeNavigation { get; set; }
    }
}
