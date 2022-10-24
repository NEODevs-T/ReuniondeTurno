using Microsoft.AspNetCore.Components;
using ReunionWeb.Models;
using ReunionWeb.Controllers;
using Microsoft.EntityFrameworkCore;

namespace ReunionWeb.Services
{
    public class DbDiv1Service:IDbDiv1Service
    {
 
        public List<BdDiv1> dbDiv1s { get; set; } = new List<BdDiv1>();

        public BdDiv1 dbDiv { get; set; } = new BdDiv1();
        public List<Asistencium> asistencia { get; set; } = new List<Asistencium>();
        private readonly DOC_IngIContext _context; 
        private readonly NavigationManager _navigationManager;

        public DbDiv1Service(DOC_IngIContext _IngIContext, NavigationManager navigationManager)
        {

            _navigationManager = navigationManager;
            _context = _IngIContext;
        }
        //obtener discrepancias para pendientes y reunion 
        public async Task GetPendientes(string div)
        {

            string f1 = DateTime.Now.AddDays(-1).ToString("yyyMMdd");
            string f2 = DateTime.Now.ToString("yyyMMdd");

            dbDiv1s = await _context.BdDiv1s
                .Where(a => a.Fecha2 == f1 && a.Div == div || a.Fecha2 == f2 && a.Div == div)
                .OrderByDescending(b => b.Id)
                .ToListAsync();


        }
        //obtener discrepancia a editar
        public async Task<BdDiv1> GetDiscrepantacia(int id)
        {
            var div1 = await _context.BdDiv1s
             .FirstOrDefaultAsync(h => h.Id == id);
           if(div1 == null)
            throw new Exception("not found!");
            return div1;

        }

        public async Task SetDiscrepancias(string div)
        {

            string f1 = DateTime.Now.AddDays(-1).ToString("yyyMMdd");
            string f2 = DateTime.Now.ToString("yyyMMdd");

            dbDiv1s = await _context.BdDiv1s
                .Where(a => a.Fecha2 == f1 && a.Div == div || a.Fecha2 == f2 && a.Div == div)
                .OrderByDescending(b => b.Id)
                .ToListAsync();

        }
        public async Task Insertasistencia(Asistencium asistencium)
        {

            _context.Asistencia.Add(asistencium);
            await _context.SaveChangesAsync();

        }


        public async Task InsertDiscrepancia(BdDiv1 bdDiv1)
        {
                _context.BdDiv1s.Add(bdDiv1);
                await _context.SaveChangesAsync();            
        }

        public async Task UpdateDiscrepancia(BdDiv1 d,int id, int tipo)
        {
            string div="";

            if (d.Div is not null)
            {
                div = d.Div;
            }
               

            var bdDivform = await _context.BdDiv1s
                .FirstOrDefaultAsync(sh => sh.Id == id);
            if (bdDivform == null)
                throw new Exception("Sorry, not found");
          

            bdDivform.Area = d.Area;
            bdDivform.Codigo = d.Codigo;
            bdDivform.CodigoEquipo = d.CodigoEquipo;
            bdDivform.Discrepancia = d.Discrepancia;
            bdDivform.Div = d.Div;
            bdDivform.Fecha = d.Fecha;
            bdDivform.Fecha2 = d.Fecha2;
            bdDivform.FechaTrab = d.FechaTrab;
            bdDivform.FechaTrab1 = d.FechaTrab1;
            bdDivform.Id = d.Id;
            bdDivform.Ksf = d.Ksf;
            bdDivform.PlanDeAccion = d.PlanDeAccion;
            bdDivform.Ps = d.Ps;
            bdDivform.Responsable = d.Responsable;
            bdDivform.Status = d.Status;
            bdDivform.Tiempo = d.Tiempo;

            await _context.SaveChangesAsync();  
            
           
            if (tipo == 0)
            {
                _navigationManager.NavigateTo($"pendientes/{div}");
            }
            else
            {
                _navigationManager.NavigateTo($"reunion/{div}");
            }

        }
 

    }
}
