    using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;


using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;
using ReunionWeb.Interface;

namespace ReunionWeb.Data;

public class CausaCalidadData: ICausaCalidadData
{
    public CausaCalidadData(IHttpClientFactory clientFactory, HttpClient http, NavigationManager navigationManager)
    {
        _http = http;

        _clientFactory = clientFactory;

    }

    private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/CausaCalidad";

   // private const string BaseUrl2 = "http://localhost:5021/api/CausaCalidad";
    private HttpClient cliente { get; set; } = new HttpClient();
    private HttpClient _http { get; set; } = new HttpClient();
    private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
    private string url { get; set; } = "";
    private readonly IHttpClientFactory _clientFactory;
    
    public List<CausaCalDTO> causaCals { get; set; } = new List<CausaCalDTO>();
    
    
    public async Task<List<CausaCalDTO>> GetCausasCalidad()
    {
        url = $"{BaseUrl}/GetCausasCalidad";
        cliente = _clientFactory.CreateClient();
        causaCals = await _http.GetFromJsonAsync<List<CausaCalDTO>>(url);
        var results = causaCals;
        return results;
    }
}
