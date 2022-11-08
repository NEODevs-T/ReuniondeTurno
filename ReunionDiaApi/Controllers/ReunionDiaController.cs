using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReunionWeb.Models;

namespace ReunionDiaApi.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ReunionDiaController : ControllerBase
    {
 
            private readonly DOC_IngIContext _context;

            public ReunionDiaController(DOC_IngIContext _IngIContext)
            {
                _context = _IngIContext;
            }
            public static List<BdDiv1> bdDiv1s = new List<BdDiv1> { };
            public static List<Asistencium> asistencia = new List<Asistencium> { };



            //Api para obtener discrepancias pendientes.

            [HttpGet("{div}")]
            public async Task<ActionResult<List<BdDiv1>>> GetBdDiv1FechaHoy(string div)
            {


                string f1 = DateTime.Now.AddDays(-1).ToString("yyyMMdd");
                string f2 = DateTime.Now.ToString("yyyMMdd");

                var bddivs = await _context.BdDiv1s
                    .Where(a => a.Fecha2 == f1 && a.Div == div || a.Fecha2 == f2 && a.Div == div)
                    .OrderByDescending(b => b.Id)
                    .ToListAsync();

                return Ok(bddivs);
            }


            //Obtener los datos de la discrepancia a editar
            [HttpGet("discrepancia/{id}")]
            public async Task<ActionResult<List<BdDiv1>>> GetEditDiscrepancia(int id)
            {
                var bddivs = await _context.BdDiv1s
                    .FirstOrDefaultAsync(h => h.Id == id);

                if (bddivs == null)
                {
                    return NotFound("No se encontro registro");
                }
                return Ok(bddivs);
            }



            private async Task<List<BdDiv1>> GetDiscrencacias(string div)
            {

                string f1 = DateTime.Now.AddDays(-1).ToString("yyyMMdd");
                string f2 = DateTime.Now.ToString("yyyMMdd");
                return await _context.BdDiv1s
                 .Where(a => a.Fecha2 == f1 && a.Div == div || a.Fecha2 == f2 && a.Div == div)
                 .OrderByDescending(b => b.Id)
                  .ToListAsync();
            }


      
            [HttpPost("Discrep")]
            public async Task<ActionResult<List<BdDiv1>>> InsertDiscrepancia(BdDiv1 bdDiv1)
            {
                try
                {
                    _context.BdDiv1s.Add(bdDiv1);
                    await _context.SaveChangesAsync();
                    return Ok();
                }
                catch
                {
                    return BadRequest();
                }

            }





            [HttpPost("Asistencia")]
            public async Task<ActionResult<List<Asistencium>>> SaveAsistencia(Asistencium asistencium)

            {
                try
                {
                    _context.Asistencia.Add(asistencium);
                    await _context.SaveChangesAsync();
                    return Ok();
                }
                catch
                {
                    return BadRequest();
                }

            }






            private async Task<List<Asistencium>> GetDbAsistencia()
            {
                return await _context.Asistencia.ToListAsync();
            }


            [HttpPut("{id}")]
            public async Task<ActionResult<List<BdDiv1>>> UpdateDiscrepancia(BdDiv1 d, int id)
            {
                string div = d.Div;

                var bdDivform = await _context.BdDiv1s
                    .FirstOrDefaultAsync(sh => sh.Id == id);
                if (bdDivform == null)
                    return NotFound("Sorry, not found");

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

                return Ok(await GetDiscrencacias(div));
            }
        }
}
