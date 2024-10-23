using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;

using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;


namespace ReunionWeb.Interface;

interface IPizarraData
{
    ReuDiumDTO reuniondia { get; set; }
    List<ReuDiumDTO> reudiatablas { get; set; }
    Task<List<ReuDiumDTO>> GetTrabajosCalendario(string pais, string centro, string division);
    Task<List<ReuDiumDTO>> GetByODT(string ODT, string idcentro, string iddiv);
    Task<List<ReuDiumDTO>> GetPendientes(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado);
    Task<List<ReuDiumDTO>> GetHistoricos(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado);
    Task<ReuDiumDTO> GetDiscrepantacia(int id);
    Task<bool> UpdateDiscrepancia(ReuDiumDTO d, int id, int tipo, string f1, string f2, string estado);
    Task<bool> UpdateDiscrepancia2(ReuDiumDTO d, int id, int tipo, string f1, string f2, string estado, string linea);
    Task<int> InsertDiscrepancia(ReuDiumDTO discre);
    Task<CentroDivisionDTO> GetCentroDivi(string centro, string division, int tipo);

}