using System;
using System.Collections.Generic;

namespace ReunionWeb.DTOs.Maestra;

public partial class CausaCalidadVDTO
{
    public int Idregistro { get; set; }

    public string? Centro { get; set; }

    public string? División { get; set; }

    public string? Status { get; set; }

    public DateTime? FechaDeReunion { get; set; }

    public int Idcausa { get; set; }

    public string CausaDeLaCalidad { get; set; } = null!;

    public bool Estado { get; set; }
}
