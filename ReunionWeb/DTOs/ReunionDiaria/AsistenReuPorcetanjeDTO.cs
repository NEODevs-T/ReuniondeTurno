using System;
using System.Collections.Generic;

namespace ReunionWeb.ReunionDiaria.DTOs;


public partial class AsistenReuPorcetanjeDTO
{
    public int IdCargoR { get; set; }

    public int ReunionesProgramadas { get; set; }

    public int ReunionesAsistidas { get; set; }

    public double  PorcentajeAsistencia { get; set; }
}