using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ReunionDiaApi.Models;
using ReunionDiaApi.DTOs;

namespace ReunionDiaApi.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {
    





        private readonly DbNeoContext _context;

        public EmpresasController(DbNeoContext _DbNeo)
        {
            _context = _DbNeo;
        }
        public static List<Centro> centro = new List<Centro> { };
        public static List<Linea> linea = new List<Linea> { };
        public static List<Empresa> empresa = new List<Empresa> { };
        public static List<Pai> pais = new List<Pai> { };
        public static List<Division> div = new List<Division> { };
        public static List<Ksf> ksfs = new List<Ksf>();
        public static List<RespoReu> resporeu = new List<RespoReu>();
        public static List<ReunionDium> reunionditabla = new List<ReunionDium>();
        public static List<Division> divisions = new List<Division>();
        public static List<AsistenReu> asistenreus = new List<AsistenReu>();
        public static List<CargoReu> cargoreus = new List<CargoReu>();
        public static List<StatsAsisDto> StatsAsis = new List<StatsAsisDto>();
        public static List<EquipoEam> equipos = new List<EquipoEam>();



        //Obtener Paises 
        [HttpGet("Paises")]
        public async Task<ActionResult<List<Pai>>> GetPais()
        {

            pais = await _context.Pais
           .Where(x => x.Pestado == true)
           .ToListAsync();

            return Ok(pais);
        }


        //Obtener emppresa x pais 
        [HttpGet("Empresa/{idpais}")]
        public async Task<ActionResult<List<Empresa>>> GetEmpresas(string idpais)
        {

            empresa = await _context.Empresas
           .Where(x => (x.IdPais == int.Parse(idpais)) & (x.Eestado==true))
           .ToListAsync();

            return Ok(empresa);
        }

        //Obtener lista de centros y divisiones x empresa o centro
        [HttpGet("Centros/{cent}")]
        public async Task<ActionResult<List<Centro>>> GetCentros(string cent)
        {
            string cen="";
            int idempresa=0;

            if (cent.Length > 3)
            {
                cen = cent.Substring(0, 3);
                idempresa = int.Parse(cent.Substring(3));
            }
;
            if (cen== "All")
            {
                centro = await _context.Centros
               .Include(x => x.Divisions)
               .ThenInclude(post => post.Lineas) // TO DO: eliminar en el codigo
               .Where(c=>c.IdEmpresaNavigation.IdEmpresa==idempresa)              
               .ToListAsync();
            }

            else
            {
                int centroid=int.Parse(cent);

                centro = await _context.Centros
               .Include(x => x.Divisions)
               .ThenInclude(post => post.Lineas)// TO DO: eliminar en el codigo
               .Where(x => x.IdCentro == centroid)
               .ToListAsync();
            }


            return Ok(centro);
        }
        //Obtener Lineas 
        [HttpGet("Lineas/{cent}")]
        public async Task<ActionResult<List<Linea>>> GetLineas(string division)
        {

                linea = await _context.Lineas             
               .Where(x => (x.IdDivision == int.Parse(division))& x.Lestado==true)
               .ToListAsync();

            return Ok(linea);
        }


        //Obtener Equipos
        [HttpGet("Equipos/{cent}")]
        public async Task<ActionResult<List<EquipoEam>>> EquiposEAM(string cent)
        {

            int idcentro = int.Parse(cent);

            if (cent == "All")
            {
                var result = await _context.EquipoEams
                 .Include(x => x.IdLineaNavigation)
                 .Where(x => x.EestaEam == true)
                 .Select(p => new
                 {
                     p.EcodEquiEam,
                     p.EnombreEam,
                     p.IdLineaNavigation
                 })
                 .AsNoTracking()
                  .ToListAsync();

                return Ok(result);
            }
            else
            {


                var result = await _context.EquipoEams
                 .Include(x => x.IdLineaNavigation)
                 .Where(x => x.IdLineaNavigation.IdDivisionNavigation.IdCentro== idcentro && x.EestaEam == true)
                 .Select(p => new
                 {
                     p.EcodEquiEam,
                     p.EnombreEam,
                     p.IdLineaNavigation
                 })
                 .AsNoTracking()
                  .ToListAsync();

                return Ok(result);
            }


        }




        [HttpGet("Lineas/{div}")]
        public async Task<ActionResult<List<Empresa>>> LineasDiv(string div)
        {

            linea = await _context.Lineas
            .Where(x =>( x.IdCentro==int.Parse(div) & x.Lestado==true))
            .ToListAsync();


            return Ok(linea);
        }


        [HttpGet("EquiposLinea/{Centro}")]
        public async Task<ActionResult<List<Empresa>>> EquiposLineaEAM(string Centro)
        {

            empresa = await _context.Empresas
            .Include(x => x.IdPaisNavigation)
            .Include(y => y.Centros)
            .Where(x => x.Centros.First(i => i.Cnom == Centro).IdEmpresa == x.IdEmpresa)
            .ToListAsync();


            return Ok(empresa);
        }



    }
}

