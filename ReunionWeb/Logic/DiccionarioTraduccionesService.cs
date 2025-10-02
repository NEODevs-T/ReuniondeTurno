
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
            "Atencion", "Asistencia", "Asistentes", "Bloque", "BuscarCargo", "BuscarCargo2", "Cargo", "Centro", "Consultar","DiasNoLaborables", "Empresa",
            "ExcluirLosDiasNoLaborables", "FechaFinal", "FechaInicial", "FiltrarPorCargo", "Guardar",
            "LimpiarFiltros", "NoCargadoP", "NoExisteEseCargo",  "NoHayFiltros", "Personal", "PorcentajeAsistencia",
            "PorcentajeDeAsistencia", "PorcentajeGlobal", "Presencia", "ReunionesAsistidas",
            "ReunionesProgramadas", "SeleccioneUnCentro", "SeleccioneUnaEmpresa", "SSuplente", "Suplencia", "TCargos", "RExitoso", "RHorario", "EDato"
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