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
                "Accion",
    "Acciones",
    "Aceptar",
    "Advertencia",
    "Area",
    "Asistencia",
    "Asistentes",
    "Asuntos",
    "Atencion",
    "Atras",
    "Bloque",
    "Borrar",
    "Buscar",
    "C_Equipo",
    "CambiosDeEstados",
    "Centro",
    "Cerrado",
    "Codigo",
    "CodigoDeEquipo",
    "Consolidacion",
    "ConsolidacionDeDiscrepancia",
    "Consultar",
    "Correcto",
    "Desde",
    "DetallesCalidad",
    "DetallesDeCalidad",
    "Discrepancia",
    "Discrepancias",
    "Division",
    "EDato",
    "EditarDiscrepancia",
    "EnCurso",
    "Error",
    "ErrorInesp",
    "ErrorInser",
    "Estado",
    "Exito",
    "FReunion",
    "F_Reunion",
    "FechaDeReunion",
    "FechaDelCambio",
    "Ficha",
    "Filtrar",
    "FiltroFechaDeReunion",
    "FormatoDeReunion",
    "Guardar",
    "Hasta",
    "hay_registros_vencidos",
    "Historicos",
    "Imprimir",
    "Linea",
    "Listo",
    "LlDisp",
    "NEquipo",
    "NFDatos",
    "NPA1",
    "NPA2",
    "NSDatos",
    "NoCargadoP",
    "NoHayDatos",
    "NoHayDatos2",
    "NoHayDescrip",
    "NoHayEquipos",
    "NoHayRegistros",
    "NoHayRegistros2",
    "NombreDelEquipo",
    "NuevaFechaDeTrabajo",
    "ODT",
    "ObservacionesDeCalidad",
    "Ordenar",
    "OrgDelProducto",
    "Pendiente",
    "Personal",
    "PlanDeAccion",
    "Presencia",
    "RExitoso",
    "RHorario",
    "Reload",
    "RequiredPassword",
    "RequiredUserName",
    "Responsable",
    "Reunion",
    "SArea",
    "SCentro",
    "SDivision",
    "SEstado",
    "SSuplente",
    "SVCentro",
    "SVDivision",
    "SVLista",
    "Seleccione",
    "SeleccioneUnCentro",
    "SeleccioneUnaDivision",
    "SeleccioneUnaEmpresa",
    "StatusNuevo",
    "Suplencia",
    "TCargos",
    "Todo",
    "Todos",
    "Trazabilidad",
    "Usuario",
    "PorcentajeDeAsistencia",
    "FechaInicial",
    "FechaFinal",
    "Empresa",
    "ExcluirLosDiasNoLaborables",
    "DiasNoLaborables",
    "FiltrarPorCargo",
    "BuscarCargo",
    "BuscarCargo2",
    "PorcentajeGlobal",
    "NoExisteEseCargo",
    "LimpiarFiltros",
    "ReunionesProgramadas",
    "ReunionesAsistidas",
    "PorcentajeAsistencia",
    "Cargo",
    "SeleccioneDML",
    "AgregarFecha",
    "FechasSeleccionadas",
    "Cancelar",
    "NoHayFiltros",
    "IniciarSesion",
    "CerrarSesion",
    "Hola"
        };

            foreach (var clave in claves)
            {
                var traduccion = _translator.Traducir(clave);
                Traducciones[clave] = traduccion;
            }

            await Task.CompletedTask;
        }
    }
}
