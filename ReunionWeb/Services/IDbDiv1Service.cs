using ReunionWeb.Models;
using ReunionWeb.NeoDbs;

namespace ReunionWeb.Services
{
    public interface IDbDiv1Service
    {

        List<BdDiv1> dbDiv1s { get; set; }
        List<Asistencium> asistencia { get; set; }


        List<Centro> centros { get; set; }
         List<Linea> lineas { get; set; }
         List<Empresa> empresas { get; set; }
         List<Pai> paiss { get; set; }
         List<Division> divs { get; set; }
         List<Ksf> ksfss { get; set; }
         List<RespoReu> resporeus { get; set; }
         List<ReunionDium> reunionditablas { get; set; }
         List<ReuDium> reudiatablas { get; set; }
         List<Division> divisionss { get; set; }
         List<AsistenReu> asistenreus { get; set; }
         List<CargoReu> cargoreuss { get; set; }

        Task GetPendientes(string centro, string div, DateTime f1, DateTime f2, string tipo);
        Task<ReuDium> GetDiscrepantacia(int id);
        //Task<ReunionDium> GetDiscrepantacia(int id);
        Task Insertasistencia(Asistencium asistencium);
       // Task Insertasistencia(Asistencium asistencium);
        Task InsertDiscrepancia(ReuDium discre);
        //Task InsertDiscrepancia(ReunionDium bdDiv1);
        Task UpdateDiscrepancia(ReuDium bdDiv1, int id, int tipo, string f1, string f2);
        //Task UpdateDiscrepancia(ReunionDium bdDiv1, int id, int tipo, string f1, string f2);

    }
}
