using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;

using ReunionWeb.NeoDbs;
using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;
using ReunionWeb.Interface;


namespace ReunionWeb.Data;

public class AvisadorData: IAvisadorData
{
    public AvisadorData(NavigationManager navigationManager, IHttpClientFactory clientFactory, HttpClient http)
    {
        _clientFactory = clientFactory;
        _http = http;
        _navigationManager = navigationManager;
    }

    private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/Avisador";

    private readonly IHttpClientFactory _clientFactory;
    private HttpClient cliente { get; set; } = new HttpClient();
    private HttpClient _http { get; set; } = new HttpClient();
    private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
    private string url { get; set; } = "";

    public List<RespoReuDTO> resporeus { get; set; } = new List<RespoReuDTO>();
    public List<ReuDiumDTO> reunionditablas { get; set; } = new List<ReuDiumDTO>();
    public ReuDiumDTO reuniondia { get; set; } = new ReuDiumDTO();
    public List<ReuDiumDTO> reudiatablas { get; set; } = new List<ReuDiumDTO>();
    public List<AsistenReuDTO> asistenreus { get; set; } = new List<AsistenReuDTO>();
    public List<CargoReuDTO> cargoreuss { get; set; } = new List<CargoReuDTO>();
    public List<CambStatDTO> cambiostatus { get; set; } = new List<CambStatDTO>();
    public List<CambFecDTO> cambiofecha { get; set; } = new List<CambFecDTO>();

    private readonly NavigationManager _navigationManager;

    // **-------> PROPIEDADES DE JAVIER <------**


    public async Task<List<RespoReuDTO>> GetResReu()
    {
        url = $"{BaseUrl}/GetResponsables";
        cliente = _clientFactory.CreateClient();
        resporeus = await _http.GetFromJsonAsync<List<RespoReuDTO>>($"{BaseUrl}/GetResponsables");
        return await cliente.GetFromJsonAsync<List<RespoReuDTO>>(url) ?? new List<RespoReuDTO>();
    }


    public async Task<List<CargoReuDTO>> GetAsistencia(string div, string empresa)
    {
        url = $"{BaseUrl}/GetAsistencia/{div}/{empresa}";
        cliente = _clientFactory.CreateClient();
        return await cliente.GetFromJsonAsync<List<CargoReuDTO>>(url) ?? new List<CargoReuDTO>();
    }
    public async Task<List<AsistenReuDTO>> GetStatsAsist(string div, string empresa, string f1, string f2)
    {
        url = $"{BaseUrl}/GetStatsAsis/{div}/{empresa}/{f1}/{f2}";
        cliente = _clientFactory.CreateClient();
        return await cliente.GetFromJsonAsync<List<AsistenReuDTO>>(url) ?? new List<AsistenReuDTO>();
    }

