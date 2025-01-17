using System;
using System.Collections.Generic;

namespace ReunionWeb.DTOs.Maestra;


public partial class LineaVDTO
{
    public int IdDivision { get; set; }

    public int IdLinea { get; set; }

    public string Linea { get; set; } = null!;

    public string LcenCos { get; set; } = null!;

    public int IdMaster { get; set; }

    public bool Estado { get; set; }

    public int? IdCentro { get; set; }
}
