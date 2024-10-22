using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;

using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;


namespace ReunionWeb.Interface;

interface IAvisadorData
{
    List<RespoReuDTO> resporeus { get; set; }
    ReuDiumDTO reuniondia { get; set; }
    List<ReuDiumDTO> reudiatablas { get; set; }
    List<AsistenReuDTO> asistenreus { get; set; }
    List<CargoReuDTO> cargoreuss { get; set; }
    List<CambStatDTO> cambiostatus { get; set; }
    List<CambFecDTO> cambiofecha { get; set; }

    Task<List<RespoReuDTO>> GetResReu();
    Task<List<CargoReuDTO>> GetAsistencia(string div, string empresa);
    Task<List<AsistenReuDTO>> GetStatsAsist(string div, string empresa, string f1, string f2);
    Task<List<AsistenReuDTO>> GetListaAsist(string div, string empresa, string f1, string f2);
    Task<string> Postasistencia(List<AsistenReuDTO> asisten);
    Task<List<ReuDiumDTO>> GetTrabajosCalendario(string pais, string centro, string division);
    Task<List<ReuDiumDTO>> GetByODT(string ODT, string idcentro, string iddiv);
    Task<List<ReuDiumDTO>> GetPendientes(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado);
    Task<List<ReuDiumDTO>> GetHistoricos(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado);
    Task<bool> UpdateDiscrepancia(ReuDiumDTO d, int id, int tipo, string f1, string f2, string estado);
    Task<bool> UpdateDiscrepancia2(ReuDiumDTO d, int id, int tipo, string f1, string f2, string estado, string linea);
    Task<List<CambStatDTO>> GetCambioStatus(int idreu);
    Task<List<CambFecDTO>> GetCambioFecha(int idreu);
    Task<ReuDiumDTO> GetDiscrepantacia(int id);
    Task<int> InsertDiscrepancia(ReuDiumDTO discre);
    Task<bool> InsertCambioStatus(CambStatDTO status);

    Task<bool> InsertCambioFec(CambFecDTO cambiofec);

    Task<bool> InsertarRegistros(RegistroCambiosDTO registroCambios);

    Task<CentroDivisionDTO> GetCentroDivi(string centro, string division, int tipo);
}