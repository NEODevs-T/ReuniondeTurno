
namespace ReunionWeb.ReunionDiaria.DTOs;


public class RegistroCambiosDTO
{
    public RegistroCambiosDTO(CambFecDTO Data, CambStatDTO Data2)
    {
        this.Data = Data;
        this.Data2 = Data2;
    }
    public CambFecDTO Data { get; set; }
    public CambStatDTO Data2 { get; set; }
}