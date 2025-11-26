
using Microsoft.AspNetCore.Components;
using ReunionWeb.ReunionDiaria.DTOs;
using ReunionWeb.DTOs.Maestra;
using ReunionWeb.Interface;
using System.Net.Http.Json;

namespace ReunionWeb.Data;

public class PizarraData : IPizarraData
{
    private readonly IHttpClientFactory _clientFactory;
    private readonly NavigationManager _navigationManager;

    private const string BaseUrl = "http://neo.grandbay-corp.com/ApiNeoMasterP/api/Pizarra";
    private const string BaseUrl2 = "http://localhost:5021/api/Pizarra";

    public List<ReunionDTO> reunionditablas { get; set; } = new();
    public ReunionDTO reuniondia { get; set; } = new();
    public List<ReunionDTO> reudiatablas { get; set; } = new();
    public List<CalendarioTrabajoDTO> calentrabajo { get; set; } = new();

    public PizarraData(IHttpClientFactory clientFactory, NavigationManager navigationManager)
    {
        _clientFactory = clientFactory;
        _navigationManager = navigationManager;
    }

    public async Task<List<CalendarioTrabajoDTO>> GetTrabajosCalendario(string pais, string centro, string division)
    {
        var client = _clientFactory.CreateClient();
        int reunionTurno = 2;
        string url = $"{BaseUrl}/GetTrabajosPorCalendario/{pais}/{centro}/{division}/{reunionTurno}";
        return calentrabajo = await client.GetFromJsonAsync<List<CalendarioTrabajoDTO>>(url) ?? new();
    }

    public async Task<List<ReunionDTO>> GetByODT(string ODT, string idcentro, string iddiv)
    {
        var client = _clientFactory.CreateClient();
        string url = $"{BaseUrl}/GetByODT/{ODT}/{idcentro}/{iddiv}";
        return reunionditablas = await client.GetFromJsonAsync<List<ReunionDTO>>(url) ?? new();
    }

    public async Task<List<ReunionDTO>> GetPendientes(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado)
    {
        var client = _clientFactory.CreateClient();
        int reunionTurno = 2;
        string f1Formatiado = f1.ToString("yyyy-MM-dd");
        string f2Formatiado = f2.ToString("yyyy-MM-dd");
        string url = $"{BaseUrl}/GetPendientes/{idcentro}/{iddiv}/{f1Formatiado}/{f2Formatiado}/{tipo}/{estado}/{reunionTurno}";
        return reudiatablas = await client.GetFromJsonAsync<List<ReunionDTO>>(url) ?? new();
    }

    public async Task<List<ReunionDTO>> GetPendientesTurno(string idcentro, string iddiv)
    {
        var client = _clientFactory.CreateClient();
        string url = $"{BaseUrl}/GetPendientesTurno/{idcentro}/{iddiv}";
        return reudiatablas = await client.GetFromJsonAsync<List<ReunionDTO>>(url) ?? new();
    }

    public async Task<List<ReunionDTO>> GetHistoricos(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado)
    {
        var client = _clientFactory.CreateClient();
        int reunionTurno = 2;
        string f1Formatiado = f1.ToString("yyyy-MM-dd");
        string f2Formatiado = f2.ToString("yyyy-MM-dd");
        string url = $"{BaseUrl}/GetHistoricos/{idcentro}/{iddiv}/{f1Formatiado}/{f2Formatiado}/{tipo}/{estado}/{reunionTurno}";
        return reudiatablas = await client.GetFromJsonAsync<List<ReunionDTO>>(url) ?? new();
    }

    public async Task<bool> UpdateDiscrepancia(ReunionDTO d, int id, int tipo, string f1, string f2, string estado)
    {
        var client = _clientFactory.CreateClient();
        string url = $"{BaseUrl}/UpdateDiscrepancia/{id}";
        var response = await client.PutAsJsonAsync(url, id);

        try
        {
            string div = "", centro = "";
            if (d.Rdcentro is not null)
            {
                CentroDivisionDTO centrodiv = await GetCentroDivi(d.Rdcentro, d.Rddiv, 1);
                if (centrodiv == null) return false;
                centro = centrodiv.IdCentro.ToString();
                div = centrodiv.IdDivision.ToString();
            }

            if (response.IsSuccessStatusCode)
            {
                bool band = await response.Content.ReadFromJsonAsync<bool>();
                if (band)
                {
                    string ruta = tipo switch
                    {
                        0 => $"pendientes/{centro}/{div}/{f1}/{f2}/{tipo}/{estado}",
                        1 => $"reunion/{centro}/{div}/{f1}/{f2}/{tipo}/Reunion",
                        2 => $"pendientes/{centro}/{div}/{f1}/{f2}/{tipo}/{estado}",
                        _ => ""
                    };
                    _navigationManager.NavigateTo(ruta);
                }
                return band;
            }
        }
        catch
        {
            return false;
        }

        return false;
    }

    public async Task<(bool success, string centro, string division)> UpdateDiscrepancia2(ReunionDTO d, int id)
    {
        var client = _clientFactory.CreateClient();
        client.Timeout = TimeSpan.FromMinutes(5);
        string url = $"{BaseUrl}/UpdateDiscrepancia2/{id}";
        var response = await client.PutAsJsonAsync(url, d);

        if (response.IsSuccessStatusCode)
        {
            bool band = await response.Content.ReadFromJsonAsync<bool>();
            if (band)
            {
                var centrodiv = await GetCentroDivi(d.Rdcentro, d.Rddiv, 1);
                return (true, centrodiv.IdCentro.ToString(), centrodiv.IdDivision.ToString());
            }
        }

        return (false, "", "");
    }

    public async Task<bool> UpdateDiscrepancia3(ReunionDTO d, int id)
    {
        var client = _clientFactory.CreateClient();
        string url = $"{BaseUrl}/UpdateDiscrepancia2/{id}";
        var response = await client.PutAsJsonAsync(url, d);
        return response.IsSuccessStatusCode && await response.Content.ReadFromJsonAsync<bool>();
    }

    public async Task<ReunionDTO> GetDiscrepantacia(int id)
    {
        var client = _clientFactory.CreateClient();
        string url = $"{BaseUrl}/GetDiscrepantacia/{id}";
        return reuniondia = await client.GetFromJsonAsync<ReunionDTO>(url) ?? new();
    }

    public async Task<int> InsertDiscrepancia(ReunionDTO discre)
    {
        var client = _clientFactory.CreateClient();
        string url = $"{BaseUrl}/AddDiscrepancia";
        var response = await client.PostAsJsonAsync(url, discre);
        return response.IsSuccessStatusCode ? discre.IdReuDia : 0;
    }

    public async Task<CentroDivisionDTO> GetCentroDivi(string centro, string division, int tipo)
    {
        var client = _clientFactory.CreateClient();
        string url = $"http://neo.grandbay-corp.com/ApiNeoMasterP/api/Maestra/GetCentroDivi/{centro}/{division}/{tipo}";
        return await client.GetFromJsonAsync<CentroDivisionDTO>(url) ?? new();
    }
}
