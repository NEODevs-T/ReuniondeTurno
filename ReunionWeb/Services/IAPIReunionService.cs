using Microsoft.AspNetCore.Mvc;
using ReunionWeb.ReunionDiaria.DTOs;
using ReunionWeb.DTOs.Maestra;
using ReunionWeb.NeoDbs;

namespace ReunionWeb.Services
{
    public interface IAPIReunionService
    {

        // List<Centro> centro { get; set; }
        // List<Linea> lineas { get; set; }
        // List<Division> divisions { get; set; }
        // List<Ksf> ksfs { get; set; }
        // List<RespoReu> resporeu { get; set; }
        // List<ReunionDium> reunionditabla { get; set; }
        // List<ReuDium> reudiatabla { get; set; }
        // List<AsistenReu> asistenreus { get; set; }
        // List<CargoReu> cargoreus { get; set; }
        // List<StatsAsisDto> StatsAsisDtos { get; set; }
        // List<EquipoEam> equipos { get; set; }
        // List<EquipoEam> equiposlinea { get; set; }
        // List<CalendarioTrabajoDTO> calentrabajo { get; set; }

        Task<List<EquipoEamDTO>> GetEquiposEAM(string cent);
        Task<List<EquipoEamDTO>> GetEquiposID(string idCentro);
        Task<List<EquipoEamDTO>> GetEquiposxlinea(string idLinea);
        Task<List<LineaDTO>> GetBdDiv(string cent);
        Task<List<CentrosVDTO>> GetCentrosxEmpresa(string cent);
        Task<List<LineaVDTO>> GetLineas(int idDivision);
        Task<List<KsfDTO>> Getksf();
        Task<List<RespoReuDTO>> GetResReu();
        Task<List<CargoReuDTO>> GetAsistencia(string div, string empresa);
        Task<List<AsistenReuDTO>> GetStatsAsist(string div, string empresa, string f1, string f2);
        Task<List<AsistenReuDTO>> GetListaAsist(string div, string empresa, string f1, string f2);
        Task<string> Postasistencia(List<AsistenReuDTO> asisten);
        Task<string> AddEquipo(EquipoDTO equipo);
        Task<List<ReuDiumDTO>> GetTrabajosCalendario(string pais, string centro, string division);
        Task<List<EquipoEamDTO>> GetEquiposCentro(string idCentro);

    }
}
