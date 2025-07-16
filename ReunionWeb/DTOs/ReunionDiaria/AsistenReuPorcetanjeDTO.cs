using System;
using System.Collections.Generic;

namespace ReunionWeb.ReunionDiaria.DTOs;


public partial class AsistenReuPorcetanjeDTO
{
    public int IdCargoR { get; set; }
    public string Nombre { get; set; }
    public int ReunionesProgramadas { get; set; }
    public int ReunionesAsistidas { get; set; }
    public double PorcentajeAsistencia { get; set; }
}

public class PorcentajeAsistenciaTurnoResponseDTO
{
    public double PorcentajeGlobal { get; set; }
    public List<AsistenReuPorcetanjeDTO> DetallePorCargo { get; set; }
}
