public class UsuarioContexto
{
    public int idPais { get; set; }
    public string CultureName => idPais == 5 ? "en" : "es";
}
