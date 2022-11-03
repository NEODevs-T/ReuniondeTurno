using ReunionWeb.Models;
using ReunionWeb.NeoDbs;

namespace ReunionWeb.Services
{
    public interface IAPIDiv1Service
    {
        List<BdDiv1> dbDiv1s { get; set; }
        List<Asistencium> asistencia { get; set; }
        List<Centro> centro { get; set; }

        Task GetCentros();


        Task GetPendientes(string div);
        Task<BdDiv1> GetDiscrepantacia(int id);
        Task Postasistencia(Asistencium asistencium);
        Task PostDiscrepancia(BdDiv1 bdDiv1);
        Task PutDiscrepancia(BdDiv1 bdDiv1, int tipo);
    }
}
