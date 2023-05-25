using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.DTOs;

using ReunionWeb.NeoDbs;
using static System.Net.WebRequestMethods;

namespace ReunionWeb.Services
{
    public class APIReunionService : IAPIReunionService
    {

        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;


        public List<Centro> centro { get; set; } = new List<Centro>();
        public List<Ksf> ksfs { get; set; } = new List<Ksf>();
        public List<RespoReu> resporeu { get; set; } = new List<RespoReu>();
        public List<ReunionDium> reunionditabla { get; set; } = new List<ReunionDium>();
        public List<ReuDium> reudiatabla { get; set; } = new List<ReuDium>();
        public List<Division> divisions { get; set; } = new List<Division>();
        public List<Linea> lineas { get; set; } = new List<Linea>();
        public List<AsistenReu> asistenreus { get; set; } = new List<AsistenReu>();
        public List<CargoReu> cargoreus { get; set; } = new List<CargoReu>();
        public List<StatsAsisDto> StatsAsisDtos { get; set; } = new List<StatsAsisDto>();
        public List<EquipoEam> equipos { get; set; } = new List<EquipoEam>();
        public List<EquipoEam> equiposlinea { get; set; } = new List<EquipoEam>();
        public List<CalendarioTrabajoDTO> calentrabajo { get; set; } = new List<CalendarioTrabajoDTO>();

        public APIReunionService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        //Conversion
        public async Task GetEquiposEAM(string cent)
        {
            var result = await _http.GetFromJsonAsync<List<EquipoEam>>($"http://neo.paveca.com.ve/ReunionApi/Lineas/Equipos/{cent}");
            //var result = await _http.GetFromJsonAsync<List<EquipoEam>>($"http://localhost:5258/Lineas/Equipos/{cent}");
            if (result != null)
                equipos = result;

        }
        public async Task GetEquiposID(string cent)
        {
            var result = await _http.GetFromJsonAsync<List<EquipoEam>>($"http://neo.paveca.com.ve/ReunionApi/Empresas/Equipos/{cent}");
            //var result = await _http.GetFromJsonAsync<List<EquipoEam>>($"http://localhost:5258/Empresas/Equipos/{cent}");
            if (result != null)
                equipos = result;

        }
        public async Task GetEquiposxlinea(string linea)
        {
            var result = await _http.GetFromJsonAsync<List<EquipoEam>>($"http://neo.paveca.com.ve/ReunionApi/Empresas/EquiposLinea/{linea}");
            //var result = await _http.GetFromJsonAsync<List<EquipoEam>>($"http://localhost:5258/Empresas/EquiposLinea/{linea}");
            if (result != null)
                equiposlinea = result;

        }

        public async Task GetCentros(string cent)
        {
            var result = await _http.GetFromJsonAsync<List<Centro>>($"http://neo.paveca.com.ve/ReunionApi/Lineas/{cent}");
            // var result = await _http.GetFromJsonAsync<List<Centro>>($"http://localhost:5258/Lineas/{cent}");
            if (result != null)
                centro = result;

        }

        public async Task GetCentrosxEmpresa(string cent)
        {
            var result = await _http.GetFromJsonAsync<List<Centro>>($"http://neo.paveca.com.ve/ReunionApi/Empresas/Centros/{cent}");
            //var result = await _http.GetFromJsonAsync<List<Centro>>($"http://localhost:5258/Empresas/Centros/{cent}");
            if (result != null)
                centro = result;

        }
        public async Task GetDivision(string centro, string div)
        {
            var result = await _http.GetFromJsonAsync<List<Division>>($"http://neo.paveca.com.ve/ReunionApi/Lineas/Division/{centro}/{div}");
            //var result = await _http.GetFromJsonAsync<List<Division>>($"http://localhost:5258/Lineas/Division/{centro}/{div}");
            if (result != null)
                divisions = result;

        }
        public async Task GetLineas(int div)
        {
            var result = await _http.GetFromJsonAsync<List<Linea>>($"http://neo.paveca.com.ve/ReunionApi/Empresas/Lineas/{div}");
            //var result = await _http.GetFromJsonAsync<List<Linea>>($"http://localhost:5258/Empresas/Lineas/{div}");
            if (result != null)
                lineas = result;

        }
        public async Task Getksf()
        {
            var result = await _http.GetFromJsonAsync<List<Ksf>>($"http://neo.paveca.com.ve/ReunionApi/Lineas/Ksf");
            //var result = await _http.GetFromJsonAsync<List<Ksf>>($"http://localhost:5258/Lineas/Ksf");
            if (result != null)
                ksfs = result;

        }
        public async Task GetResReu()
        {
            var result = await _http.GetFromJsonAsync<List<RespoReu>>($"http://neo.paveca.com.ve/ReunionApi/Lineas/Responsables");
            //var result = await _http.GetFromJsonAsync<List<RespoReu>>($"http://localhost:5258/Lineas/Responsables");
            if (result != null)
                resporeu = result;

        }





