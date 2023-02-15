using System;
using System.Collections.Generic;

namespace ReunionWeb.NeoDbs
{
    public partial class Ksf
    {
        public Ksf()
        {
            ReuDia = new HashSet<ReuDium>();
        }

        public int Idksf { get; set; }
        public string KsfNombre { get; set; } = null!;
        public bool KsfEsta { get; set; }

        public virtual ICollection<ReuDium> ReuDia { get; set; }
    }
}
