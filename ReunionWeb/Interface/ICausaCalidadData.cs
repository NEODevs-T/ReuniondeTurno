using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;


using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;


namespace ReunionWeb.Interface;

interface ICausaCalidadData
{
    List<CausaCalDTO> causaCals { get; set; }
    Task<List<CausaCalDTO>> GetCausasCalidad();
}