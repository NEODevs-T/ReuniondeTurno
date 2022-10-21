using System;
using System.Collections.Generic;

namespace ReunionWeb.Models
{
    public partial class CheckLab
    {
        public string IdSol { get; set; } = null!;
        public string IdCheck { get; set; } = null!;
        public string Texto { get; set; } = null!;
    }
}
