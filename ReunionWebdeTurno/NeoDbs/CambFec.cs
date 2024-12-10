﻿using System;
using System.Collections.Generic;

namespace ReunionWeb.NeoDbs
{
    public partial class CambFec
    {
        public int IdCambFec { get; set; }
        public int IdReuDia { get; set; }
        public DateTime Cffec { get; set; }
        public DateTime CffecNew { get; set; }
        public string Cfuser { get; set; } = null!;

        public virtual ReuDium IdReuDiaNavigation { get; set; } = null!;
    }
}
