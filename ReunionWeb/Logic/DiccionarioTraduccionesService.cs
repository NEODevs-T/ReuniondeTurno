using System.Globalization;
using ReunionWeb.Services;
using ReunionWeb.Interface;
using ReunionWeb.Resources;

namespace ReunionWeb.Services
{
    public class DiccionarioTraduccionesService : IDiccionarioTraduccionesService
    {
        private readonly ITranslationService _translator;
        private readonly IRespoReuData _respoReuData;

        public Dictionary<string, string> Traducciones { get; private set; } = new();

        public DiccionarioTraduccionesService(ITranslationService translator, IRespoReuData respoReuData)
        {
            _translator = translator;
            _respoReuData = respoReuData;
        }

        public async Task CargarTraduccionesAsync()
        {
            var claves = new[]
            {
            "Atencion", "Asistencia", "Asistentes", "Bloque", "Borrar", "BuscarCargo", "BuscarCargo2", "Cancelar", "Cargo", "Centro", "Consultar","DiasNoLaborables", "Empresa",
            "ExcluirLosDiasNoLaborables", "FechaFinal", "FechaInicial", "FiltrarPorCargo", "Guardar",
            "LimpiarFiltros", "NoCargadoP", "NoExisteEseCargo",  "NoHayFiltros", "Personal", "PorcentajeAsistencia",
            "PorcentajeDeAsistencia", "PorcentajeGlobal", "Presencia", "ReunionesAsistidas", "AgregarFecha", "FechasSeleccionadas",
            "Discrepancias", "Seleccione", "Division", "Linea", "Filtrar", "CodigoDeEquipo", "Discrepancia", "Responsable", "DetallesDeCalidad", "OrgDelProducto",
            "ReunionesProgramadas", "SeleccioneUnCentro", "SeleccioneUnaEmpresa", "SeleccioneDML", "SSuplente", "Suplencia", "TCargos", "RExitoso", "RHorario", "EDato",
            "SCentro", "SDivision", "SArea", "ErrorInser", "NSDatos", "LlDisp", "SEstado"
        };

            foreach (var clave in claves)
            {
                var traduccion = _translator.Traducir(clave);
                Traducciones[clave] = traduccion;
            }

            var listaResponsbale = await _respoReuData.GetResReu();
            if (listaResponsbale != null)
            {
                foreach (var d in listaResponsbale)
                {
                    var respo = ValidationMessages.MapResponsableKey(d.Rrnombre);
                    if (!Traducciones.ContainsKey(respo))
                    {
                        Traducciones[respo] = _translator.Traducir(respo);
                    }
                }
            }

            await Task.CompletedTask;
        }
    }
}
