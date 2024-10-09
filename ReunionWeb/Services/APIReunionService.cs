using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;

using ReunionWeb.NeoDbs;
using static System.Net.WebRequestMethods;
using ReunionWeb.DTOs.Maestra;

namespace ReunionWeb.Services;
public class APIReunionService: IAPIReunionService
{
        // **-------> CONEXION A LA API <--------**
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrlMaestra = "http://neo.paveca.com.ve/apineomaster/api/Maestra";
        private const string BaseUrlLineas = "http://neo.paveca.com.ve/apineomaster/api/Lineas";
        private const string ViejaUrl1 = "http://neo.paveca.com.ve/ReunionApi/Lineas";
        private const string ViejaUrl2 = "http://neo.paveca.com.ve/ReunionApi/Empresas";
        private HttpClient cliente { get; set; } = new HttpClient();
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url { get; set; } = "";

        // **-------> CONEXION A LA API <--------**


        // **-------> PROPIEDADES DE JAVIER <------**

        // List<CentroDTO> centro { get; set; }
        // List<Linea> lineas { get; set; }
        // List<Division> divisions { get; set; }
        // List<Ksf> ksfs { get; set; }
        // List<RespoReu> resporeu { get; set; }
        // List<ReunionDium> reunionditabla { get; set; }
        // List<ReuDium> reudiatabla { get; set; }
        // List<AsistenReu> asistenreus { get; set; }
        // List<CargoReu> cargoreus { get; set; }
        // List<StatsAsisDto> StatsAsisDtos { get; set; }
        // List<EquipoEam> equipos { get; set; }
        // List<EquipoEam> equiposlinea { get; set; }
        // List<CalendarioTrabajoDTO> calentrabajo { get; set; }

        // **-------> PROPIEDADES DE JAVIER <------**


        public async Task<List<EquipoEamDTO>> GetEquiposEAM(string cent)
        {
                url = $"{BaseUrlLineas}/GetEquipos/{cent}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<EquipoEamDTO>>(url) ?? new List<EquipoEamDTO>();

        }
        public async Task<List<EquipoEamDTO>> GetEquiposID(string idCentro)
        {
                url = $"{BaseUrlMaestra}/GetEquipos/{idCentro}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<EquipoEamDTO>>(url) ?? new List<EquipoEamDTO>();

        }
        public async Task<List<EquipoEamDTO>> GetEquiposxlinea(string idLinea)
        {
                url = $"{BaseUrlMaestra}GetEquiposEAMPorLinea/{idLinea}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<EquipoEamDTO>>(url) ?? new List<EquipoEamDTO>();

        }

        public async Task<List<LineaDTO>> GetBdDiv(string cent)
        {
                url = $"{BaseUrlLineas}/GetBdDiv/{cent}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<LineaDTO>>(url) ?? new List<LineaDTO>();
        }

        public async Task<List<CentrosVDTO>> GetCentrosxEmpresa(string cent)
        {
                url = $"{BaseUrlMaestra}/GetCentrosJT/{cent}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<CentrosVDTO>>(url) ?? new List<CentrosVDTO>();
        }


        // public async Task GetDivision(string centro, string div)
        // {
        //     var result = await _http.GetFromJsonAsync<List<Division>>($"http://neo.paveca.com.ve/ReunionApi/Lineas/Division/{centro}/{div}");
        //     //var result = await _http.GetFromJsonAsync<List<Division>>($"http://localhost:5258/Lineas/Division/{centro}/{div}");
        //     if (result != null)
        //         divisions = result;
        //}



        public async Task<List<LineaVDTO>> GetLineas(int idDivision)
        {
                url = $"{BaseUrlMaestra}/GetLineas/{idDivision:int}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<LineaVDTO>>(url) ?? new List<LineaVDTO>();
        }


        public async Task<List<KsfDTO>> Getksf()
        {
                url = $"{BaseUrlMaestra}/GetKsf";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<KsfDTO>>(url) ?? new List<KsfDTO>();
        }

        public async Task<List<RespoReuDTO>> GetResReu()
        {
                url = $"{BaseUrlMaestra}/GetResponsables";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<RespoReuDTO>>(url) ?? new List<RespoReuDTO>();
        }


        public async Task<List<CargoReuDTO>> GetAsistencia(string div, string empresa)
        {
                url = $"{BaseUrlMaestra}/GetAsistencia/{div}/{empresa}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<CargoReuDTO>>(url) ?? new List<CargoReuDTO>();
        }
        public async Task<List<AsistenReuDTO>> GetStatsAsist(string div, string empresa, string f1, string f2)
        {
                url = $"{BaseUrlMaestra}/GetStatsAsis/{div}/{empresa}/{f1}/{f2}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<AsistenReuDTO>>(url) ?? new List<AsistenReuDTO>();
        }

        public async Task<List<AsistenReuDTO>> GetListaAsist(string div, string empresa, string f1, string f2)
        {
                url = $"{BaseUrlMaestra}/GetListaAsis/{div}/{empresa}/{f1}/{f2}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<AsistenReuDTO>>(url) ?? new List<AsistenReuDTO>();
        }


        //TODO: CREAR METO EN NEOAPIMASTER

