using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstCore.Models
{
    public partial class Ulke
    {
        public Ulke()
        {
            Oyuncus = new HashSet<Oyuncu>();
        }

        public int Id { get; set; }
        public string UlkeAdi { get; set; }

        public virtual ICollection<Oyuncu> Oyuncus { get; set; }
    }
}
