using ReunionWeb.Models;

namespace ReunionWeb.Services
{
    public interface IDbDiv1Service
    {

        List<BdDiv1> dbDiv1s { get; set; }
        List<Asistencium> asistencia { get; set; }

        Task GetPendientes(string div);
        Task<BdDiv1> GetDiscrepantacia(int id);
        Task Postasistencia(Asistencium asistencium);
        Task PostDiscrepancia(BdDiv1 bdDiv1);
        Task PutDiscrepancia(BdDiv1 bdDiv1, int tipo);

    }
}
