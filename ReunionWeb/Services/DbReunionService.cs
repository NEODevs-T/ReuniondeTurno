using Microsoft.AspNetCore.Components;
using ReunionWeb.NeoDbs;
using ReunionWeb.Controllers;
using Microsoft.EntityFrameworkCore;
using ReunionWeb.DTOs;
using System.Diagnostics.Metrics;
using Radzen.Blazor.Rendering;
using System.Linq.Dynamic.Core;
using System.Reflection.Metadata.Ecma335;
using ReunionWeb.ReunionDiaria.DTOs;




namespace ReunionWeb.Services
{
    public class DbReunionService : IDbReunionService
    {

        // **-------> CONEXION A LA API <--------**
        private readonly IHttpClientFactory _clientFactory;
        private const string BaseUrl = "http://neo.paveca.com.ve/apineomaster/api/DbReunionService";
        private HttpClient cliente { get; set; } = new HttpClient();
        private HttpResponseMessage? mensaje { get; set; } = new HttpResponseMessage();
        private string url { get; set; } = "";

        // **-------> CONEXION A LA API <--------**


        private readonly DbNeoContext _neocontext;
        private readonly NavigationManager _navigationManager;

        public DbReunionService(NavigationManager navigationManager, DbNeoContext _NeoContext)
        {
            _navigationManager = navigationManager;
            _neocontext = _NeoContext;
        }

        public async Task<List<ReuDiumDTO>> GetByODT(string ODT, string idcentro, string iddiv)
        {
            url = $"{BaseUrl}GetByODT/{ODT}/{idcentro}/{iddiv}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<ReuDiumDTO>>(url) ?? new List<ReuDiumDTO>();

        }

        //obtener discrepancias para pendientes y reunion 
        public async Task<List<ReuDiumDTO>> GetPendientes(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado)
        {
            url = $"{BaseUrl}GetPendientes/{idcentro}/{iddiv}/{f1}/{f2}/{tipo}/{estado}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<ReuDiumDTO>>(url) ?? new List<ReuDiumDTO>();

        }

        //historicos
        public async Task<List<ReuDiumDTO>> GetHistoricos(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado)
        {

            url = $"{BaseUrl}GetHistoricos/{idcentro}/{iddiv}/{f1}/{f2}/{tipo}/{estado}";
            cliente = _clientFactory.CreateClient();
            return await cliente.GetFromJsonAsync<List<ReuDiumDTO>>(url) ?? new List<ReuDiumDTO>();

        }