    public async Task<List<AsistenReuDTO>> GetListaAsist(string div, string empresa, string f1, string f2)
    {
        url = $"{BaseUrl}/GetListaAsis/{div}/{empresa}/{f1}/{f2}";
        cliente = _clientFactory.CreateClient();
        return await cliente.GetFromJsonAsync<List<AsistenReuDTO>>(url) ?? new List<AsistenReuDTO>();
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

    public async Task<List<ReuDiumDTO>> GetTrabajosCalendario(string pais, string centro, string division)
    {
        url = $"{BaseUrl}/GetTrabajosPorCalendario/{pais}/{centro}/{division}";
        cliente = _clientFactory.CreateClient();
        return await cliente.GetFromJsonAsync<List<ReuDiumDTO>>(url) ?? new List<ReuDiumDTO>();
    }

    public async Task<List<ReuDiumDTO>> GetByODT(string ODT, string idcentro, string iddiv)
    {
        url = $"{BaseUrl}GetByODT/{ODT}/{idcentro}/{iddiv}";
        return reunionditablas = await _http.GetFromJsonAsync<List<ReuDiumDTO>>(url) ?? new List<ReuDiumDTO>();

    }

    //obtener discrepancias para pendientes y reunion 
    public async Task<List<ReuDiumDTO>> GetPendientes(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado)
    {
        string f1Formatiado = f1.ToString("yyyy-MM-dd");
        string f2Formatiado = f2.ToString("yyyy-MM-dd");
        url = $"{BaseUrl}/GetPendientes/{idcentro}/{iddiv}/{f1Formatiado}/{f2Formatiado}/{tipo}/{estado}";
        return reunionditablas = await _http.GetFromJsonAsync<List<ReuDiumDTO>>(url) ?? new List<ReuDiumDTO>();

    }

    //historicos
    public async Task<List<ReuDiumDTO>> GetHistoricos(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado)
    {
        string f1Formatiado = f1.ToString("yyyy-MM-dd");
        string f2Formatiado = f2.ToString("yyyy-MM-dd");
        url = $"{BaseUrl}/GetHistoricos/{idcentro}/{iddiv}/{f1Formatiado}/{f2Formatiado}/{tipo}/{estado}";
        return reunionditablas = await _http.GetFromJsonAsync<List<ReuDiumDTO>>(url) ?? new List<ReuDiumDTO>();

    }

    //Update Discrepancia
    public async Task<bool> UpdateDiscrepancia(ReuDiumDTO d, int id, int tipo, string f1, string f2, string estado)
    {
        bool band = false;
        url = $"{BaseUrl}/UpdateDiscrepancia/{id}";
        cliente = _clientFactory.CreateClient();
        mensaje = await cliente.PutAsJsonAsync(url, id);

        try
        {
            string div = "", centro = "";

            if (d.Rdcentro is not null)
            {
                CentroDivisionDTO centrodiv = await GetCentroDivi(d.Rdcentro, d.Rddiv, 1);

                if (centrodiv == null)
                {
                    return false;
                }

                centro = centrodiv.IdCentro.ToString();
                div = centrodiv.IdDivision.ToString();
            }

            if (mensaje.IsSuccessStatusCode)
            {
                band = await mensaje.Content.ReadFromJsonAsync<bool>();
            }

            if (band == true)
            {

                if (tipo == 0)
                {
                    _navigationManager.NavigateTo($"pendientes/{centro}/{div}/{f1}/{f2}/{tipo}/{estado}");
                }
                else if (tipo == 1)
                {
                    _navigationManager.NavigateTo($"reunion/{centro}/{div}/{f1}/{f2}/{tipo}/Reunion");
                }
                else if (tipo == 2)
                {
                    _navigationManager.NavigateTo($"pendientes/{centro}/{div}/{f1}/{f2}/{tipo}/{estado}");
                }
            }

            return true;

        }
        catch (Exception ex)
        {
            return false;
        }

    }




    public async Task<bool> UpdateDiscrepancia2(ReuDiumDTO d, int id, int tipo, string f1, string f2, string estado, string linea)
    {
        bool band = false;
        url = $"{BaseUrl}/UpdateDiscrepancia2/{id}";
        cliente = _clientFactory.CreateClient();
        mensaje = await cliente.PutAsJsonAsync(url, id);

        try
        {
            string div = "", centro = "";
            if (mensaje.IsSuccessStatusCode)
            {
                band = await mensaje.Content.ReadFromJsonAsync<bool>();
            }

            if (band == true)
            {
                if (tipo == 0)
                {
                    _navigationManager.NavigateTo($"pendientes/{centro}/{div}/{linea}/{f1}/{f2}/{tipo}/{estado}", forceLoad: true);
                }
                else if (tipo == 1)
                {
                    _navigationManager.NavigateTo($"reunion/{centro}/{div}/Re/{f1}/{f2}/{tipo}/Reunion", forceLoad: true);
                }
                else if (tipo == 2)
                {
                    _navigationManager.NavigateTo($"pendientes/{centro}/{div}/{linea}/{f1}/{f2}/{tipo}/{estado}", forceLoad: true);
                }

                return true;
            }
            else
            {
                return false;
            }

        }
        catch (Exception ex)
        {
            return false;
        }
    }




    public async Task<List<CambStatDTO>> GetCambioStatus(int idreu)
    {
        url = $"{BaseUrl}GetCambioStatus/{idreu}";
        return cambiostatus = await _http.GetFromJsonAsync<List<CambStatDTO>>(url) ?? new List<CambStatDTO>();
    }


    public async Task<List<CambFecDTO>> GetCambioFecha(int idreu)
    {
        url = $"{BaseUrl}GetCambioFecha/{idreu}";
        return cambiofecha = await _http.GetFromJsonAsync<List<CambFecDTO>>(url) ?? new List<CambFecDTO>();
    }


    //obtener discrepancia a editar
    public async Task<ReuDiumDTO> GetDiscrepantacia(int id)
    {
        url = $"{BaseUrl}GetDiscrepantaciaJT/{id}";
        return reuniondia = await _http.GetFromJsonAsync<ReuDiumDTO>(url) ?? new ReuDiumDTO();

    }


    public async Task<int> InsertDiscrepancia(ReuDiumDTO discre)
    {
        int data = 0;
        url = $"{BaseUrl}/AddDiscrepancia";
        cliente = _clientFactory.CreateClient();
        mensaje = await cliente.PostAsJsonAsync(url, discre);
        if (mensaje.IsSuccessStatusCode)
        {
            data = discre.IdReuDia;
        }
        return data;
    }


    public async Task<bool> InsertCambioStatus(CambStatDTO status)
    {
        bool band = false;
        url = $"{BaseUrl}/AddCambioStatus";
        cliente = _clientFactory.CreateClient();
        mensaje = await cliente.PostAsJsonAsync(url, status);

        if (mensaje.IsSuccessStatusCode)
        {
            band = await mensaje.Content.ReadFromJsonAsync<bool>();
        }
        return band;
    }


    public async Task<bool> InsertCambioFec(CambFecDTO cambiofec)
    {
        bool band = false;
        url = $"{BaseUrl}/AddCambioFec";
        cliente = _clientFactory.CreateClient();
        mensaje = await cliente.PostAsJsonAsync(url, cambiofec);

        if (mensaje.IsSuccessStatusCode)
        {
            band = await mensaje.Content.ReadFromJsonAsync<bool>();
        }
        return band;
    }

    public async Task<bool> InsertarRegistros(RegistroCambiosDTO registroCambios)
    {
        bool band = false;
        url = $"{BaseUrl}/AddRegistros";
        cliente = _clientFactory.CreateClient();
        mensaje = await cliente.PostAsJsonAsync(url, registroCambios);

        if (mensaje.IsSuccessStatusCode)
        {
            band = await mensaje.Content.ReadFromJsonAsync<bool>();
        }
        return band;
    }

    public async Task<CentroDivisionDTO> GetCentroDivi(string centro, string division, int tipo)
    {
        url = $"{BaseUrl}GetCentroDivi/{centro}/{division}/{tipo}";
        cliente = _clientFactory.CreateClient();
        return await cliente.GetFromJsonAsync<CentroDivisionDTO>(url) ?? new CentroDivisionDTO();

    }
}