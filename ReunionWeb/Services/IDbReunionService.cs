using ReunionWeb.DTOs;
using ReunionWeb.DTOs.Maestra;
using ReunionWeb.NeoDbs;
using ReunionWeb.ReunionDiaria.DTOs;

namespace ReunionWeb.Services
{
    public interface IDbReunionService
    {


        List<CentrosVDTO> centros { get; set; }
        List<LineaVDTO> lineas { get; set; }
        List<EmpresasVDTO> empresas { get; set; }
        List<PaiDTO> paiss { get; set; }
        List<DivisionesVDTO> divs { get; set; }
        List<KsfDTO> ksfss { get; set;} 
        List<RespoReuDTO> resporeus { get; set; }
        List<ReuDiumDTO> reunionditablas { get; set; } 
        List<DivisionesVDTO> divisionss { get; set; }
        List<AsistenReuDTO> asistenreus { get; set; }
        List<CargoReuDTO> cargoreuss { get; set; }
        List<CambStatDTO> cambiostatus { get; set; }
        List<CambFecDTO> cambioFecha { get; set; }
        DivisionesVDTO centrodiscrepancia { get; set; }


        
        Task<List<ReuDiumDTO>> GetPendientes(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado);
        Task<List<ReuDiumDTO>> GetByODT(string ODT, string idcentro, string iddiv);
        Task<List<ReuDiumDTO>> GetHistoricos(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado);
        Task<List<CambStatDTO>> GetCambioStatus(int idreu);
        Task<List<CambFecDTO>> GetCambioFecha(int idreu);
        Task<ReuDiumDTO> GetDiscrepantacia(int id);
        Task<CentroDivisionDTO> GetCentroDiv(string centro, string division, int tipo);



        Task<int> InsertDiscrepancia(ReuDiumDTO discre);
        Task<bool> InsertCambioStatus(CambStatDTO status);//Insertar usuario que cambio el status
        Task<bool> InsertCambioFec(CambFecDTO cambiofec);//Insertar el usuarrio que cambio la fecha de trabajo.
        Task<bool> InsertarRegistros(RegistroCambiosDTO registroCambios);//Insertar discrepancias con chismoso(Trazabilidad)
        Task<bool> UpdateDiscrepancia(ReuDiumDTO d, int id, int tipo, string f1, string f2, string estado);
        Task<bool> UpdateDiscrepancia2(ReuDiumDTO bdDiv1, int id, int tipo, string f1, string f2, string estdo, string linea);


    }
}