        //Update Discrepancia
        public async Task<bool> UpdateDiscrepancia(ReuDium d, int id, int tipo, string f1, string f2, string estado)
        {
            string div = "", centro = "";
            // DateTime f1= DateTime.Now;

            if (d.Rdcentro is not null)
            {
                //Consultar nombre del centro y division pra retornar el id en pendientes
                CentroDivision centrodiv = new CentroDivision();
                centrodiv = await GetCentroDiv(d.Rdcentro, d.Rddiv, 1);
                centro = centrodiv.IdCentro.ToString();
                div = centrodiv.IdDivision.ToString();

            }

            ReuDium bdDiscrep = new ReuDium();

            bdDiscrep = await _neocontext.ReuDia
                .Include(b => b.IdksfNavigation)
                .Include(b => b.IdResReuNavigation)
               .FirstOrDefaultAsync(sh => sh.IdReuDia == id);
            if (bdDiscrep == null)
                throw new Exception("Sorry, not found");


            bdDiscrep.Rdarea = d.Rdarea;
            bdDiscrep.Rddiv = d.Rddiv;
            bdDiscrep.RdcodDis = d.RdcodDis;
            bdDiscrep.RdcodEq = d.RdcodEq;
            bdDiscrep.Rddisc = d.Rddisc;
            bdDiscrep.Rdcentro = d.Rdcentro;
            bdDiscrep.RdfecReu = d.RdfecReu;
            bdDiscrep.RdfecTra = d.RdfecTra;
            bdDiscrep.Idksf = d.Idksf;
            bdDiscrep.RdplanAcc = d.RdplanAcc;
            bdDiscrep.Rdodt = d.Rdodt;
            bdDiscrep.IdResReu = d.IdResReu;
            bdDiscrep.Rdstatus = d.Rdstatus;
            bdDiscrep.Rdtiempo = d.Rdtiempo;
            bdDiscrep.IdPais = d.IdPais;
            bdDiscrep.IdEmpresa = d.IdEmpresa;
            //bdDiscrep.RdnumDis = d.RdnumDis;
            //bdDiscrep.Rdobs = d.Rdobs;

            try
            {
                _neocontext.Entry(bdDiscrep).State = EntityState.Modified;
                await _neocontext.SaveChangesAsync();
                reudiatablas = new List<ReuDium>();
                //bdDiscrep = null;

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

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }
        public async Task<bool> UpdateDiscrepancia2(ReuDium d, int id, int tipo, string f1, string f2, string estado, string linea)
        {
            string div = "", centro = "";
            bool check = false;
            // DateTime f1= DateTime.Now;

            if (d.Rdcentro is not null)
            {
                //Consultar nombre del centro y division pra retornar el id en pendientes
                CentroDivision centrodiv = new CentroDivision();
                centrodiv = await GetCentroDiv(d.Rdcentro, d.Rddiv, 1);
                centro = centrodiv.IdCentro.ToString();
                div = centrodiv.IdDivision.ToString();

            }


            try
            {

                _neocontext.ReuDia.Update(d);
                check = await _neocontext.SaveChangesAsync() > 0;
                //reudiatablas = new List<ReuDium>();
                ////bdDiscrep = null;

                if (check)
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

        //Obtener id de centro y dic=vision y viceversa

        public async Task<CentroDivision> GetCentroDiv(string centro, string division, int tipo)
        {
            CentroDivision CD = new CentroDivision();
            if (tipo == 0)
            {

                centrodiscrepancia = await _neocontext.Divisions
                    .Include(c => c.IdCentroNavigation)
                    .Where(d => d.IdDivision == int.Parse(division))
                    .Select(di => new Division
                    {
                        IdDivision = di.IdDivision,
                        Dnombre = di.Dnombre,
                        IdCentroNavigation = di.IdCentroNavigation
                    })
                    .AsNoTracking()
                    .FirstOrDefaultAsync();



                CD.IdCentro = centrodiscrepancia.IdCentroNavigation.IdCentro;
                CD.IdDivision = centrodiscrepancia.IdDivision;
                CD.Cnom = centrodiscrepancia.IdCentroNavigation.Cnom;
                CD.Dnombre = centrodiscrepancia.Dnombre;
            }

            else if (tipo == 1)
            {



                centrodiscrepancia = await _neocontext.Divisions
                    .Include(c => c.IdCentroNavigation)
                    .Where(d => d.Dnombre == division && d.IdCentroNavigation.Cnom == centro)
                    .Select(di => new Division
                    {
                        IdDivision = di.IdDivision,
                        Dnombre = di.Dnombre,
                        IdCentroNavigation = di.IdCentroNavigation
                    })
                    .AsNoTracking()
                    .FirstOrDefaultAsync();



                CD.IdCentro = centrodiscrepancia.IdCentroNavigation.IdCentro;
                CD.IdDivision = centrodiscrepancia.IdDivision;
                CD.Cnom = centrodiscrepancia.IdCentroNavigation.Cnom;
                CD.Dnombre = centrodiscrepancia.Dnombre;
            }


            return CD;
        }

        //Consultas para los cambios de estatus en una discrepancia
        public async Task GetCambioStatus(int idreu)
        {
            cambiostatus = await _neocontext.CambStats
                .Where(a => a.IdReuDia == idreu)
                // .OrderByDescending(b => b.IdCambStat)
                .ToListAsync();
        }

        public async Task GetCambioFecha(int idreu)
        {
            cambiofecha = await _neocontext.CambFecs
                .Where(a => a.IdReuDia == idreu)
                //.OrderByDescending(b => b.IdCambFec)
                .ToListAsync();
        }


        //obtener discrepancia a editar
        public async Task<ReuDium> GetDiscrepantacia(int id)
        {
            var disc = await _neocontext.ReuDia
                .Include(b => b.IdksfNavigation)
                .Include(b => b.IdResReuNavigation)
                .FirstOrDefaultAsync(h => h.IdReuDia == id);
            if (disc == null)
                throw new Exception("not found!");
            return disc;

        }


        public async Task<int> InsertDiscrepancia(ReuDium discre)
        {
            _neocontext.ReuDia.Add(discre);
            await _neocontext.SaveChangesAsync();
            return discre.IdReuDia;
        }


        public async Task InsertCambioStatus(CambStat status)
        {
            _neocontext.CambStats.Add(status);
            await _neocontext.SaveChangesAsync();
        }

        public async Task InsertCambioFec(CambFec cambiofec)
        {
            _neocontext.CambFecs.Add(cambiofec);
            await _neocontext.SaveChangesAsync();
        }
        //Insertar discrepancia con chismoso
        public async Task<bool> InsertarRegistros(CambFec data, CambStat data2)
        {
            data.IdReuDiaNavigation.CambStats.Add(data2);
            _neocontext.CambFecs.Add(data);
            //_neocontext.CambStats.Add(data2);
            await _neocontext.SaveChangesAsync();

            return true;
        }

    }
}
