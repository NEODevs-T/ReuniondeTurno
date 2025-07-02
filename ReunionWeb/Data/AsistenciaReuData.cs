using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;
using ReunionWeb.Data;


using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;
using ReunionWeb.Interface;

namespace ReunionWeb.Data;

public class PorcentajeAsistenciaDiariaResponseDTO
{
    public double PorcentajeGlobal { get; set; }
    public List<AsistenReuPorcetanjeDTO> DetallePorCargo { get; set; }
}

public class AsistenciaReuData : IAsistenciaReuData
{

    public AsistenciaReuData(IHttpClientFactory clientFactory, HttpClient http, NavigationManager navigationManager)
    {
        _http = http;

        _clientFactory = clientFactory;

    }

    private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/AsistenciaReu";
    // private const string BaseUrl2 = "http://localhost:5021/api/AsistenciaReuController";

    private HttpClient cliente { get; set; } = new HttpClient();
    private HttpClient _http { get; set; } = new HttpClient();
    private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
    private string url { get; set; } = "";
    private readonly IHttpClientFactory _clientFactory;
    public List<AsistenReuDTO> asistenreus { get; set; } = new List<AsistenReuDTO>();
    public List<StatsAsisDto> StatsAsisDtos { get; set; } = new List<StatsAsisDto>();
    public List<AsistenReuPorcetanjeDTO> asistenreuspor { get; set; } = new List<AsistenReuPorcetanjeDTO>();

    public async Task<List<StatsAsisDto>> GetStatsAsist(string div, string empresa, string f1, string f2)
    {
        url = $"{BaseUrl}/GetStatsAsis/{div}/{empresa}/{f1}/{f2}";
        cliente = _clientFactory.CreateClient();
        return StatsAsisDtos = await cliente.GetFromJsonAsync<List<StatsAsisDto>>(url) ?? new List<StatsAsisDto>();
    }

    public async Task<List<AsistenReuDTO>> GetListaAsist(string div, string empresa, string f1, string f2)
    {
        url = $"{BaseUrl}/GetListaAsis/{div}/{empresa}/{f1}/{f2}";
        cliente = _clientFactory.CreateClient();
        return asistenreus = await cliente.GetFromJsonAsync<List<AsistenReuDTO>>(url) ?? new List<AsistenReuDTO>();
    }

    public async Task<string> Postasistencia(List<AsistenReuDTO> asisten)
    {
        string mens = "";
        url = $"{BaseUrl}/AddAsistencia";
        cliente = _clientFactory.CreateClient();
        mensaje = await cliente.PostAsJsonAsync(url, asisten);
        if (mensaje.IsSuccessStatusCode)
        {
            mens = "Se añadido exitosamente";
        }
        return mens;
    }
    public async Task<PorcentajeAsistenciaDiariaResponseDTO?> GetPorcentajeAsistenciaResponse(string fechaInicio, string fechaFin, string empresa, string area)
    {
        url = $"{BaseUrl}/GetPorcentajeAsistenciaDiaria?fechaInicio={Uri.EscapeDataString(fechaInicio)}&fechaFin={Uri.EscapeDataString(fechaFin)}&empresa={Uri.EscapeDataString(empresa)}&area={Uri.EscapeDataString(area)}";
        cliente = _clientFactory.CreateClient();
        return await cliente.GetFromJsonAsync<PorcentajeAsistenciaDiariaResponseDTO>(url);
    }

    public async Task<List<AsistenReuPorcetanjeDTO>> GetListAsistPorce(string fechaInicio, string fechaFin, string empresa, string area)
    {
        url = $"{BaseUrl}/GetPorcentajeAsistenciaDiaria?fechaInicio={Uri.EscapeDataString(fechaInicio)}&fechaFin={Uri.EscapeDataString(fechaFin)}&empresa={Uri.EscapeDataString(empresa)}&area={Uri.EscapeDataString(area)}";
        cliente = _clientFactory.CreateClient();
        var response = await cliente.GetFromJsonAsync<PorcentajeAsistenciaDiariaResponseDTO>(url);
        return response?.DetallePorCargo ?? new List<AsistenReuPorcetanjeDTO>();
    }

}