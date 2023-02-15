using Microsoft.AspNetCore.Mvc;
using ReunionWeb.DTOs;
using ReunionWeb.Models;
using ReunionWeb.NeoDbs;

namespace ReunionWeb.Services
{
    public interface IAPIDiv1Service
    {
        List<BdDiv1> dbDiv1s { get; set; }
        List<Asistencium> asistencia { get; set; }
        List<Centro> centro { get; set; }
        List<Division> divisions { get; set; }
        List<Ksf> ksfs { get; set; }
        List<RespoReu> resporeu { get; set; }
        List<ReunionDium> reunionditabla { get; set; }
        List<ReuDium> reudiatabla { get; set; }
        List<AsistenReu> asistenreus { get; set; }
        List<CargoReu> cargoreus { get; set; }
        List<StatsAsisDto> StatsAsisDtos { get; set; }
         List<EquipoEam> equipos { get; set; } 


        Task GetEquiposEAM(string centro);
        Task GetCentros(string centro);
        Task Getksf();
        Task GetResReu();
        Task GetDivision(string centro, string div);
        Task GetAsistencia( string div);
        Task GetStatsAsist( string div, string f1,string f2);

            
        Task GetPendientes(string div);
        Task<BdDiv1> GetDiscrepantacia(int id);
        Task<string> Postasistencia(List<AsistenReu> asisten);
        Task PostDiscrepancia(BdDiv1 bdDiv1);
        Task PutDiscrepancia(BdDiv1 bdDiv1, int tipo);
    }
}
