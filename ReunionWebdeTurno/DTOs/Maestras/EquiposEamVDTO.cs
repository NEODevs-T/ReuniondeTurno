﻿using System;
using System.Collections.Generic;

namespace ReunionWeb.DTOs.Maestra;

public partial class EquiposEamVDTO
{
    public int IdEquipo { get; set; }

    public int IdLinea { get; set; }

    public int IdDivision { get; set; }

    public int IdCentro { get; set; }

    public int? IdMaster { get; set; }

    public string Equipo { get; set; } = null!;

    public string Linea { get; set; } = null!;

    public string Centro { get; set; } = null!;

    public string Division { get; set; } = null!;

    public string? Lofic { get; set; }

    public string CodigoEq { get; set; } = null!;

    public string? Desc { get; set; }

    public bool Estado { get; set; }

    public DateTime FechaEq { get; set; }
}
