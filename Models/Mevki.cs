using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstCore.Models
{
    public partial class Mevki
    {
        public Mevki()
        {
            Oyuncus = new HashSet<Oyuncu>();
        }

        public int Id { get; set; }
        public string MevkiAdi { get; set; }

        public virtual ICollection<Oyuncu> Oyuncus { get; set; }
    }
}
