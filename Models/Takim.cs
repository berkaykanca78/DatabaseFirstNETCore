using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstCore.Models
{
    public partial class Takim
    {
        public Takim()
        {
            Oyuncus = new HashSet<Oyuncu>();
        }

        public int Id { get; set; }
        public string TakimAdi { get; set; }

        public virtual ICollection<Oyuncu> Oyuncus { get; set; }
    }
}
