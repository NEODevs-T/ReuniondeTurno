using Microsoft.AspNetCore.Components;
using ReunionWeb.Models;
using ReunionWeb.NeoDbs;
using ReunionWeb.Controllers;
using Microsoft.EntityFrameworkCore;

namespace ReunionWeb.Services
{
    public class DbDiv1Service : IDbDiv1Service
    {

        public List<BdDiv1> dbDiv1s { get; set; } = new List<BdDiv1>();

        public BdDiv1 dbDiv { get; set; } = new BdDiv1();
        public List<Asistencium> asistencia { get; set; } = new List<Asistencium>();

        public List<Centro> centros { get; set; } = new List<Centro> { };
        public List<Linea> lineas { get; set; } = new List<Linea> { };
        public List<Empresa> empresas { get; set; } = new List<Empresa> { };
        public List<Pai> paiss { get; set; } = new List<Pai> { };
        public List<Division> divs { get; set; } = new List<Division> { };
        public List<Ksf> ksfss { get; set; } = new List<Ksf>();
        public List<RespoReu> resporeus { get; set; } = new List<RespoReu>();
        public List<ReunionDium> reunionditablas { get; set; } = new List<ReunionDium>();
        public List<ReuDium> reudiatablas { get; set; } = new List<ReuDium>();
        public List<Division> divisionss { get; set; } = new List<Division>();
        public List<AsistenReu> asistenreus { get; set; } = new List<AsistenReu>();
        public List<CargoReu> cargoreuss { get; set; } = new List<CargoReu>();
        public List<CambStat> cambiostatus { get; set; } = new List<CambStat>();
        public List<CambFec> cambiofecha { get; set; } = new List<CambFec>();
      





        private readonly DOC_IngIContext _context;
        private readonly DbNeoContext _neocontext;
        private readonly NavigationManager _navigationManager;

        public DbDiv1Service(DOC_IngIContext _IngIContext, NavigationManager navigationManager, DbNeoContext _NeoContext)
        {

            _navigationManager = navigationManager;
            _context = _IngIContext;
            _neocontext = _NeoContext;
        }
        //obtener discrepancias para pendientes y reunion 
        public async Task GetPendientes(string centro, string div, DateTime f1, DateTime f2, string tipo)
        {
            //tipo 0 Pendientes para 

            if (tipo == "1")
            {
                reudiatablas = await _neocontext.ReuDia
                //.Where(a =>  (a.Div == centro & a.Division==div ) | (a.Div == centro & a.Division == div & (a.Fecha>= f1 & a.Fecha <= f2)))
                .Where(a => (a.Rdcentro == centro & a.Rddiv == div & (a.Rdstatus!="Listo" & a.Rdstatus != "Cerrado")&& (a.RdfecReu >= f1 & a.RdfecReu <= f2)))
                .Include(b => b.IdksfNavigation)
                .Include(b => b.IdResReuNavigation)
                .OrderByDescending(b => b.RdfecReu)
                .ToListAsync();
            }
            else if (tipo == "0")
            {
                reudiatablas = await _neocontext.ReuDia
                //.Where(a =>  (a.Div == centro & a.Division==div ) | (a.Div == centro & a.Division == div & (a.Fecha>= f1 & a.Fecha <= f2)))
                .Where(a => (a.Rdcentro == centro & a.Rddiv == div & (a.RdfecTra >= f1 & a.RdfecTra <= f2)))
                .Include(b => b.IdksfNavigation)
                .Include(b => b.IdResReuNavigation)
                .OrderByDescending(b => b.RdfecReu)
                .ToListAsync();
            }else if (tipo == "2")
            {
                reudiatablas = await _neocontext.ReuDia
                .Where(a => (a.Rdcentro == centro & a.Rddiv == div & (a.RdfecReu >= f1 & a.RdfecReu <= f2)))
                .Include(b => b.IdksfNavigation)
                .Include(b => b.IdResReuNavigation)
                .OrderByDescending(b => b.RdfecReu)
                .ToListAsync();
            }

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



        public async Task Insertasistencia(Asistencium asistencium)
        {

            _context.Asistencia.Add(asistencium);
            await _context.SaveChangesAsync();
          

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
                _neocontext.CambFecs.Add(data);            
                _neocontext.CambStats.Add(data2);
            
            return await _neocontext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateDiscrepancia(ReuDium d, int id, int tipo, string f1, string f2)
        {
            string div = "", centro = "";
            // DateTime f1= DateTime.Now;

            if (d.Rdcentro is not null)
            {
                div = d.Rddiv;
                centro = d.Rdcentro;
                // f1 = d.Fecha;
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
            //bdDiscrep.IdPais = d.IdPais;
            //bdDiscrep.RdnumDis = d.RdnumDis;
            //bdDiscrep.Rdobs = d.Rdobs;

            try
            {
                _neocontext.Entry(bdDiscrep).State = EntityState.Modified;
                await _neocontext.SaveChangesAsync();
                //TODO pasar el tipo, para saber si bsco por fecha de trabajo o reunion
                
                if (tipo == 0)
                {
                    _navigationManager.NavigateTo($"pendientes/{centro}/{div}/{f1}/{f2}/{tipo}");
                }
                else if (tipo == 1)
                {
                    _navigationManager.NavigateTo($"reunion/{centro}/{div}/{f1}/{f2}/{tipo}");
                }else if (tipo == 2)
                {
                    _navigationManager.NavigateTo($"pendientes/{centro}/{div}/{f1}/{f2}/{tipo}");
                }
                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }


    }
}
