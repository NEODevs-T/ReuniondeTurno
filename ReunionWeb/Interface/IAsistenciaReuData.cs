using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;
using ReunionWeb.Data;
using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;


namespace ReunionWeb.Interface;

public interface IAsistenciaReuData
{
    List<AsistenReuDTO> asistenreus { get; set; }
    List<StatsAsisDto> StatsAsisDtos { get; set; }
    List<AsistenReuPorcetanjeDTO> asistenreuspor { get; set; }

    Task<string> Postasistencia(List<AsistenReuDTO> asisten);
    Task<List<StatsAsisDto>> GetStatsAsist(string div, string empresa, string f1, string f2);
    Task<List<AsistenReuDTO>> GetListaAsist(string div, string empresa, string f1, string f2);
    Task<PorcentajeAsistenciaDiariaResponseDTO?> GetPorcentajeAsistenciaResponse(string fechaInicio, string fechaFin, string empresa, string area);

Task<PorcentajeAsistenciaTurnoResponseDTO> GetPorcentajeAsistenciaResponsee(
    string fechaInicio, string fechaFin, string empresa, string area,
    bool diasExcepcionalesLaborables = false, List<string> eventosExternos = null);
}

