using System;
using System.Collections.Generic;

namespace ReunionWeb.NeoDbs
{
    public partial class Empresa
    {
        public int IdEmpresa { get; set; }
        public int IdPais { get; set; }
        public string Enombre { get; set; } = null!;
        public string? Edescri { get; set; }
        public bool Eestado { get; set; }

        public virtual Pai IdPaisNavigation { get; set; } = null!;
        public virtual ICollection<Centro> Centros { get; set; }
    }
}
