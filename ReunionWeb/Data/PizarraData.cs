
using Microsoft.AspNetCore.Components;
using ReunionWeb.ReunionDiaria.DTOs;
using ReunionWeb.DTOs.Maestra;
using ReunionWeb.Interface;
using System.Net.Http.Json;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ReunionWeb.Data;

public class PizarraData : IPizarraData
{
    private readonly IHttpClientFactory _clientFactory;
    private readonly NavigationManager _navigationManager;
    

    private const string BaseUrl = "http://neo.grandbay-corp.com/ApiNeoMasterP/api/Pizarra";
    private const string BaseUrl2 = "http://localhost:5021/api/Pizarra";

    private HttpClient _http { get; set; } = new HttpClient();
    public List<ReunionDTO> reunionditablas { get; set; } = new();
    public ReunionDTO reuniondia { get; set; } = new();
    public List<ReunionDTO> reudiatablas { get; set; } = new();
    public List<CalendarioTrabajoDTO> calentrabajo { get; set; } = new();

    public PizarraData(IHttpClientFactory clientFactory, HttpClient http, NavigationManager navigationManager)
    {
        _http = http;
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

    public async Task<List<ReunionDTO>> GetPendientes(
        string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado)
    {
        const int reunionDiaria = 2;
        const int pageSize = 100000; // único parámetro interno que se enviará

        string f1Formateado = f1.ToString("yyyy-MM-dd");
        string f2Formateado = f2.ToString("yyyy-MM-dd");

        string estadoNormalizado = estado ?? string.Empty;
        for (int i = 0; i < 2; i++)
        {
            string dec = Uri.UnescapeDataString(estadoNormalizado);
            if (dec == estadoNormalizado) break;
            estadoNormalizado = dec;
        }
        string estadoEncoded = Uri.EscapeDataString(estadoNormalizado);

        // Solo pageSize; NO se envían lastDate ni lastId
        var url =
            $"{BaseUrl}/GetPendientes/{idcentro}/{iddiv}/{f1Formateado}/{f2Formateado}/{tipo}/{estadoEncoded}/{reunionDiaria}" +
            $"?pageSize={pageSize}";

        var result = await _http.GetFromJsonAsync<List<ReunionDTO>>(url)
                    ?? new List<ReunionDTO>();

        return result;
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

    public async Task<bool> UpdateDiscrepancia(
        ReunionDTO d,
        int id,
        int tipo,
        string f1,
        string f2,
        string estado)
    {
        try
        {
            var client = _clientFactory.CreateClient();
            string url = $"{BaseUrl}/UpdateDiscrepancia/{id}";

            var response = await client.PutAsJsonAsync(url, id);

            if (!response.IsSuccessStatusCode)
                return false;

            bool band =
                await response.Content.ReadFromJsonAsync<bool>();

            if (!band)
                return false;

            // Normalizar centro y división
            string centro = string.Empty;
            string div = string.Empty;

            if (!string.IsNullOrWhiteSpace(d.Rdcentro) &&
                !string.IsNullOrWhiteSpace(d.Rddiv))
            {
                var centrodiv =
                    await GetCentroDivi(d.Rdcentro, d.Rddiv, 1);

                centro = centrodiv.IdCentro.ToString();
                div = centrodiv.IdDivision.ToString();
            }
            else
            {
                // No se puede navegar sin centro/división
                return false;
            }

            // Construcción de la ruta
            string ruta = tipo switch
            {
                0 => $"pendientes/{centro}/{div}/{f1}/{f2}/{tipo}/{estado}",
                1 => $"reunion/{centro}/{div}/{f1}/{f2}/{tipo}/Reunion",
                2 => $"pendientes/{centro}/{div}/{f1}/{f2}/{tipo}/{estado}",
                _ => string.Empty
            };

            if (!string.IsNullOrEmpty(ruta))
            {
                _navigationManager.NavigateTo(ruta);
            }

            return true;
        }
        catch
        {
            return false;
        }
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
                var centro = d.Rdcentro ?? string.Empty;
                var division = d.Rddiv ?? string.Empty;

                if (string.IsNullOrWhiteSpace(centro) || string.IsNullOrWhiteSpace(division))
                    return (false, string.Empty, string.Empty);

                var centrodiv = await GetCentroDivi(centro, division, 1);

                return (
                    true,
                    centrodiv.IdCentro.ToString(),
                    centrodiv.IdDivision.ToString()
                );
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
