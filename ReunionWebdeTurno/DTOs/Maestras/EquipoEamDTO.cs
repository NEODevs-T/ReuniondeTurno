using System;
using System.Collections.Generic;

namespace ReunionWeb.DTOs.Maestra;


public class EquipoEamDTO
{
    public int IdEquipo { get; set; }

    public int IdLinea { get; set; }

    public string EcodEquiEam { get; set; } = null!;

    public string EnombreEam { get; set; } = null!;

    public string? EdescriEam { get; set; }

    public bool EestaEam { get; set; }

    public DateTime Efecha { get; set; }

    public LineaDTO Linea { get; set; }


}