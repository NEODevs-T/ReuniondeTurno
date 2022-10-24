using ReunionWeb.Models;

namespace ReunionWeb.Services
{
    public interface IDbDiv1Service
    {

        List<BdDiv1> dbDiv1s { get; set; }
        List<Asistencium> asistencia { get; set; }

        Task GetPendientes(string div);
        Task<BdDiv1> GetDiscrepantacia(int id);
        Task Insertasistencia(Asistencium asistencium);
        Task InsertDiscrepancia(BdDiv1 bdDiv1);
        Task UpdateDiscrepancia(BdDiv1 bdDiv1, int id, int tipo);

    }
}
