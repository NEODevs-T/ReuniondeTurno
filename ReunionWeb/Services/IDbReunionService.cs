using NeoAPI.DTOs.ReunionDiaria;
using ReunionWeb.DTOs;
using ReunionWeb.NeoDbs;
using ReunionWeb.ReunionDiaria.DTOs;

namespace ReunionWeb.Services
{
    public interface IDbReunionService
    {


        // List<Centro> centros { get; set; }
        //  List<Linea> lineas { get; set; }
        //  List<Empresa> empresas { get; set; }
        //  List<Pai> paiss { get; set; }
        //  List<Division> divs { get; set; }
        //  List<Ksf> ksfss { get; set; }
        //  List<RespoReu> resporeus { get; set; }
        //  List<ReunionDium> reunionditablas { get; set; }
        //  List<ReuDium> reudiatablas { get; set; }
        //  List<Division> divisionss { get; set; }
        //  List<AsistenReu> asistenreus { get; set; }
        //  List<CargoReu> cargoreuss { get; set; }
        //  List<CambStat> cambiostatus { get; set; }
        //  List<CambFec> cambiofecha { get; set; }
        //  Division centrodiscrepancia { get; set; }

        
        Task<List<ReuDiumDTO>> GetPendientes(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado);
        Task<List<ReuDiumDTO>> GetByODT(string ODT, string idcentro, string iddiv);
        Task<List<ReuDiumDTO>> GetHistoricos(string idcentro, string iddiv, DateTime f1, DateTime f2, string tipo, string estado);
        Task<List<CambStatDTO>> GetCambioStatus(int idreu);
        Task<List<CambFecDTO>> GetCambioFecha(int idreu);
        Task<List<ReuDiumDTO>> GetDiscrepantacia(int id);
        Task<List<CentroDivisionDTO>> GetCentroDiv(string centro, string division, int tipo);



        Task<int> InsertDiscrepancia(ReuDium discre);
        Task<bool> InsertCambioStatus(CambStat status);//Insertar usuario que cambio el status
        Task<bool> InsertCambioFec(CambFec cambiofec);//Insertar el usuarrio que cambio la fecha de trabajo.
        Task<bool> InsertarRegistros(RegistroCambiosDTO registroCambios);//Insertar discrepancias con chismoso(Trazabilidad)
        Task<bool> UpdateDiscrepancia(ReuDium d, int id, int tipo, string f1, string f2, string estado);
        Task<bool> UpdateDiscrepancia2(ReuDium bdDiv1, int id, int tipo, string f1, string f2, string estdo, string linea);


    }
}
