using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ReunionDiaApi.Models;
using ReunionDiaApi.DTOs;

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


         [HttpPost("Auth")]
        public async Task<ActionResult<string>> Loging(UserLoginDto request)
        {
            string token = @"eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiSmF2aWVyIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiQWRtaW4iLCJleHAiOjE2NjgxMTAyMTd9.nD4Q3GA5pxhm3i8M7o_st7RstoKEEayJCTpJP6flJkb3iyBusGu18bEbfJORhRO5OVWM6JxajysSCDYrisXztA";
        return token;
        }

    }
}
