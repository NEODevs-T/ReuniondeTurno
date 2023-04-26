using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ReunionDiaApi.Models;
using ReunionDiaApi.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace ReunionDiaApi.Controllers
{
    [AllowAnonymous]
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
        public static List<EquipoEam> equiposlinea = new List<EquipoEam>();
        public static EquipoDTO equipoinsertar = new EquipoDTO();



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
           .Where(x => (x.IdPais == int.Parse(idpais)) & (x.Eestado == true))
           .ToListAsync();

            return Ok(empresa);
        }

        //Obtener lista de centros y divisiones x empresa o centro
        [HttpGet("Centros/{cent}")]
        public async Task<ActionResult<List<Centro>>> GetCentros(string cent)
        {
            string cen = "";
            int idempresa = 0;

            if (cent.Length > 3)
            {
                cen = cent.Substring(0, 3);
                idempresa = int.Parse(cent.Substring(3));
            }
;
            if (cen == "All")
            {
                centro = await _context.Centros
               .Include(x => x.Divisions)
               .ThenInclude(post => post.Lineas) // TO DO: eliminar en el codigo
               .Where(c => c.IdEmpresaNavigation.IdEmpresa == idempresa)
               .ToListAsync();
            }

            else
            {
                int centroid = int.Parse(cent);

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
           .Where(x => (x.IdDivision == int.Parse(division)) & x.Lestado == true)
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
                 .Where(x => x.IdLineaNavigation.IdDivisionNavigation.IdCentro == idcentro && x.EestaEam == true)
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

        [HttpGet("EquiposLinea/{linea}")]
        public async Task<ActionResult<List<EquipoEam>>> EquiposEAMxLinea(string linea)
        {

            int idlinea = int.Parse(linea);



            var result = await _context.EquipoEams
             .Include(x => x.IdLineaNavigation)
             .Include(x => x.IdLineaNavigation.IdDivisionNavigation)
             .Include(x => x.IdLineaNavigation.IdDivisionNavigation.IdCentroNavigation)
             .Where(x => x.IdLineaNavigation.IdLinea == idlinea)
             .AsNoTracking()
              .ToListAsync();

            return Ok(result);
        }





        [HttpGet("Lineas/{div}")]
        public async Task<ActionResult<List<Empresa>>> LineasDiv(string div)
        {

            linea = await _context.Lineas
            .Where(x => (x.IdCentro == int.Parse(div) & x.Lestado == true))
            .ToListAsync();


            return Ok(linea);
        }

        [HttpPost("AddEquipo")]
        public async Task<ActionResult<string>> AddEquipo(EquipoDTO equipo)
        {
            if (equipo.IdEquipo == 0)
            {
                try
                {
                    var result = await _context.EquipoEams
                    .Where(x => x.EcodEquiEam == equipo.EcodEquiEam && x.IdLinea == equipo.IdLinea)
                    .AsNoTracking()
                    .FirstOrDefaultAsync();

                    if (result == null)
                    {
                        EquipoEam e = new EquipoEam();

                        e.IdLinea = equipo.IdLinea;
                        e.EcodEquiEam = equipo.EcodEquiEam;
                        e.EdescriEam = equipo.EdescriEam;
                        e.EestaEam = equipo.EestaEam;
                        e.EnombreEam = equipo.EnombreEam;

                        _context.EquipoEams.Add(e);
                        await _context.SaveChangesAsync();

                        return Ok("Registro Exitoso");
                    }
                    else
                    {
                        return BadRequest("Ya se registró este código de equipo.");
                    }

                }
                catch
                {
                    return BadRequest("Error, intente nuevamente");
                }
            }
            else
            {
                try
                {
                    EquipoEam eq = new EquipoEam();
                    eq.IdEquipo = equipo.IdEquipo;
                    eq.IdLinea = equipo.IdLinea;
                    eq.EcodEquiEam = equipo.EcodEquiEam;
                    eq.EdescriEam = equipo.EdescriEam;
                    eq.EestaEam = equipo.EestaEam;
                    eq.EnombreEam = equipo.EnombreEam;

                    return await UpdateEquipo(eq);
                    //return Ok("");
                  
                }
                catch
                {
                    return BadRequest("Error, intente nuevamente");
                        
                }
            }

        }

        [HttpPost("UpdateEquipo")]
        public async Task<string> UpdateEquipo(EquipoEam equipo)
        {
            try
            {
                //No se porque pero asi funciona, no mover 
                EquipoEam eq = new EquipoEam();
                eq = equipo;

                _context.Entry(eq).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return "Registro Exitoso";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }





    }
}

