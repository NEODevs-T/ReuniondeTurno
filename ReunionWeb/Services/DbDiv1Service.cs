using Microsoft.AspNetCore.Components;
using ReunionWeb.Models;
using ReunionWeb.NeoDbs;
using ReunionWeb.Controllers;
using Microsoft.EntityFrameworkCore;

namespace ReunionWeb.Services
{
    public class DbDiv1Service:IDbDiv1Service
    {
 
        public List<BdDiv1> dbDiv1s { get; set; } = new List<BdDiv1>();

        public BdDiv1 dbDiv { get; set; } = new BdDiv1();
        public List<Asistencium> asistencia { get; set; } = new List<Asistencium>();
        
        public  List<Centro> centros { get; set; } = new List<Centro> { };
        public  List<Linea> lineas { get; set; } = new List<Linea> { };
        public  List<Empresa> empresas { get; set; } = new List<Empresa> { };
        public  List<Pai> paiss { get; set; } = new List<Pai> { };
        public  List<Division> divs { get; set; } = new List<Division> { };
        public  List<Ksf> ksfss { get; set; } = new List<Ksf>();
        public  List<RespoReu> resporeus { get; set; } = new List<RespoReu>();
        public  List<ReunionDium> reunionditablas { get; set; } = new List<ReunionDium>();
        public  List<Division> divisionss { get; set; } = new List<Division>();
        public  List<AsistenReu> asistenreus { get; set; } = new List<AsistenReu>();
        public  List<CargoReu> cargoreuss { get; set; } = new List<CargoReu>();





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
        public async Task GetPendientes(string centro, string div, DateTime f1, DateTime f2)
        {
            //f1 = DateTime.Now.AddDays(-1).ToString("yyyMMdd");
            //f2 = DateTime.Now.ToString("yyyMMdd"); a.Fecha >= f1 & a.Fecha <= f2 &

            reunionditablas = await _neocontext.ReunionDia
                //.Where(a =>  (a.Div == centro & a.Division==div ) | (a.Div == centro & a.Division == div & (a.Fecha>= f1 & a.Fecha <= f2)))
                .Where(a =>   (a.Div == centro & a.Division == div & (a.Fecha>= f1 & a.Fecha <= f2)))
                .OrderByDescending(b => b.Fecha)
                .ToListAsync();

            int d = 6;
        }
        //obtener discrepancia a editar
        public async Task<ReunionDium> GetDiscrepantacia(int id)
        {
            var div1 = await _neocontext.ReunionDia
             .FirstOrDefaultAsync(h => h.Id == id);
           if(div1 == null)
            throw new Exception("not found!");
            return div1;

        }

      

        public async Task Insertasistencia(Asistencium asistencium)
        {

            _context.Asistencia.Add(asistencium);
            await _context.SaveChangesAsync();

        }


        public async Task InsertDiscrepancia(ReunionDium bdDiv1)
        {
            _neocontext.ReunionDia.Add(bdDiv1);
                await _neocontext.SaveChangesAsync();            
        }

        public async Task UpdateDiscrepancia(ReunionDium d,int id, int tipo, string f1, string f2)
        {
            string div="", centro="";
           // DateTime f1= DateTime.Now;
            
            if (d.Div is not null)
            {
                div = d.Division;
                centro = d.Div;
               // f1 = d.Fecha;
            }
               
            ReunionDium bdDivform = new ReunionDium();

             bdDivform = await _neocontext.ReunionDia
                .FirstOrDefaultAsync(sh => sh.Id == id);
            if (bdDivform == null)
                throw new Exception("Sorry, not found");
          

            bdDivform.Area = d.Area;
            bdDivform.Division = d.Division;
            bdDivform.Codigo = d.Codigo;
            bdDivform.CodigoEquipo = d.CodigoEquipo;
            bdDivform.Discrepancia = d.Discrepancia;
            bdDivform.Div = d.Div;
            bdDivform.Fecha = d.Fecha;
            bdDivform.Fecha2 = d.Fecha.ToString("yyyyMMdd");
            bdDivform.FechaTrab = d.FechaTrab;
            bdDivform.FechaTrab1 = d.FechaTrab.ToString("yyyyMMdd");
            bdDivform.Id = d.Id;
            bdDivform.AfectadoKsf = d.AfectadoKsf;
            bdDivform.PlanDeAccion = d.PlanDeAccion;
            
            if (bdDivform.FechaTrab> DateTime.Now && bdDivform.Div =="Planta de Chempro")
            {
                bdDivform.OrdenTrabajo = d.Id.ToString();
            }
            else
            {
                bdDivform.OrdenTrabajo = d.OrdenTrabajo;
            }
           
            bdDivform.Responsable = d.Responsable;
            bdDivform.Status = d.Status;
            bdDivform.Tiempo = d.Tiempo;
           
            _neocontext.Entry(bdDivform).State = EntityState.Modified;           
             await _neocontext.SaveChangesAsync();


                if (tipo == 0)
                {
                    _navigationManager.NavigateTo($"pendientes/{centro}/{div}/{f1}/{f2}");
                }
                else
                {
                    _navigationManager.NavigateTo($"reunion/{centro}/{div}/{f1}/{f2}");
                }
            

        }
 

    }
}