        public async Task<string> Postasistencia(List<AsistenReuDTO> asisten)
        {
                string mens = "";
                url = $"{BaseUrlLineas}/AddAsistencia";
                cliente = _clientFactory.CreateClient();
                mensaje = await cliente.PostAsJsonAsync(url, asisten);
                if (mensaje.IsSuccessStatusCode)
                {
                        mens = "Se añadido exitosamente";
                }
                return mens;
        }
        public async Task<string> AddEquipo(EquipoDTO equipo)
        {
                string mens = "";
                url = $"{BaseUrlMaestra}/AddEquipo";
                cliente = _clientFactory.CreateClient();
                mensaje = await cliente.PostAsJsonAsync(url, equipo);
                if (mensaje.IsSuccessStatusCode)
                {
                        mens = "Se añadido exitosamente";
                }
                return mens;
        }

        public async Task<List<ReuDiumDTO>> GetTrabajosCalendario(string pais, string centro, string division)
        {
                url = $"{BaseUrlMaestra}/GetTrabajosPorCalendario/{pais}/{centro}/{division}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<ReuDiumDTO>>(url) ?? new List<ReuDiumDTO>();
        }

        public async Task<List<EquipoEamDTO>> GetEquiposCentro(string idCentro)
        {
                url = $"{BaseUrlMaestra}/GetEquipos/{idCentro}";
                cliente = _clientFactory.CreateClient();
                return await cliente.GetFromJsonAsync<List<EquipoEamDTO>>(url) ?? new List<EquipoEamDTO>();
        }




        ////Version local**********************************************************************************************************************
        ////Conversion
        //public async Task GetEquiposEAM(string cent)
        //{
        //    var result = await _http.GetFromJsonAsync<List<EquipoEam>>($"http://localhost:5258/Lineas/Equipos/{cent}");
        //    if (result != null)
        //        equipos = result;

        //}
        //public async Task GetEquiposID(string cent)
        //{

        //    var result = await _http.GetFromJsonAsync<List<EquipoEam>>($"http://localhost:5258/Empresas/Equipos/{cent}");
        //    if (result != null)
        //        equipos = result;

        //}
        //public async Task GetEquiposxlinea(string linea)
        //{
        //    var result = await _http.GetFromJsonAsync<List<EquipoEam>>($"http://localhost:5258/Empresas/EquiposLinea/{linea}");
        //    if (result != null)
        //        equiposlinea = result;

        //}

        //public async Task GetCentros(string cent)
        //{
        //    var result = await _http.GetFromJsonAsync<List<Centro>>($"http://localhost:5258/Lineas/{cent}");
        //    if (result != null)
        //        centro = result;

        //}

        //public async Task GetCentrosxEmpresa(string cent)
        //{
        //    var result = await _http.GetFromJsonAsync<List<Centro>>($"http://localhost:5258/Empresas/Centros/{cent}");
        //    if (result != null)
        //        centro = result;

        //}
        //public async Task GetDivision(string centro, string div)
        //{
        //    var result = await _http.GetFromJsonAsync<List<Division>>($"http://localhost:5258/Lineas/Division/{centro}/{div}");
        //    if (result != null)
        //        divisions = result;

        //}
        //public async Task GetLineas(int div)
        //{
        //    var result = await _http.GetFromJsonAsync<List<Linea>>($"http://localhost:5258/Empresas/Lineas/{div}");
        //    if (result != null)
        //        lineas = result;

        //}
        //public async Task Getksf()
        //{
        //    var result = await _http.GetFromJsonAsync<List<Ksf>>($"http://localhost:5258/Lineas/Ksf");
        //    if (result != null)
        //        ksfs = result;

        //}
        //public async Task GetResReu()
        //{
        //    var result = await _http.GetFromJsonAsync<List<RespoReu>>($"http://localhost:5258/Lineas/Responsables");
        //    if (result != null)
        //        resporeu = result;

        //}





        //public async Task GetAsistencia(string div, string empresa)
        //{

        //    var result = await _http.GetFromJsonAsync<List<CargoReu>>($"http://localhost:5258/Lineas/Asistencia/{div}/{empresa}");
        //    if (result != null)
        //        cargoreus = result;

        //}
        //public async Task GetStatsAsist(string div, string empresa, string f1, string f2)
        //{


        //    var result = await _http.GetFromJsonAsync<List<StatsAsisDto>>($"http://localhost:5258/ReunionApi/Lineas/StatsAsis/{div}/{empresa}/{f1}/{f2}");
        //    // var result = await _http.GetFromJsonAsync<List<StatsAsisDto>>($"http://operaciones.papeleslatinos.com/ReunionApi/Lineas/StatsAsis/{div}/{f1}/{f2}");
        //    if (result != null)
        //        StatsAsisDtos = result;
        //}
        //public async Task GetListaAsist(string div, string empresa, string f1, string f2)
        //{

        //    var result = await _http.GetFromJsonAsync<List<AsistenReu>>($"http://localhost:5258/ReunionApi/Lineas/ListaAsis/{div}/{empresa}/{f1}/{f2}");
        //    if (result != null)
        //        asistenreus = result;
        //}




        //public async Task<string> Postasistencia(List<AsistenReu> asisten)
        //{

        //    var result = await _http.PostAsJsonAsync("http://localhost:5258/Lineas/Asistencia", asisten);
        //    var msj = await result.Content.ReadAsStringAsync();
        //    return msj;
        //}
        //public async Task<string> PostEquipo(EquipoDTO equipo)
        //{

        //    var result = await _http.PostAsJsonAsync("http://localhost:5258/Empresas/AddEquipo", equipo);
        //    var msj = await result.Content.ReadAsStringAsync();
        //    return msj;
        //}
}

