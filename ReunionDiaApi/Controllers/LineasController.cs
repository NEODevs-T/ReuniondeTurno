using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ReunionDiaApi.Models;

namespace ReunionDiaApi.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class LineasController : ControllerBase
    {


        private readonly DbNeoContext _context;

        public LineasController(DbNeoContext _DbNeo)
        {
            _context = _DbNeo;
        }
        public static List<Centro> centro = new List<Centro> { };
        public static List<Linea> linea = new List<Linea> { };
        public static List<Empresa> empresa = new List<Empresa> { };
        public static List<Pai> pais = new List<Pai> { };
        public static List<Division> div = new List<Division> { };

        [HttpGet]
        public async Task<ActionResult<List<Linea>>> GetBdDiv()
        {


            centro  = await _context.Centros
                .Include(x => x.Divisions)
                 .ThenInclude(post => post.Lineas)
                .ToListAsync();

            return Ok(centro);
        }

    }
}
