
namespace ReunionWeb.ReunionDiaria.DTOs;


public class RegistroCambiosDTO
{
    public RegistroCambiosDTO(CambFecDTO cambFecDTO, CambStatDTO cambStatDTO)
    {
        this.cambFecDTO = cambFecDTO;
        this.cambStatDTO = cambStatDTO;
    }
    public CambFecDTO? cambFecDTO { get; set; }
    public CambStatDTO? cambStatDTO { get; set; }
}