        public async Task GetAsistencia(string div, string empresa)
        {
            var result = await _http.GetFromJsonAsync<List<CargoReu>>($"http://neo.paveca.com.ve/ReunionApi/Lineas/Asistencia/{div}/{empresa}");
            //var result = await _http.GetFromJsonAsync<List<CargoReu>>($"http://localhost:5258/Lineas/Asistencia/{div}/{empresa}");
            if (result != null)
                cargoreus = result;

        }
        public async Task GetStatsAsist(string div, string empresa, string f1, string f2)
        {

            //var result = await _http.GetFromJsonAsync<List<StatsAsisDto>>($"http://localhost:5258/Lineas/StatsAsis/{div}/{f1}/{f2}");
            var result = await _http.GetFromJsonAsync<List<StatsAsisDto>>($"http://neo.paveca.com.ve/ReunionApi/Lineas/StatsAsis/{div}/{empresa}/{f1}/{f2}");
            // var result = await _http.GetFromJsonAsync<List<StatsAsisDto>>($"http://operaciones.papeleslatinos.com/ReunionApi/Lineas/StatsAsis/{div}/{f1}/{f2}");
            if (result != null)
                StatsAsisDtos = result;
        }
        public async Task GetListaAsist(string div, string empresa, string f1, string f2)
        {

            //var result = await _http.GetFromJsonAsync<List<AsistenReu>>($"http://localhost:5258/Lineas/ListaAsis/{div}/{empresa}/{f1}/{f2}");
            var result = await _http.GetFromJsonAsync<List<AsistenReu>>($"http://neo.paveca.com.ve/ReunionApi/Lineas/ListaAsis/{div}/{empresa}/{f1}/{f2}");
            if (result != null)
                asistenreus = result;
        }




        public async Task<string> Postasistencia(List<AsistenReu> asisten)
        {
            var result = await _http.PostAsJsonAsync("http://neo.paveca.com.ve/ReunionApi/Lineas/Asistencia", asisten);
            //var result = await _http.PostAsJsonAsync("http://localhost:5258/Lineas/Asistencia", asisten);
            var msj = await result.Content.ReadAsStringAsync();
            return msj;
        }
        public async Task<string> PostEquipo(EquipoDTO equipo)
        {
            var result = await _http.PostAsJsonAsync("http://neo.paveca.com.ve/ReunionApi/Empresas/AddEquipo", equipo);
            //var result = await _http.PostAsJsonAsync("http://localhost:5258/Empresas/AddEquipo", equipo);
            var msj = await result.Content.ReadAsStringAsync();
            return msj;
        }

        public async Task GetTrabajosCalendario(string pais, string centro, string division)
        {
            //var result = await _http.GetFromJsonAsync<List<CalendarioTrabajoDTO>>($"http://localhost:5258/Lineas/Lineas/TrabajosCalendario/pais/{centro}/{division}");
            var result = await _http.GetFromJsonAsync<List<CalendarioTrabajoDTO>>($"http://neo.paveca.com.ve/ReunionApi/Lineas/TrabajosCalendario/{pais}/{centro}/{division}");
            if (result != null)
                calentrabajo = result;
        }
        
        public async Task GetEquiposCentro(string centro)
        {
            //var result = await _http.GetFromJsonAsync<List<CalendarioTrabajoDTO>>($"http://localhost:5258/Lineas/Lineas/TrabajosCalendario/pais/{centro}/{division}");
            var result = await _http.GetFromJsonAsync<List<EquipoEam>>($"http://neo.paveca.com.ve/ReunionApi/Empresas/Equipos/{centro}");
            if (result != null)
                equiposlinea = result;
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
}
