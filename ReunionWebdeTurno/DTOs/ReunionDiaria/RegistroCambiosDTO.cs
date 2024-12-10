
namespace ReunionWeb.ReunionDiaria.DTOs;


public class RegistroCambiosDTO
{
    public RegistroCambiosDTO(CambFecDTO cambFecDTO, CambStatDTO cambStatDTO, ReuDiumDTO regisReudia)
    {
        this.cambFecDTO = cambFecDTO;
        this.cambStatDTO = cambStatDTO;
        this.regisReudia = regisReudia;
    }
    public CambFecDTO? cambFecDTO { get; set; }
    public CambStatDTO? cambStatDTO { get; set; }
    public ReuDiumDTO? regisReudia { get; set; }

}