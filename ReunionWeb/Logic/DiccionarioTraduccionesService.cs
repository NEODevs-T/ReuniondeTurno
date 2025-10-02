
namespace ReunionWeb.Services
{
    public class DiccionarioTraduccionesService : IDiccionarioTraduccionesService
    {
        private readonly ITranslationService _translator;
        public Dictionary<string, string> Traducciones { get; private set; } = new();

        public DiccionarioTraduccionesService(ITranslationService translator)
        {
            _translator = translator;
        }

        public async Task CargarTraduccionesAsync()
        {
            var claves = new[]
            {
            "BuscarCargo", "BuscarCargo2", "Cargo", "Centro", "Consultar","DiasNoLaborables", "Empresa",
            "ExcluirLosDiasNoLaborables", "FechaFinal", "FechaInicial", "FiltrarPorCargo",
            "LimpiarFiltros", "NoExisteEseCargo", "NoHayFiltros", "PorcentajeAsistencia",
            "PorcentajeDeAsistencia", "PorcentajeGlobal", "ReunionesAsistidas",
            "ReunionesProgramadas", "SeleccioneUnCentro", "SeleccioneUnaEmpresa"
        };

            foreach (var clave in claves)
            {
                var traduccion = _translator.Traducir(clave);
                Traducciones[clave] = traduccion;
                Console.WriteLine($"Clave: {clave} => {(string.IsNullOrEmpty(traduccion) ? "SIN TRADUCCIÓN" : traduccion)}");
            }

            await Task.CompletedTask;
        }
    }
}