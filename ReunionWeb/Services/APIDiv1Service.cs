using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ReunionWeb.DTOs;
using ReunionWeb.Models;
using ReunionWeb.NeoDbs;

namespace ReunionWeb.Services
{
    public class APIDiv1Service : IAPIDiv1Service
    {

        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public List<BdDiv1> dbDiv1s { get; set; } = new List<BdDiv1>();

        public BdDiv1 dbDiv { get; set; } = new BdDiv1();
        public List<Asistencium> asistencia { get; set; } = new List<Asistencium>();
        public List<Centro> centro { get; set; } = new List<Centro>();
        public List<Ksf> ksfs { get; set; } = new List<Ksf>();
        public List<RespoReu> resporeu { get; set; } = new List<RespoReu>();
        public List<ReunionDium> reunionditabla { get; set; } = new List<ReunionDium>();
        public List<ReuDium> reudiatabla { get; set; } = new List<ReuDium>();
        public List<Division> divisions { get; set; } = new List<Division>();
        public List<AsistenReu> asistenreus { get; set; } = new List<AsistenReu>();
        public List<CargoReu> cargoreus { get; set; } = new List<CargoReu>();
        public List<StatsAsisDto> StatsAsisDtos { get; set; } = new List<StatsAsisDto>();
        public List<EquipoEam> equipos { get; set; } = new List<EquipoEam>();

        public APIDiv1Service(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        //Conversion
        public async Task GetEquiposEAM(string cent)
        {
            var result = await _http.GetFromJsonAsync<List<EquipoEam>>($"http://operaciones.papeleslatinos.com/ReunionApi/Lineas/Equipos/{cent}");
            //var result = await _http.GetFromJsonAsync<List<EquipoEam>>($"http://localhost:5258/Lineas/Equipos/{cent}");
            if (result != null)
                equipos = result;

        }

        public async Task GetCentros(string cent)
        {
            var result = await _http.GetFromJsonAsync<List<Centro>>($"http://operaciones.papeleslatinos.com/ReunionApi/Lineas/{cent}");
            //var result = await _http.GetFromJsonAsync<List<Centro>>($"http://localhost:5258/Lineas/{cent}");
            if (result != null)
                centro = result;

        }
        public async Task GetDivision(string centro, string div)
        {
            var result = await _http.GetFromJsonAsync<List<Division>>($"http://operaciones.papeleslatinos.com/ReunionApi/Lineas/Division/{centro}/{div}");
            if (result != null)
                divisions = result;

        }
        public async Task Getksf()
        {
            var result = await _http.GetFromJsonAsync<List<Ksf>>($"http://operaciones.papeleslatinos.com/ReunionApi/Lineas/Ksf");
            if (result != null)
                ksfs = result;

        }
        public async Task GetResReu()
        {
            var result = await _http.GetFromJsonAsync<List<RespoReu>>($"http://operaciones.papeleslatinos.com/ReunionApi/Lineas/Responsables");
            if (result != null)
                resporeu = result;

        }


        public async Task GetPendientes(string div)
        {
            var result = await _http.GetFromJsonAsync<List<BdDiv1>>($"api/ReunionDia/{div}");
            if (result != null)
                dbDiv1s = result;

        }

        public async Task<BdDiv1> GetDiscrepantacia(int id)
        {
            var result = await _http.GetFromJsonAsync<BdDiv1>($"api/ReunionDia/discrepancia/{id}");
            if (result != null)
                //dbDiv = result;
                return result;
            throw new Exception("Hero not found!");

        }


        public async Task GetAsistencia(string div)
        {
            var result = await _http.GetFromJsonAsync<List<CargoReu>>($"http://operaciones.papeleslatinos.com/ReunionApi/Lineas/Asistencia/{div}");
            if (result != null)
                cargoreus = result;

        }
        public async Task GetStatsAsist(string div,string f1, string f2)
        {

            //var result = await _http.GetFromJsonAsync<List<StatsAsisDto>>($"http://localhost:5258/Lineas/StatsAsis/{div}/{f1}/{f2}");
            var result = await _http.GetFromJsonAsync<List<StatsAsisDto>>($"http://operaciones.papeleslatinos.com/ReunionApi/Lineas/StatsAsis/{div}/{f1}/{f2}");
            if (result != null)
                StatsAsisDtos = result;
        }




        public async Task PostDiscrepancia(BdDiv1 bdDiv1)
        {
            var result = await _http.PostAsJsonAsync("http://operaciones.papeleslatinos.com/ReunionApi/ReunionDia/Discrep", bdDiv1);
            // var result = await _http.PostAsJsonAsync("api/ReunionDia/Discrep", bdDiv1);
            // await SetAsistencia(result);
        }

        public async Task PutDiscrepancia(BdDiv1 bdDiv1, int tipo)
        {
            var result = await _http.PutAsJsonAsync($"api/ReunionDia/{bdDiv1.Id}", bdDiv1);
            if (tipo == 0)
            {
                await SetPendientes(result);
            }
            else
            {
                await SetReunion(result);
            }

        }
        private async Task SetPendientes(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<BdDiv1>>();

            dbDiv1s = response;
            int tipo = 0;
            _navigationManager.NavigateTo($"pendientes/{tipo}");

        }
        private async Task SetReunion(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<BdDiv1>>();

            dbDiv1s = response;

            _navigationManager.NavigateTo($"reunion/1");

        }

        public async Task<string> Postasistencia(List<AsistenReu> asisten)
        {
            var result = await _http.PostAsJsonAsync("http://operaciones.papeleslatinos.com/ReunionApi/Lineas/Asistencia", asisten);
            //var result = await _http.PostAsJsonAsync("http://localhost:5258/Lineas/Asistencia", asisten);
            var msj=await result.Content.ReadAsStringAsync();
            return msj;
        }
    }
}
