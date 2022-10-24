using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ReunionWeb.Models
{
    public partial class DOC_IngIContext : DbContext
    {
        public DOC_IngIContext()
        {
        }

        public DOC_IngIContext(DbContextOptions<DOC_IngIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AhorroCrp> AhorroCrps { get; set; } = null!;
        public virtual DbSet<AhorroIdeaId> AhorroIdeaIds { get; set; } = null!;
        public virtual DbSet<AhorroProyecto> AhorroProyectos { get; set; } = null!;
        public virtual DbSet<Archivo> Archivos { get; set; } = null!;
        public virtual DbSet<ArchivoCalidad> ArchivoCalidads { get; set; } = null!;
        public virtual DbSet<Area> Areas { get; set; } = null!;
        public virtual DbSet<AreaSol> AreaSols { get; set; } = null!;
        public virtual DbSet<AreaSolPanasa> AreaSolPanasas { get; set; } = null!;
        public virtual DbSet<Asistencium> Asistencia { get; set; } = null!;
        public virtual DbSet<Auditoria> Auditorias { get; set; } = null!;
        public virtual DbSet<AuditoriaProyecto> AuditoriaProyectos { get; set; } = null!;
        public virtual DbSet<AuditoriaProyectosPanasa> AuditoriaProyectosPanasas { get; set; } = null!;
        public virtual DbSet<AuditoriasPanasa> AuditoriasPanasas { get; set; } = null!;
        public virtual DbSet<AvanceSemanal> AvanceSemanals { get; set; } = null!;
        public virtual DbSet<AvanceSemanalPanasa> AvanceSemanalPanasas { get; set; } = null!;
        public virtual DbSet<BdDiv1> BdDiv1s { get; set; } = null!;
        public virtual DbSet<BdDiv2> BdDiv2s { get; set; } = null!;
        public virtual DbSet<BdDiv3> BdDiv3s { get; set; } = null!;
        public virtual DbSet<BonoProServicio> BonoProServicios { get; set; } = null!;
        public virtual DbSet<BonoProServicioBk> BonoProServicioBks { get; set; } = null!;
        public virtual DbSet<BonoProServicioOld> BonoProServicioOlds { get; set; } = null!;
        public virtual DbSet<BrokeConv> BrokeConvs { get; set; } = null!;
        public virtual DbSet<BrokeConvBk> BrokeConvBks { get; set; } = null!;
        public virtual DbSet<CauCaliMol> CauCaliMols { get; set; } = null!;
        public virtual DbSet<Causa> Causas { get; set; } = null!;
        public virtual DbSet<Causa1> Causas1 { get; set; } = null!;
        public virtual DbSet<CcHerram> CcHerrams { get; set; } = null!;
        public virtual DbSet<CheckLab> CheckLabs { get; set; } = null!;
        public virtual DbSet<CheckNueProd> CheckNueProds { get; set; } = null!;
        public virtual DbSet<ConsolidadoRrhh> ConsolidadoRrhhs { get; set; } = null!;
        public virtual DbSet<ConsolidadoRrhh2> ConsolidadoRrhh2s { get; set; } = null!;
        public virtual DbSet<ConsolidadoRrhh2021> ConsolidadoRrhh2021s { get; set; } = null!;
        public virtual DbSet<Convenio> Convenios { get; set; } = null!;
        public virtual DbSet<Crp> Crps { get; set; } = null!;
        public virtual DbSet<Crp2> Crp2s { get; set; } = null!;
        public virtual DbSet<Datactrrhh> Datactrrhhs { get; set; } = null!;
        public virtual DbSet<Datactrrhh2> Datactrrhh2s { get; set; } = null!;
        public virtual DbSet<DatosGte> DatosGtes { get; set; } = null!;
        public virtual DbSet<DatosGte2> DatosGte2s { get; set; } = null!;
        public virtual DbSet<DatosMinutaGte> DatosMinutaGtes { get; set; } = null!;
        public virtual DbSet<DefinicionProyIngInd> DefinicionProyIngInds { get; set; } = null!;
        public virtual DbSet<DefinicionProyIngIndPanasa> DefinicionProyIngIndPanasas { get; set; } = null!;
        public virtual DbSet<DepartCalidad> DepartCalidads { get; set; } = null!;
        public virtual DbSet<DepartHijo> DepartHijos { get; set; } = null!;
        public virtual DbSet<Departamento> Departamentos { get; set; } = null!;
        public virtual DbSet<Dibujante> Dibujantes { get; set; } = null!;
        public virtual DbSet<Dicmct> Dicmcts { get; set; } = null!;
        public virtual DbSet<Disposicion> Disposicions { get; set; } = null!;
        public virtual DbSet<Division> Divisions { get; set; } = null!;
        public virtual DbSet<Divisione> Divisiones { get; set; } = null!;
        public virtual DbSet<Dpto> Dptos { get; set; } = null!;
        public virtual DbSet<EfiDiarium> EfiDiaria { get; set; } = null!;
        public virtual DbSet<EfiMensual> EfiMensuals { get; set; } = null!;
        public virtual DbSet<EficienciaBk> EficienciaBks { get; set; } = null!;
        public virtual DbSet<Eficiencium> Eficiencia { get; set; } = null!;
        public virtual DbSet<Equipo> Equipos { get; set; } = null!;
        public virtual DbSet<Fabrica> Fabricas { get; set; } = null!;
        public virtual DbSet<FactoryMutual> FactoryMutuals { get; set; } = null!;
        public virtual DbSet<FactoryMutualRespaldo> FactoryMutualRespaldos { get; set; } = null!;
        public virtual DbSet<Fifo> Fifos { get; set; } = null!;
        public virtual DbSet<Form1> Form1s { get; set; } = null!;
        public virtual DbSet<Form2> Form2s { get; set; } = null!;
        public virtual DbSet<Formulacion> Formulacions { get; set; } = null!;
        public virtual DbSet<HisEcDium> HisEcDia { get; set; } = null!;
        public virtual DbSet<HistAreaIi> HistAreaIis { get; set; } = null!;
        public virtual DbSet<HistAreaIiPanasa> HistAreaIiPanasas { get; set; } = null!;
        public virtual DbSet<HistIngInd> HistIngInds { get; set; } = null!;
        public virtual DbSet<Hito> Hitos { get; set; } = null!;
        public virtual DbSet<HitosPanasa> HitosPanasas { get; set; } = null!;
        public virtual DbSet<HorasIp> HorasIps { get; set; } = null!;
        public virtual DbSet<HorasIpPlan> HorasIpPlans { get; set; } = null!;
        public virtual DbSet<Idea> Ideas { get; set; } = null!;
        public virtual DbSet<IndGte> IndGtes { get; set; } = null!;
        public virtual DbSet<InformesCalidad> InformesCalidads { get; set; } = null!;
        public virtual DbSet<Joel> Joels { get; set; } = null!;
        public virtual DbSet<Maquina> Maquinas { get; set; } = null!;
        public virtual DbSet<MaterialEnsayo> MaterialEnsayos { get; set; } = null!;
        public virtual DbSet<Mcarga> Mcargas { get; set; } = null!;
        public virtual DbSet<Mcconductuale> Mcconductuales { get; set; } = null!;
        public virtual DbSet<Mctecnica> Mctecnicas { get; set; } = null!;
        public virtual DbSet<Meta> Metas { get; set; } = null!;
        public virtual DbSet<MetasIp> MetasIps { get; set; } = null!;
        public virtual DbSet<MetasPanasa> MetasPanasas { get; set; } = null!;
        public virtual DbSet<Minuta> Minutas { get; set; } = null!;
        public virtual DbSet<MinutasIp> MinutasIps { get; set; } = null!;
        public virtual DbSet<MinutasPanasa> MinutasPanasas { get; set; } = null!;
        public virtual DbSet<MinutasSsl> MinutasSsls { get; set; } = null!;
        public virtual DbSet<NovMolino> NovMolinos { get; set; } = null!;
        public virtual DbSet<NovMolinoDetalle> NovMolinoDetalles { get; set; } = null!;
        public virtual DbSet<NovMolinoShellsol> NovMolinoShellsols { get; set; } = null!;
        public virtual DbSet<Novedade> Novedades { get; set; } = null!;
        public virtual DbSet<NovedadesPlantum> NovedadesPlanta { get; set; } = null!;
        public virtual DbSet<ObPrConver> ObPrConvers { get; set; } = null!;
        public virtual DbSet<ObjProd> ObjProds { get; set; } = null!;
        public virtual DbSet<ObsSsl> ObsSsls { get; set; } = null!;
        public virtual DbSet<Oportunidad> Oportunidads { get; set; } = null!;
        public virtual DbSet<OportunidadPanasa> OportunidadPanasas { get; set; } = null!;
        public virtual DbSet<Pai> Pais { get; set; } = null!;
        public virtual DbSet<PartesEquipo> PartesEquipos { get; set; } = null!;
        public virtual DbSet<PersonalCalidad> PersonalCalidads { get; set; } = null!;
        public virtual DbSet<PlanAccionGerenciaPanasa> PlanAccionGerenciaPanasas { get; set; } = null!;
        public virtual DbSet<PlanAccionGerencium> PlanAccionGerencia { get; set; } = null!;
        public virtual DbSet<PlanesGte> PlanesGtes { get; set; } = null!;
        public virtual DbSet<PlanesPlantaSptte> PlanesPlantaSpttes { get; set; } = null!;
        public virtual DbSet<PlanesPlantum> PlanesPlanta { get; set; } = null!;
        public virtual DbSet<PrecioPt> PrecioPts { get; set; } = null!;
        public virtual DbSet<PrepagoDisp> PrepagoDisps { get; set; } = null!;
        public virtual DbSet<Prioridad> Prioridads { get; set; } = null!;
        public virtual DbSet<PrioridadPanasa> PrioridadPanasas { get; set; } = null!;
        public virtual DbSet<ProdDiv4> ProdDiv4s { get; set; } = null!;
        public virtual DbSet<ProyGerenciaPanasa> ProyGerenciaPanasas { get; set; } = null!;
        public virtual DbSet<ProyGerencium> ProyGerencia { get; set; } = null!;
        public virtual DbSet<Proyecto> Proyectos { get; set; } = null!;
        public virtual DbSet<ProyectoIp> ProyectoIps { get; set; } = null!;
        public virtual DbSet<ProyectoPanasa> ProyectoPanasas { get; set; } = null!;
        public virtual DbSet<ProyectoRc> ProyectoRcs { get; set; } = null!;
        public virtual DbSet<ProyectoRcAhoGral> ProyectoRcAhoGrals { get; set; } = null!;
        public virtual DbSet<ProyectoRcAhorro> ProyectoRcAhorros { get; set; } = null!;
        public virtual DbSet<ProyectoRespaldo> ProyectoRespaldos { get; set; } = null!;
        public virtual DbSet<ProyectoSsl> ProyectoSsls { get; set; } = null!;
        public virtual DbSet<RecursosTarea> RecursosTareas { get; set; } = null!;
        public virtual DbSet<RotaCaliV> RotaCaliVs { get; set; } = null!;
        public virtual DbSet<RotaCalidum> RotaCalida { get; set; } = null!;
        public virtual DbSet<Rotacion> Rotacions { get; set; } = null!;
        public virtual DbSet<RotacionMcbo> RotacionMcbos { get; set; } = null!;
        public virtual DbSet<Satisfaccion> Satisfaccions { get; set; } = null!;
        public virtual DbSet<SatisfaccionIp> SatisfaccionIps { get; set; } = null!;
        public virtual DbSet<SatisfaccionPanasa> SatisfaccionPanasas { get; set; } = null!;
        public virtual DbSet<Solicitud> Solicituds { get; set; } = null!;
        public virtual DbSet<SolicitudCambio> SolicitudCambios { get; set; } = null!;
        public virtual DbSet<SolicitudCod> SolicitudCods { get; set; } = null!;
        public virtual DbSet<SolicitudCodigo2> SolicitudCodigo2s { get; set; } = null!;
        public virtual DbSet<SolicitudLab> SolicitudLabs { get; set; } = null!;
        public virtual DbSet<SolicitudNueProd> SolicitudNueProds { get; set; } = null!;
        public virtual DbSet<SolicitudPanasa> SolicitudPanasas { get; set; } = null!;
        public virtual DbSet<SolicitudT> SolicitudTs { get; set; } = null!;
        public virtual DbSet<Stsidea> Stsideas { get; set; } = null!;
        public virtual DbSet<SupAud> SupAuds { get; set; } = null!;
        public virtual DbSet<TallerAutomotrizMc> TallerAutomotrizMcs { get; set; } = null!;
        public virtual DbSet<Tarea> Tareas { get; set; } = null!;
        public virtual DbSet<TareaActividad> TareaActividads { get; set; } = null!;
        public virtual DbSet<TareasEquipo> TareasEquipos { get; set; } = null!;
        public virtual DbSet<TareasIp> TareasIps { get; set; } = null!;
        public virtual DbSet<TareasPanasa> TareasPanasas { get; set; } = null!;
        public virtual DbSet<Transporte> Transportes { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<UsuarioVcc> UsuarioVccs { get; set; } = null!;
        public virtual DbSet<UsuariosSgi> UsuariosSgis { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AhorroCrp>(entity =>
            {
                entity.HasKey(e => e.AhoIdProye);

                entity.ToTable("AhorroCrp");

                entity.Property(e => e.AhoIdProye).HasComment("Ahorro del proyecto Id");

                entity.Property(e => e.AhoBudget)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Ahorro Budget");

                entity.Property(e => e.AhoDpto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Descripción de los departamentos   de Crp");

                entity.Property(e => e.AhoIdCrp).HasComment("Crp Id");

                entity.Property(e => e.AhoMes)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("Mes del  proyetos  de  Crp");

                entity.Property(e => e.AhoReal)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Ahorro Real");
            });

            modelBuilder.Entity<AhorroIdeaId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ahorroIdeaID");

                entity.Property(e => e.AhorroIdeaId1).HasColumnName("ahorroIdeaID");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Montoreal)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("montoreal");

                entity.Property(e => e.ProyectoId).HasColumnName("ProyectoID");
            });

            modelBuilder.Entity<AhorroProyecto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ahorroProyecto");

                entity.Property(e => e.Ahorro)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ahorro");

                entity.Property(e => e.AhorroProyectoId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ahorroProyectoId");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.ProyectoId).HasColumnName("proyectoId");
            });

            modelBuilder.Entity<Archivo>(entity =>
            {
                entity.ToTable("archivo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Archivo1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("archivo");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod");

                entity.Property(e => e.Fecsub)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecsub");

                entity.Property(e => e.Item).HasColumnName("item");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ArchivoCalidad>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("archivo_calidad");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.FecAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fec_act");

                entity.Property(e => e.ModPor)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("mod_por");

                entity.Property(e => e.NomArchivo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("nom_archivo");

                entity.Property(e => e.Ruta)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ruta");

                entity.Property(e => e.TipoArchivo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tipo_archivo");
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Area");

                entity.Property(e => e.AreDescripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdArea).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AreaSol>(entity =>
            {
                entity.HasKey(e => e.Area);

                entity.ToTable("AreaSol");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AhoAcu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Aho_Acu");

                entity.Property(e => e.Año)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("año");

                entity.Property(e => e.SatisAcu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Satis_Acu");
            });

            modelBuilder.Entity<AreaSolPanasa>(entity =>
            {
                entity.HasKey(e => e.Area);

                entity.ToTable("AreaSol_panasa");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AhoAcu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Aho_Acu");

                entity.Property(e => e.SatisAcu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Satis_Acu");
            });

            modelBuilder.Entity<Asistencium>(entity =>
            {
                entity.Property(e => e.Area)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MttoPrev).HasColumnName("Mtto_prev");

                entity.Property(e => e.SptteProduccion).HasColumnName("Sptte_Produccion");

                entity.Property(e => e.SupvInstrumentacion).HasColumnName("Supv_Instrumentacion");

                entity.Property(e => e.SupvMttoElectricoElectronico).HasColumnName("Supv_MttoElectrico_Electronico");

                entity.Property(e => e.SupvMttoMecanico).HasColumnName("Supv_MttoMecanico");

                entity.Property(e => e.SupvProd).HasColumnName("Supv_prod");
            });

            modelBuilder.Entity<Auditoria>(entity =>
            {
                entity.ToTable("auditorias");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.AlmHerr).HasColumnName("alm_herr");

                entity.Property(e => e.AlmIns).HasColumnName("alm_ins");

                entity.Property(e => e.AlmSat).HasColumnName("alm_sat");

                entity.Property(e => e.Asent).HasColumnName("asent");

                entity.Property(e => e.Año)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("año");

                entity.Property(e => e.Cc)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CC");

                entity.Property(e => e.Comunicacion).HasColumnName("comunicacion");

                entity.Property(e => e.ConPro).HasColumnName("con_pro");

                entity.Property(e => e.Dpto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dpto");

                entity.Property(e => e.FecAud)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fec_aud");

                entity.Property(e => e.GesProd).HasColumnName("ges_prod");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grupo");

                entity.Property(e => e.Mes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mes");

                entity.Property(e => e.NMes).HasColumnName("n_mes");

                entity.Property(e => e.NomAud)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nom_aud");

                entity.Property(e => e.OrgFisAct).HasColumnName("org_fis_act");

                entity.Property(e => e.OrgFisNue).HasColumnName("org_fis_nue");

                entity.Property(e => e.Quincena)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("quincena");

                entity.Property(e => e.Reunion).HasColumnName("reunion");

                entity.Property(e => e.Rutinas).HasColumnName("rutinas");

                entity.Property(e => e.Seguridad).HasColumnName("seguridad");

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supervisor");

                entity.Property(e => e.TiempoPerd).HasColumnName("tiempo_perd");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.Ubic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ubic");

                entity.Property(e => e.Zona)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("zona");
            });

            modelBuilder.Entity<AuditoriaProyecto>(entity =>
            {
                entity.ToTable("auditoria_proyectos");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Aud)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aud");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod");

                entity.Property(e => e.Dis)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("dis");

                entity.Property(e => e.Fecaud)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecaud");

                entity.Property(e => e.Feccom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("feccom");

                entity.Property(e => e.Finalizado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("finalizado");

                entity.Property(e => e.Item)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("item");

                entity.Property(e => e.Planacc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("planacc");

                entity.Property(e => e.Resp)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("resp");
            });

            modelBuilder.Entity<AuditoriaProyectosPanasa>(entity =>
            {
                entity.ToTable("auditoria_proyectos_panasa");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Aud)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aud");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod");

                entity.Property(e => e.Dis)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("dis");

                entity.Property(e => e.Fecaud)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecaud");

                entity.Property(e => e.Feccom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("feccom");

                entity.Property(e => e.Finalizado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("finalizado");

                entity.Property(e => e.Item)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("item");

                entity.Property(e => e.Planacc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("planacc");

                entity.Property(e => e.Resp)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("resp");
            });

            modelBuilder.Entity<AuditoriasPanasa>(entity =>
            {
                entity.ToTable("auditorias_panasa");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.AlmSat).HasColumnName("alm_sat");

                entity.Property(e => e.Asent).HasColumnName("asent");

                entity.Property(e => e.Año)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("año");

                entity.Property(e => e.Comunicacion).HasColumnName("comunicacion");

                entity.Property(e => e.Dpto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dpto");

                entity.Property(e => e.FecAud)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fec_aud");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grupo");

                entity.Property(e => e.Mes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mes");

                entity.Property(e => e.NMes).HasColumnName("n_mes");

                entity.Property(e => e.NomAud)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nom_aud");

                entity.Property(e => e.OrgFisNue).HasColumnName("org_fis_nue");

                entity.Property(e => e.Quincena)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("quincena");

                entity.Property(e => e.Reunion).HasColumnName("reunion");

                entity.Property(e => e.Rutinas).HasColumnName("rutinas");

                entity.Property(e => e.Seguridad).HasColumnName("seguridad");

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supervisor");

                entity.Property(e => e.TiempoPerd).HasColumnName("tiempo_perd");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.Ubic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ubic");

                entity.Property(e => e.Zona)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("zona");
            });

            modelBuilder.Entity<AvanceSemanal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("avance_semanal");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PorAvance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("por_avance");

                entity.Property(e => e.ProgEsp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prog_esp");

                entity.Property(e => e.ProgReal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prog_real");

                entity.Property(e => e.Semana)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("semana");
            });

            modelBuilder.Entity<AvanceSemanalPanasa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("avance_semanal_panasa");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PorAvance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("por_avance");

                entity.Property(e => e.ProgEsp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prog_esp");

                entity.Property(e => e.ProgReal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prog_real");

                entity.Property(e => e.Semana)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("semana");
            });

            modelBuilder.Entity<BdDiv1>(entity =>
            {
                entity.ToTable("BD_Div1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_equipo");

                entity.Property(e => e.Discrepancia)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Div)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Fecha2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaTrab)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_trab");

                entity.Property(e => e.FechaTrab1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fecha_trab1");

                entity.Property(e => e.Ksf)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanDeAccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plan_de_accion");

                entity.Property(e => e.Produfin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ps)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tiempo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdDiv2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BD_Div2");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_equipo");

                entity.Property(e => e.Discrepancia)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Div)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Fecha2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaTrab)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_trab");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Ksf)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanDeAccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plan_de_accion");

                entity.Property(e => e.Produfin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ps)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tiempo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BdDiv3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BD_Div3");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_equipo");

                entity.Property(e => e.Discrepancia)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaTrab)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_trab");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Ksf)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanDeAccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plan_de_accion");

                entity.Property(e => e.Produfin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ps)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tiempo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BonoProServicio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BonoPro_Servicio");

                entity.HasIndex(e => new { e.NombreTrab, e.CampoA }, "index_1");

                entity.HasIndex(e => new { e.Fecha, e.Ficha, e.NombreTrab, e.PuestoTrab, e.TurnoTrab, e.MontoTotal, e.Validacion, e.FechaRegistro, e.PorsProceso, e.CampoA, e.CampoB, e.CampoC, e.FechaRegistro1 }, "index_2");

                entity.Property(e => e.CampoA).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CampoB)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CampoC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_registro");

                entity.Property(e => e.FechaRegistro1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fecha_registro1");

                entity.Property(e => e.Ficha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MontoTotal)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Monto_total");

                entity.Property(e => e.NombreTrab)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_trab");

                entity.Property(e => e.PorsProceso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pors_proceso");

                entity.Property(e => e.PuestoTrab)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Puesto_trab");

                entity.Property(e => e.TurnoTrab).HasColumnName("Turno_trab");
            });

            modelBuilder.Entity<BonoProServicioBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BonoPro_Servicio.bk");

                entity.Property(e => e.CampoA).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CampoB)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CampoC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_registro");

                entity.Property(e => e.FechaRegistro1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fecha_registro1");

                entity.Property(e => e.Ficha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MontoTotal)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Monto_total");

                entity.Property(e => e.NombreTrab)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_trab");

                entity.Property(e => e.PorsProceso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pors_proceso");

                entity.Property(e => e.PuestoTrab)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Puesto_trab");

                entity.Property(e => e.TurnoTrab).HasColumnName("Turno_trab");
            });

            modelBuilder.Entity<BonoProServicioOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BonoPro_Servicio_old");

                entity.Property(e => e.CampoA).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CampoB)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CampoC)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_registro");

                entity.Property(e => e.FechaRegistro1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fecha_registro1");

                entity.Property(e => e.Ficha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MontoTotal)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Monto_total");

                entity.Property(e => e.NombreTrab)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_trab");

                entity.Property(e => e.PorsProceso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pors_proceso");

                entity.Property(e => e.PuestoTrab)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Puesto_trab");

                entity.Property(e => e.TurnoTrab).HasColumnName("Turno_trab");
            });

            modelBuilder.Entity<BrokeConv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Broke_conv");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Equipo)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBpcs).HasColumnName("Fecha_BPCS");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Hora)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HoraVariable).HasColumnName("Hora_variable");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Indicador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lote)
                    .HasMaxLength(850)
                    .IsUnicode(false);

                entity.Property(e => e.Molino)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Observacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .HasMaxLength(850)
                    .IsUnicode(false);

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valores).HasColumnType("numeric(30, 4)");

                entity.Property(e => e.Variable)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BrokeConvBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Broke_conv_bk");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBpcs).HasColumnName("Fecha_BPCS");

                entity.Property(e => e.Hora)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HoraVariable).HasColumnName("Hora_variable");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Indicador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lote)
                    .HasMaxLength(850)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Producto)
                    .HasMaxLength(850)
                    .IsUnicode(false);

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valores)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Variable)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CauCaliMol>(entity =>
            {
                entity.HasKey(e => e.CmidCauMol);

                entity.ToTable("CauCaliMol");

                entity.Property(e => e.CmidCauMol)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CMIdCauMol")
                    .HasComment("ID CAUSAS DE CALIDAD DE  MOLINO");

                entity.Property(e => e.CmcodCau)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CMCodCau")
                    .HasComment("CODIGO DE CAUSA");

                entity.Property(e => e.Cmdescrip)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CMDescrip")
                    .HasComment("DESCRIPCIÓN  DE LAS CAUSA DE CALIDAD DE MOLINO");

                entity.Property(e => e.Cmestatus)
                    .HasColumnName("CMEstatus")
                    .HasComment("ESTATUS 1 ESTA ACTIVO SI ES 0 INACTIVO ");

                entity.Property(e => e.IdNovedade).HasComment("ID DE LA TABLA NOVEDADES");

                entity.HasOne(d => d.CmidCauMolNavigation)
                    .WithOne(p => p.CauCaliMol)
                    .HasForeignKey<CauCaliMol>(d => d.CmidCauMol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CauCaliMol_NOVEDADES");
            });

            modelBuilder.Entity<Causa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Causa");

                entity.Property(e => e.CausDesc)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CausId)
                    .HasMaxLength(10)
                    .HasColumnName("CausID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Causa1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Causas");

                entity.Property(e => e.CauId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CauID");

                entity.Property(e => e.DescCorta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Desc_Corta");

                entity.Property(e => e.IdCausa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CcHerram>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CC_Herram");

                entity.Property(e => e.Cc).HasColumnName("CC");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Planta)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CheckLab>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("check_lab");

                entity.Property(e => e.IdCheck)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_check");

                entity.Property(e => e.IdSol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_sol");

                entity.Property(e => e.Texto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("texto");
            });

            modelBuilder.Entity<CheckNueProd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("check_nue_prod");

                entity.Property(e => e.IdCheck)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_check");

                entity.Property(e => e.IdSol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_sol");

                entity.Property(e => e.Texto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("texto");
            });

            modelBuilder.Entity<ConsolidadoRrhh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ConsolidadoRRHH");

                entity.Property(e => e.CampoA)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("campo_a");

                entity.Property(e => e.CampoB)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("campo_b");

                entity.Property(e => e.CampoC).HasColumnName("campo_c");

                entity.Property(e => e.Compañia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Ficha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FichaSup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ficha_sup");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroFecha).HasColumnName("numero_fecha");

                entity.Property(e => e.Pregunta)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Puesto)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PuntajeEsp).HasColumnName("Puntaje_Esp");

                entity.Property(e => e.PuntajeReal)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Puntaje_Real");

                entity.Property(e => e.PuntajeSup)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Puntaje_Sup");

                entity.Property(e => e.Status).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TipoNom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_NOM");

                entity.Property(e => e.Valor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConsolidadoRrhh2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ConsolidadoRRHH2");

                entity.Property(e => e.CampoA)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("campo_a");

                entity.Property(e => e.CampoB)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("campo_b");

                entity.Property(e => e.CampoC).HasColumnName("campo_c");

                entity.Property(e => e.Compañia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Ficha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FichaSup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ficha_sup");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroFecha).HasColumnName("numero_fecha");

                entity.Property(e => e.Pregunta)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Puesto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PuntajeEsp).HasColumnName("Puntaje_Esp");

                entity.Property(e => e.PuntajeReal)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Puntaje_Real");

                entity.Property(e => e.PuntajeSup)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Puntaje_Sup");

                entity.Property(e => e.Status).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConsolidadoRrhh2021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ConsolidadoRRHH2021");

                entity.Property(e => e.CampoA)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("campo_a");

                entity.Property(e => e.CampoB)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("campo_b");

                entity.Property(e => e.CampoC).HasColumnName("campo_c");

                entity.Property(e => e.Compañia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Ficha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FichaSup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ficha_sup");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroFecha).HasColumnName("numero_fecha");

                entity.Property(e => e.Pregunta)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Puesto)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PuntajeEsp).HasColumnName("Puntaje_Esp");

                entity.Property(e => e.PuntajeReal)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Puntaje_Real");

                entity.Property(e => e.PuntajeSup)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Puntaje_Sup");

                entity.Property(e => e.Status).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TipoNom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_NOM");

                entity.Property(e => e.Valor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Convenio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Convenio");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dpto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraRegistro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fecha_Hora_registro");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_registro");

                entity.Property(e => e.Ficha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreTrab)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_trab");

                entity.Property(e => e.PuestoTrab)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Puesto_trab");
            });

            modelBuilder.Entity<Crp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRP");

                entity.Property(e => e.Abril).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Agosto).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CalProyecto)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Cal_Proyecto");

                entity.Property(e => e.DescRechazo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Desc_rechazo");

                entity.Property(e => e.Diciembre).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Dpto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Enero).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Febrero).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaActual)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_actual");

                entity.Property(e => e.FechaCulminacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fecha_Culminacion");

                entity.Property(e => e.FechaImplementacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fecha_Implementacion");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Ididea).HasColumnName("IDIdea");

                entity.Property(e => e.Idpro)
                    .HasColumnType("numeric(5, 0)")
                    .HasColumnName("IDPro");

                entity.Property(e => e.Julio).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Junio).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Marzo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Mayo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Mes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MesR)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.MontoIndividual)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Monto_individual");

                entity.Property(e => e.MontoTotal)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Monto_total");

                entity.Property(e => e.Noviembre).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Octubre).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Porc).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Proyecto)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Real).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Septiembre).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Crp2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CRP2");

                entity.Property(e => e.Abril).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Agosto).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CalProyecto)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Cal_Proyecto");

                entity.Property(e => e.DescRechazo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Desc_rechazo");

                entity.Property(e => e.Diciembre).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Dpto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Enero).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Febrero).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FechaActual)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_actual");

                entity.Property(e => e.FechaCulminacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fecha_Culminacion");

                entity.Property(e => e.FechaImplementacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fecha_Implementacion");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Ididea).HasColumnName("IDIdea");

                entity.Property(e => e.Julio).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Junio).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Marzo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Mayo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Mes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MesR)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.MontoIndividual)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Monto_individual");

                entity.Property(e => e.MontoTotal)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Monto_total");

                entity.Property(e => e.Noviembre).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Octubre).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Porc).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Real).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Septiembre).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Datactrrhh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DATACTRRHH");

                entity.Property(e => e.Brecha)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BRECHA");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CARGO");

                entity.Property(e => e.CargoAplicado)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Cargo_Aplicado");

                entity.Property(e => e.Competencia)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("COMPETENCIA");

                entity.Property(e => e.Cond)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("COND");

                entity.Property(e => e.Condsup)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CONDSUP");

                entity.Property(e => e.Conducta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CONDUCTA");

                entity.Property(e => e.Dpto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DPTO");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Ficha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FICHA");

                entity.Property(e => e.Fichasup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FICHASUP");

                entity.Property(e => e.Gerencia1)
                    .HasMaxLength(100)
                    .HasColumnName("GERENCIA1")
                    .IsFixedLength();

                entity.Property(e => e.Gerencia2)
                    .HasMaxLength(100)
                    .HasColumnName("GERENCIA2")
                    .IsFixedLength();

                entity.Property(e => e.NivelDominioAuto)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("NIVEL_DOMINIO_AUTO");

                entity.Property(e => e.NivelDominioSup)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("NIVEL_DOMINIO_SUP");

                entity.Property(e => e.NivelEsp)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("NIVEL_ESP");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.TipoNom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_NOM");
            });

            modelBuilder.Entity<Datactrrhh2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DATACTRRHH2");

                entity.Property(e => e.Brecha)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BRECHA");

                entity.Property(e => e.Brechasup)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("BRECHASUP");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CARGO");

                entity.Property(e => e.Competencia)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("COMPETENCIA");

                entity.Property(e => e.Cond)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("COND");

                entity.Property(e => e.Condsup)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CONDSUP");

                entity.Property(e => e.Conducta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CONDUCTA");

                entity.Property(e => e.Dpto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DPTO");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("FECHA");

                entity.Property(e => e.Ficha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FICHA");

                entity.Property(e => e.Fichasup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FICHASUP");

                entity.Property(e => e.NivelDominioAuto)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("NIVEL_DOMINIO_AUTO");

                entity.Property(e => e.NivelDominioSup)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("NIVEL_DOMINIO_SUP");

                entity.Property(e => e.NivelEsp)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("NIVEL_ESP");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Nombre2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE2");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<DatosGte>(entity =>
            {
                entity.ToTable("datos_gte");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Año)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AÑO");

                entity.Property(e => e.Dpto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPTO");

                entity.Property(e => e.Mes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MES");

                entity.Property(e => e.Valor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VALOR");

                entity.Property(e => e.Variable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VARIABLE");
            });

            modelBuilder.Entity<DatosGte2>(entity =>
            {
                entity.ToTable("datos_gte2");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Año)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AÑO");

                entity.Property(e => e.Dpto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPTO");

                entity.Property(e => e.Mes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MES");

                entity.Property(e => e.MesNro).HasColumnName("MES_NRO");

                entity.Property(e => e.Objetivo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJETIVO");

                entity.Property(e => e.Real)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REAL");

                entity.Property(e => e.Variable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VARIABLE");
            });

            modelBuilder.Entity<DatosMinutaGte>(entity =>
            {
                entity.ToTable("datos_minuta_gte");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Año)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AÑO");

                entity.Property(e => e.Dpto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPTO");

                entity.Property(e => e.Idpais).HasColumnName("idpais");

                entity.Property(e => e.Indicador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INDICADOR");

                entity.Property(e => e.Mes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MES");

                entity.Property(e => e.NroPosicion).HasColumnName("NRO_POSICION");

                entity.Property(e => e.Obj)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJ");

                entity.Property(e => e.Obs)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("OBS");

                entity.Property(e => e.Real)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REAL");

                entity.Property(e => e.Um)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UM");
            });

            modelBuilder.Entity<DefinicionProyIngInd>(entity =>
            {
                entity.HasKey(e => e.Cod);

                entity.ToTable("Definicion_Proy_Ing_Ind");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod");

                entity.Property(e => e.Actual)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("actual");

                entity.Property(e => e.Alcance)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("alcance");

                entity.Property(e => e.Obj)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("obj");

                entity.Property(e => e.Problema)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("problema");

                entity.Property(e => e.Propuestas)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("propuestas");

                entity.Property(e => e.Raiz)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("raiz");
            });

            modelBuilder.Entity<DefinicionProyIngIndPanasa>(entity =>
            {
                entity.HasKey(e => e.Cod);

                entity.ToTable("Definicion_Proy_Ing_Ind_Panasa");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod");

                entity.Property(e => e.Actual)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("actual");

                entity.Property(e => e.Alcance)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("alcance");

                entity.Property(e => e.Obj)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("obj");

                entity.Property(e => e.Problema)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("problema");

                entity.Property(e => e.Propuestas)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("propuestas");

                entity.Property(e => e.Raiz)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("raiz");
            });

            modelBuilder.Entity<DepartCalidad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DepartCalidad");

                entity.Property(e => e.DepartIdcal).HasColumnName("DepartIDCAL");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Posicion).HasColumnName("posicion");
            });

            modelBuilder.Entity<DepartHijo>(entity =>
            {
                entity.HasKey(e => e.DepartamentoHijoId);

                entity.ToTable("DepartHijo");

                entity.Property(e => e.DepartamentoHijoId).HasColumnName("departamentoHijoID");

                entity.Property(e => e.DepartamentoId).HasColumnName("departamentoID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.DivId).HasColumnName("divID");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.DepartId);

                entity.ToTable("Departamento");

                entity.Property(e => e.DepartId).HasColumnName("DepartID");

                entity.Property(e => e.DepSelec).HasComment("DEPARTAMENTOS SELECCIONADOS ");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Posicion).HasColumnName("posicion");
            });

            modelBuilder.Entity<Dibujante>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionLarga)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Descripcion_larga");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaCompromiso)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_compromiso");

                entity.Property(e => e.FechaRequerida)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_requerida");

                entity.Property(e => e.FechaSolicitud)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_solicitud");

                entity.Property(e => e.IdEquipo).HasColumnName("ID_equipo");

                entity.Property(e => e.IdPlano)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ID_plano");

                entity.Property(e => e.OrdenTrab).HasColumnName("Orden_trab");

                entity.Property(e => e.Payback)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Solicitante)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dicmct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DICMCT");

                entity.Property(e => e.Accion)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("ACCION");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("COMENTARIO");

                entity.Property(e => e.Competencia)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("COMPETENCIA");

                entity.Property(e => e.Conducta)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CONDUCTA");

                entity.Property(e => e.Nivel)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("NIVEL");

                entity.Property(e => e.Preg)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PREG");
            });

            modelBuilder.Entity<Disposicion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Disposicion");

                entity.Property(e => e.Año)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("año");

                entity.Property(e => e.CostoM)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("costo_m");

                entity.Property(e => e.CostoP)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("costo_p");

                entity.Property(e => e.Dia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dia");

                entity.Property(e => e.Mes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mes");

                entity.Property(e => e.PesoRomanaM)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("peso_romana_m");

                entity.Property(e => e.PesoRomanaP)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("peso_romana_p");

                entity.Property(e => e.PlacaVehiculo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("placa_vehiculo");
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.ToTable("Division");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Celda)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DivId).HasColumnName("DivID");

                entity.Property(e => e.Division1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Division");

                entity.Property(e => e.DpartId).HasColumnName("dpartID");

                entity.Property(e => e.Zona)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Divisione>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DepartId).HasColumnName("DepartID");

                entity.Property(e => e.DivDescrip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DivId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DivID");
            });

            modelBuilder.Entity<Dpto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dpto");

                entity.Property(e => e.Departamento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idpais).HasColumnName("idpais");
            });

            modelBuilder.Entity<EfiDiarium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("efi_diaria");

                entity.Property(e => e.Eficiencia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("eficiencia");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grupo");

                entity.Property(e => e.Turno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("turno");
            });

            modelBuilder.Entity<EfiMensual>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("efi_mensual");

                entity.Property(e => e.Añomes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("añomes");

                entity.Property(e => e.EfiMensual1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("efi_mensual");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grupo");
            });

            modelBuilder.Entity<EficienciaBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Eficiencia_bk");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EficId).HasColumnName("EficID");

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.Fecha1)
                    .HasColumnType("date")
                    .HasColumnName("fecha1");

                entity.Property(e => e.FechaBpcs).HasColumnName("fechaBPCS");
            });

            modelBuilder.Entity<Eficiencium>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Campo1).HasColumnName("campo1");

                entity.Property(e => e.Campo2).HasColumnName("campo2");

                entity.Property(e => e.EfObjA)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Objetivo A");

                entity.Property(e => e.EfObjB)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Objetivo B");

                entity.Property(e => e.EfObjC)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Objetivo C");

                entity.Property(e => e.EfObjD)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Objetivo D");

                entity.Property(e => e.EfObjTotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Objetivo Total");

                entity.Property(e => e.EfUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EfechHora)
                    .HasColumnType("datetime")
                    .HasColumnName("EFechHora");

                entity.Property(e => e.EficA).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.EficB).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.EficC).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.EficD).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.EficId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EficID");

                entity.Property(e => e.EficTotal).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Fecha1).HasColumnName("fecha1");
            });

            modelBuilder.Entity<Equipo>(entity =>
            {
                entity.HasKey(e => e.IdEquipo);

                entity.Property(e => e.IdEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Id_equipo");

                entity.Property(e => e.IdMaq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Id_Maq");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fabrica>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Fabrica");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<FactoryMutual>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("factory_mutual");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Avance)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("avance");

                entity.Property(e => e.Coordinador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coordinador");

                entity.Property(e => e.Costo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("costo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Dpto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dpto");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha");

                entity.Property(e => e.FechaApe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha_ape");

                entity.Property(e => e.FechaCie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha_cie");

                entity.Property(e => e.FechaRev)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha_rev");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.Resp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("resp");

                entity.Property(e => e.Riskmc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("riskmc");

                entity.Property(e => e.Riskmp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("riskmp");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<FactoryMutualRespaldo>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("factory_mutual_respaldo");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Avance)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("avance");

                entity.Property(e => e.Coordinador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coordinador");

                entity.Property(e => e.Costo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("costo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Dpto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dpto");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha");

                entity.Property(e => e.FechaApe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha_ape");

                entity.Property(e => e.FechaCie)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha_cie");

                entity.Property(e => e.FechaRev)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha_rev");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("observaciones");

                entity.Property(e => e.Resp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("resp");

                entity.Property(e => e.Riskmc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("riskmc");

                entity.Property(e => e.Riskmp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("riskmp");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<Fifo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FIFO");

                entity.Property(e => e.Area)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CampoA)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CampoB)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CampoC)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CantLotes)
                    .HasColumnType("numeric(30, 4)")
                    .HasColumnName("Cant_lotes");

                entity.Property(e => e.Consumido).HasColumnType("numeric(30, 4)");

                entity.Property(e => e.CumplimientoFifo)
                    .HasColumnType("numeric(30, 4)")
                    .HasColumnName("Cumplimiento_FIFO");

                entity.Property(e => e.Directas).HasColumnType("numeric(30, 4)");

                entity.Property(e => e.Discrepancias).HasColumnType("numeric(30, 4)");

                entity.Property(e => e.Efectividad).HasColumnType("numeric(30, 4)");

                entity.Property(e => e.EficienciaFifo)
                    .HasColumnType("numeric(30, 4)")
                    .HasColumnName("Eficiencia_FIFO");

                entity.Property(e => e.EnDiscrepancia)
                    .HasColumnType("numeric(30, 4)")
                    .HasColumnName("En_Discrepancia");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Fecha1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaA)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Fecha_A");

                entity.Property(e => e.Producto)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Form1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Form1");

                entity.Property(e => e.C1)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.C2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CampoA)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Campo_A");

                entity.Property(e => e.CampoB)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Campo_B");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdSpa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_spa");

                entity.Property(e => e.Nt)
                    .HasColumnType("numeric(30, 4)")
                    .HasColumnName("NT");

                entity.Property(e => e.Responsable)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Turno).HasColumnName("turno");
            });

            modelBuilder.Entity<Form2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Form2");

                entity.Property(e => e.Accion)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("area");

                entity.Property(e => e.C1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.C2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Discrepancia)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.Equipo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaGrabado)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_grabado");

                entity.Property(e => e.Ficha)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ficha");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grupo");

                entity.Property(e => e.IdSpa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_spa");

                entity.Property(e => e.IdSpa2).HasColumnName("ID_SPA2");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Odt).HasColumnName("ODT");

                entity.Property(e => e.Odt1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ODT1");

                entity.Property(e => e.PersonalHn).HasColumnName("PersonalHN");

                entity.Property(e => e.PersonalHs).HasColumnName("PersonalHS");

                entity.Property(e => e.Responsable)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Turno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("turno");

                entity.Property(e => e.UO)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("U_O");
            });

            modelBuilder.Entity<Formulacion>(entity =>
            {
                entity.ToTable("formulacion");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdSol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_sol");

                entity.Property(e => e.Item)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("item");

                entity.Property(e => e.Porcentaje)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("porcentaje");

                entity.Property(e => e.Texto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("texto");
            });

            modelBuilder.Entity<HisEcDium>(entity =>
            {
                entity.HasKey(e => e.HeCodU);

                entity.Property(e => e.HeFecha).HasColumnType("date");
            });

            modelBuilder.Entity<HistAreaIi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hist_area_ii");

                entity.Property(e => e.AhoAcu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aho_acu");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("area");

                entity.Property(e => e.Año)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("año");

                entity.Property(e => e.SatisAcu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("satis_acu");
            });

            modelBuilder.Entity<HistAreaIiPanasa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hist_area_ii_panasa");

                entity.Property(e => e.AhoAcu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aho_acu");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("area");

                entity.Property(e => e.Año)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("año");

                entity.Property(e => e.SatisAcu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("satis_acu");
            });

            modelBuilder.Entity<HistIngInd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hist_ing_ind");

                entity.Property(e => e.AhoAcu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aho_acu");

                entity.Property(e => e.Año)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("año");

                entity.Property(e => e.Ficha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ficha");

                entity.Property(e => e.Nomsol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomsol");

                entity.Property(e => e.SatisAcu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("satis_acu");
            });

            modelBuilder.Entity<Hito>(entity =>
            {
                entity.ToTable("hitos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Archivo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("archivo");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod");

                entity.Property(e => e.Ent)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ent");

                entity.Property(e => e.Fecent)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecent");

                entity.Property(e => e.Item).HasColumnName("item");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Planacc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("planacc");
            });

            modelBuilder.Entity<HitosPanasa>(entity =>
            {
                entity.ToTable("hitos_panasa");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Archivo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("archivo");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod");

                entity.Property(e => e.Ent)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ent");

                entity.Property(e => e.Fecent)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecent");

                entity.Property(e => e.Item).HasColumnName("item");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Planacc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("planacc");
            });

            modelBuilder.Entity<HorasIp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("horas_ip");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod");

                entity.Property(e => e.Dia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dia");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha");

                entity.Property(e => e.Ficha)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ficha");

                entity.Property(e => e.Hn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hn");

                entity.Property(e => e.Hst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hst");

                entity.Property(e => e.Sup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sup");
            });

            modelBuilder.Entity<HorasIpPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("horas_ip_plan");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod");

                entity.Property(e => e.Dia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dia");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha");

                entity.Property(e => e.Ficha)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ficha");

                entity.Property(e => e.Hn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hn");

                entity.Property(e => e.Hst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hst");

                entity.Property(e => e.Sup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sup");
            });

            modelBuilder.Entity<Idea>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoordinadorProy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Coordinador_proy");

                entity.Property(e => e.Criticidad)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("criticidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Factibilidad)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBpcs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FechaBPCS");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Linea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProyecto)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_proyecto");

                entity.Property(e => e.NumProy).HasColumnName("Num_proy");

                entity.Property(e => e.Obj1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Obj2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Obj3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Obj4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Obj5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Obj6)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Obj7)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Obj8)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reconocimiento)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Resp1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Resp2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Resp3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Resp4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Resp5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Solucion)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Spa).HasColumnName("SPA");

                entity.Property(e => e.StideaId).HasColumnName("STideaID");

                entity.Property(e => e.Validacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IndGte>(entity =>
            {
                entity.ToTable("Ind_gte");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Act)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Dpto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Indicador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Um)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UM");
            });

            modelBuilder.Entity<InformesCalidad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Informes_calidad");

                entity.Property(e => e.Cargado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargado");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Ruta)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ruta");
            });

            modelBuilder.Entity<Joel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Joel");

                entity.Property(e => e.Campo1)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("campo1");

                entity.Property(e => e.Campo2)
                    .HasColumnType("date")
                    .HasColumnName("campo2");

                entity.Property(e => e.Campo3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("campo3");

                entity.Property(e => e.Campo4).HasColumnName("campo4");
            });

            modelBuilder.Entity<Maquina>(entity =>
            {
                entity.HasKey(e => e.IdMaq);

                entity.Property(e => e.IdMaq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Id_Maq");

                entity.Property(e => e.DivId).HasColumnName("divID");

                entity.Property(e => e.Dpto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EqpId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("eqpID");

                entity.Property(e => e.Zona)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaterialEnsayo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("material_ensayo");

                entity.Property(e => e.Contenido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contenido");

                entity.Property(e => e.IdSol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_sol");

                entity.Property(e => e.IdTxt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_txt");
            });

            modelBuilder.Entity<Mcarga>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MCarga");

                entity.Property(e => e.A1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.A2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.A3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.A4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.A5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.A6)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aireacond)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AIREACOND");

                entity.Property(e => e.Alternador)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ALTERNADOR");

                entity.Property(e => e.Ar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AR");

                entity.Property(e => e.Asiento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.B1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.B2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.B3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.B4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.B5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Batería)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Be)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BE");

                entity.Property(e => e.Bornes)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BORNES");

                entity.Property(e => e.Capot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CAPOT");

                entity.Property(e => e.CargaFin)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CargaInic)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cauchos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clamjaiba)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLAMJAIBA");

                entity.Property(e => e.Cocteleras)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COD_equipo");

                entity.Property(e => e.Comp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COMP");

                entity.Property(e => e.Corneta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CS");

                entity.Property(e => e.Ctr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CTR");

                entity.Property(e => e.Extintor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fah)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAH");

                entity.Property(e => e.Fam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAM");

                entity.Property(e => e.Fci)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FCI");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FM");

                entity.Property(e => e.Fr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FR");

                entity.Property(e => e.Frenos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fte)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTE");

                entity.Property(e => e.Gasoil)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GASOIL");

                entity.Property(e => e.Gg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GG");

                entity.Property(e => e.Gobernador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Grupo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Harricana)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HARRICANA");

                entity.Property(e => e.HoraFin).HasColumnType("datetime");

                entity.Property(e => e.HoraInic).HasColumnType("datetime");

                entity.Property(e => e.Horquillas)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hytobo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("HYTOBO");

                entity.Property(e => e.Inc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INC");

                entity.Property(e => e.Ld)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LD");

                entity.Property(e => e.Lt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LT");

                entity.Property(e => e.Machbrake)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MACHBRAKE");

                entity.Property(e => e.Mgiro)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MGIRO");

                entity.Property(e => e.Mordaza)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MORDAZA");

                entity.Property(e => e.Nacv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NACV");

                entity.Property(e => e.Nam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAM");

                entity.Property(e => e.Nash)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NASH");

                entity.Property(e => e.Nlf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NLF");

                entity.Property(e => e.Nrr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NRR");

                entity.Property(e => e.Obs1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS1");

                entity.Property(e => e.Obs10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS10");

                entity.Property(e => e.Obs11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS11");

                entity.Property(e => e.Obs12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS12");

                entity.Property(e => e.Obs13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS13");

                entity.Property(e => e.Obs14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS14");

                entity.Property(e => e.Obs15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS15");

                entity.Property(e => e.Obs16)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS16");

                entity.Property(e => e.Obs17)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS17");

                entity.Property(e => e.Obs18)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS18");

                entity.Property(e => e.Obs19)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS19");

                entity.Property(e => e.Obs2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS2");

                entity.Property(e => e.Obs20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS20");

                entity.Property(e => e.Obs21)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS21");

                entity.Property(e => e.Obs3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS3");

                entity.Property(e => e.Obs4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS4");

                entity.Property(e => e.Obs5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS5");

                entity.Property(e => e.Obs6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS6");

                entity.Property(e => e.Obs7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS7");

                entity.Property(e => e.Obs8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS8");

                entity.Property(e => e.Obs9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBS9");

                entity.Property(e => e.Pasadores)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PASADORES");

                entity.Property(e => e.Ppi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PPI");

                entity.Property(e => e.Prc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRC");

                entity.Property(e => e.Presaceite)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRESACEITE");

                entity.Property(e => e.Retrovisores)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ri)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RI");

                entity.Property(e => e.Sb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SB");

                entity.Property(e => e.Temp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TEMP");

                entity.Property(e => e.Turno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Volt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VOLT");

                entity.Property(e => e.Área)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mcconductuale>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MCConductuales");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Competencia)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dpto)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMPRESA");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Spi)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SPI");
            });

            modelBuilder.Entity<Mctecnica>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MCTECNICAS");

                entity.Property(e => e.CargoMatriz)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CARGO_MATRIZ");

                entity.Property(e => e.CargosSpi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CARGOS_SPI");

                entity.Property(e => e.Codigo)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Codigo2)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CODIGO2");

                entity.Property(e => e.CompetenciasTecnicas)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("COMPETENCIAS_TECNICAS");

                entity.Property(e => e.Dominio)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("DOMINIO");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMPRESA");

                entity.Property(e => e.UnidadOrganizativa)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UNIDAD_ORGANIZATIVA");
            });

            modelBuilder.Entity<Meta>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AhoAcu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AhoTotal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ahotrimestre1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ahotrimestre1");

                entity.Property(e => e.Ahotrimestre2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ahotrimestre2");

                entity.Property(e => e.Ahotrimestre3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ahotrimestre3");

                entity.Property(e => e.Ahotrimestre4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ahotrimestre4");

                entity.Property(e => e.MetaAhorro)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MetaSatisfaccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SatisAcu)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MetasIp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MetasIP");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MetaRedu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MetaSatisfaccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReduAcu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SatisAcu)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MetasPanasa>(entity =>
            {
                entity.ToTable("Metas_panasa");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AhoAcu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AhoTotal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ahotrimestre1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ahotrimestre1");

                entity.Property(e => e.Ahotrimestre2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ahotrimestre2");

                entity.Property(e => e.Ahotrimestre3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ahotrimestre3");

                entity.Property(e => e.Ahotrimestre4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ahotrimestre4");

                entity.Property(e => e.MetaAhorro)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MetaSatisfaccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SatisAcu)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Minuta>(entity =>
            {
                entity.Property(e => e.MinutaId).HasColumnName("Minuta_Id");

                entity.Property(e => e.Cc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cc");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecProxReunion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Prox_Reunion");

                entity.Property(e => e.FecReunion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Reunion");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Para)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("para");

                entity.Property(e => e.Solicitante)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MinutasIp>(entity =>
            {
                entity.HasKey(e => e.MinutaId);

                entity.ToTable("MinutasIP");

                entity.Property(e => e.MinutaId)
                    .ValueGeneratedNever()
                    .HasColumnName("Minuta_Id");

                entity.Property(e => e.Cc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cc");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecProxReunion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Prox_Reunion");

                entity.Property(e => e.FecReunion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Reunion");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Para)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("para");

                entity.Property(e => e.Solicitante)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MinutasPanasa>(entity =>
            {
                entity.HasKey(e => e.MinutaId);

                entity.ToTable("Minutas_panasa");

                entity.Property(e => e.MinutaId)
                    .ValueGeneratedNever()
                    .HasColumnName("Minuta_Id");

                entity.Property(e => e.Cc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cc");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecProxReunion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Prox_Reunion");

                entity.Property(e => e.FecReunion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Reunion");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Para)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("para");

                entity.Property(e => e.Solicitante)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MinutasSsl>(entity =>
            {
                entity.HasKey(e => e.Fecha);

                entity.ToTable("MinutasSSL");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fecha");

                entity.Property(e => e.Ciemp1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ciemp1");

                entity.Property(e => e.Ciemp2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ciemp2");

                entity.Property(e => e.Ciemp3)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ciemp3");

                entity.Property(e => e.Ciemp4)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ciemp4");

                entity.Property(e => e.Ciemp5)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ciemp5");

                entity.Property(e => e.Cipre1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cipre1");

                entity.Property(e => e.Cipre2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cipre2");

                entity.Property(e => e.Cipre3)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cipre3");

                entity.Property(e => e.Cipre4)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cipre4");

                entity.Property(e => e.Cipre5)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cipre5");

                entity.Property(e => e.Cisin1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cisin1");

                entity.Property(e => e.Cissl1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cissl1");

                entity.Property(e => e.Cissl2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cissl2");

                entity.Property(e => e.Encabezado)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("encabezado");

                entity.Property(e => e.Fechaenc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fechaenc");

                entity.Property(e => e.Int1)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("int1");

                entity.Property(e => e.Int2)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("int2");

                entity.Property(e => e.Int3)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("int3");

                entity.Property(e => e.Int4)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("int4");

                entity.Property(e => e.Int5)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("int5");

                entity.Property(e => e.Nomemp1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nomemp1");

                entity.Property(e => e.Nomemp2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nomemp2");

                entity.Property(e => e.Nomemp3)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nomemp3");

                entity.Property(e => e.Nomemp4)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nomemp4");

                entity.Property(e => e.Nomemp5)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nomemp5");

                entity.Property(e => e.Nompre1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nompre1");

                entity.Property(e => e.Nompre2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nompre2");

                entity.Property(e => e.Nompre3)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nompre3");

                entity.Property(e => e.Nompre4)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nompre4");

                entity.Property(e => e.Nompre5)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nompre5");

                entity.Property(e => e.Nomsin1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nomsin1");

                entity.Property(e => e.Nomssl1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nomssl1");

                entity.Property(e => e.Nomssl2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nomssl2");

                entity.Property(e => e.Obs)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("obs");

                entity.Property(e => e.Obs1)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("obs1");

                entity.Property(e => e.Obs2)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("obs2");

                entity.Property(e => e.Obs3)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("obs3");

                entity.Property(e => e.Obs4)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("obs4");

                entity.Property(e => e.Obs5)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("obs5");

                entity.Property(e => e.Otro)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("otro");

                entity.Property(e => e.Pto1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pto1");

                entity.Property(e => e.Pto2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pto2");

                entity.Property(e => e.Pto3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pto3");

                entity.Property(e => e.Pto4)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pto4");

                entity.Property(e => e.Pto5)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pto5");
            });

            modelBuilder.Entity<NovMolino>(entity =>
            {
                entity.ToTable("Nov_Molino");

                entity.Property(e => e.Celda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("celda");

                entity.Property(e => e.Division)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("division");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grupo");

                entity.Property(e => e.Herra)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("herra");

                entity.Property(e => e.Molino)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("molino");

                entity.Property(e => e.Obsherra)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("obsherra");

                entity.Property(e => e.Obssegui)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("obssegui");

                entity.Property(e => e.Segui)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segui");

                entity.Property(e => e.Turno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("turno");
            });

            modelBuilder.Entity<NovMolinoDetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Nov_Molino_detalle");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Equipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("equipo");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdNov)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_nov");

                entity.Property(e => e.Nomoper)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomoper");
            });

            modelBuilder.Entity<NovMolinoShellsol>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Nov_Molino_shellsol");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Item)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("item");

                entity.Property(e => e.Molino)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("molino");

                entity.Property(e => e.Shellsol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("shellsol");
            });

            modelBuilder.Entity<Novedade>(entity =>
            {
                entity.ToTable("NOVEDADES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accion)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.CampoA)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("Campo_A");

                entity.Property(e => e.CampoB)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Campo_B");

                entity.Property(e => e.CausaRaiz)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("Causa_Raiz");

                entity.Property(e => e.Concatena)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Criticidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescTipocausa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Desc_tipocausa");

                entity.Property(e => e.Div)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dpto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAcertividad).HasColumnName("Fecha_acertividad");

                entity.Property(e => e.FechaAcertividad1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fecha_acertividad_1");

                entity.Property(e => e.FechaProgramada)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fecha_Programada");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCausa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCausa2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCausa3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID_Equipo");

                entity.Property(e => e.IdMaquina)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID_Maquina");

                entity.Property(e => e.IdSpa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID_SPA");

                entity.Property(e => e.IdTipoCausa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ksf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KSF");

                entity.Property(e => e.NomEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Equipo");

                entity.Property(e => e.NomMaquina)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Maquina");

                entity.Property(e => e.Novedad)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.Nt)
                    .HasColumnType("numeric(30, 4)")
                    .HasColumnName("NT");

                entity.Property(e => e.NvcodArt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NVCodArt")
                    .HasComment("Codigo del Articulo");

                entity.Property(e => e.Nvhora)
                    .HasColumnType("datetime")
                    .HasColumnName("NVHora");

                entity.Property(e => e.Odt)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ODT");

                entity.Property(e => e.PersonaEvaluar)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Persona_Evaluar");

                entity.Property(e => e.PlanAccionRaiz)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("Plan_Accion_Raiz");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Turno)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NovedadesPlantum>(entity =>
            {
                entity.ToTable("novedades_planta");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accion)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("ACCION");

                entity.Property(e => e.Avparcial)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("AVPARCIAL");

                entity.Property(e => e.Avtotal)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("AVTOTAL");

                entity.Property(e => e.CampoA)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("Campo_A");

                entity.Property(e => e.CampoB)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Campo_B");

                entity.Property(e => e.Concatena)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONCATENA");

                entity.Property(e => e.Div)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIV");

                entity.Property(e => e.Dpto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DPTO");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FECHA");

                entity.Property(e => e.FechaProgramada)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fecha_Programada");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GRUPO");

                entity.Property(e => e.GrupoAvance)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GRUPO_AVANCE");

                entity.Property(e => e.IdEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID_EQUIPO");

                entity.Property(e => e.IdMaquina)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID_MAQUINA");

                entity.Property(e => e.IdSpa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_spa");

                entity.Property(e => e.NomEquipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOM_EQUIPO");

                entity.Property(e => e.NomMaquina)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOM_MAQUINA");

                entity.Property(e => e.NovCalific)
                    .HasColumnType("decimal(5, 2)")
                    .HasComment("Calificacion");

                entity.Property(e => e.Novedad)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("NOVEDAD");

                entity.Property(e => e.Nt)
                    .HasColumnType("numeric(30, 4)")
                    .HasColumnName("NT");

                entity.Property(e => e.Odt)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ODT");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR");

                entity.Property(e => e.Turno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TURNO");
            });

            modelBuilder.Entity<ObPrConver>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ObPrConver");

                entity.Property(e => e.OcBotella)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OcCprod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OcDescrip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OcFcorreci).HasColumnName("OcFCorreci");

                entity.Property(e => e.OcFecha).HasColumnType("datetime");

                entity.Property(e => e.OcNhojas).HasColumnName("OcNHojas");

                entity.Property(e => e.OcPcaja).HasColumnName("OcPCaja");

                entity.Property(e => e.OcRpaquete).HasColumnName("OcRPaquete");

                entity.Property(e => e.OcTipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OcUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObjProd>(entity =>
            {
                entity.ToTable("obj_prod");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cajas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cajas");

                entity.Property(e => e.CajasEfic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cajas_efic");

                entity.Property(e => e.Celda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("celda");

                entity.Property(e => e.Producto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("producto");
            });

            modelBuilder.Entity<ObsSsl>(entity =>
            {
                entity.ToTable("obs_ssl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha");

                entity.Property(e => e.Obs)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("obs");
            });

            modelBuilder.Entity<Oportunidad>(entity =>
            {
                entity.ToTable("Oportunidad");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Analisis)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("ANALISIS");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AREA");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FECHA");

                entity.Property(e => e.Linea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LINEA");

                entity.Property(e => e.NomOpe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOM_OPE");

                entity.Property(e => e.NomOpo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOM_OPO");

                entity.Property(e => e.NumProy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NUM_PROY");

                entity.Property(e => e.NumSpa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NUM_SPA");

                entity.Property(e => e.Propuesta)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("PROPUESTA");

                entity.Property(e => e.Puesto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PUESTO");

                entity.Property(e => e.Reconocimiento)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("RECONOCIMIENTO");

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR");
            });

            modelBuilder.Entity<OportunidadPanasa>(entity =>
            {
                entity.ToTable("Oportunidad_panasa");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Analisis)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("ANALISIS");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AREA");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FECHA");

                entity.Property(e => e.Linea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LINEA");

                entity.Property(e => e.NomOpe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOM_OPE");

                entity.Property(e => e.NomOpo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOM_OPO");

                entity.Property(e => e.NumProy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NUM_PROY");

                entity.Property(e => e.NumSpa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NUM_SPA");

                entity.Property(e => e.Propuesta)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("PROPUESTA");

                entity.Property(e => e.Puesto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PUESTO");

                entity.Property(e => e.Reconocimiento)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("RECONOCIMIENTO");

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR");
            });

            modelBuilder.Entity<Pai>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Idpais)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idpais");

                entity.Property(e => e.PaDescrip)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PartesEquipo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Partes_equipos");

                entity.Property(e => e.Compañia)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Div)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Dpto)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdControl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ID_Control");

                entity.Property(e => e.IdEquipo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ID_Equipo");

                entity.Property(e => e.Linea)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersonalCalidad>(entity =>
            {
                entity.HasKey(e => e.Ficha);

                entity.ToTable("personal_calidad");

                entity.Property(e => e.Ficha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ficha");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo");

                entity.Property(e => e.Ci)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ci");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Dpto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dpto");

                entity.Property(e => e.Ext)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ext");

                entity.Property(e => e.FecIng)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fec_ing");

                entity.Property(e => e.FecNac)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fec_nac");

                entity.Property(e => e.NomFoto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nom_foto");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombres");

                entity.Property(e => e.RutaFoto)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ruta_foto");

                entity.Property(e => e.TlfHab)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tlf_hab");

                entity.Property(e => e.TlfMovil)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tlf_movil");
            });

            modelBuilder.Entity<PlanAccionGerenciaPanasa>(entity =>
            {
                entity.ToTable("plan_accion_gerencia_panasa");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Avance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("avance");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecfin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecfin");

                entity.Property(e => e.Finalizado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("finalizado");

                entity.Property(e => e.Item).HasColumnName("item");

                entity.Property(e => e.PlanAcc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("plan_acc");

                entity.Property(e => e.Resp)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("resp");
            });

            modelBuilder.Entity<PlanAccionGerencium>(entity =>
            {
                entity.ToTable("plan_accion_gerencia");

                entity.Property(e => e.Avance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("avance");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecfin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecfin");

                entity.Property(e => e.Finalizado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("finalizado");

                entity.Property(e => e.Item).HasColumnName("item");

                entity.Property(e => e.PlanAcc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("plan_acc");

                entity.Property(e => e.Resp)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("resp");
            });

            modelBuilder.Entity<PlanesGte>(entity =>
            {
                entity.ToTable("planes_gte");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Descripcion1)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION1");

                entity.Property(e => e.Descripcion2)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION2");

                entity.Property(e => e.Descripcion3)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION3");

                entity.Property(e => e.Fecha1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FECHA1");

                entity.Property(e => e.Fecha2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FECHA2");

                entity.Property(e => e.Fecha3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FECHA3");

                entity.Property(e => e.Problema)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("PROBLEMA");

                entity.Property(e => e.Problema2)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("PROBLEMA2");

                entity.Property(e => e.Resp1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RESP1");

                entity.Property(e => e.Resp2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RESP2");

                entity.Property(e => e.Resp3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RESP3");

                entity.Property(e => e.Result1)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("RESULT1");

                entity.Property(e => e.Result2)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("RESULT2");

                entity.Property(e => e.Result3)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("RESULT3");
            });

            modelBuilder.Entity<PlanesPlantaSptte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("planes_planta_sptte");

                entity.Property(e => e.Contencion)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("CONTENCION");

                entity.Property(e => e.Correccion)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("CORRECCION");

                entity.Property(e => e.Discrepancia)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("DISCREPANCIA");

                entity.Property(e => e.Fechafin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FECHAFIN");

                entity.Property(e => e.Fechaini)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FECHAINI");

                entity.Property(e => e.Id)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Linea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LINEA");

                entity.Property(e => e.Objetivo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJETIVO");

                entity.Property(e => e.Prevencion)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("PREVENCION");

                entity.Property(e => e.Real)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REAL");

                entity.Property(e => e.Sptte)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SPTTE");

                entity.Property(e => e.Ttdte).HasColumnName("TTDTE");

                entity.Property(e => e.Variable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VARIABLE");
            });

            modelBuilder.Entity<PlanesPlantum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("planes_planta");

                entity.Property(e => e.Accion)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("ACCION");

                entity.Property(e => e.Dis)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DIS");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FECHA");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRUPO");

                entity.Property(e => e.Linea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LINEA");

                entity.Property(e => e.Objetivo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJETIVO");

                entity.Property(e => e.Problema)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("PROBLEMA");

                entity.Property(e => e.Real)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REAL");

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR");

                entity.Property(e => e.Ttdte).HasColumnName("TTDTE");

                entity.Property(e => e.Turno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURNO");

                entity.Property(e => e.Variable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VARIABLE");
            });

            modelBuilder.Entity<PrecioPt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Precio_PT");

                entity.Property(e => e.CodigoProd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Codigo_prod");

                entity.Property(e => e.PrecioUnitarioSv)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Precio_unitario_SV");
            });

            modelBuilder.Entity<PrepagoDisp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Prepago_Disp");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.Fecha2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha2");

                entity.Property(e => e.Prepago).HasColumnName("prepago");
            });

            modelBuilder.Entity<Prioridad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("prioridad");

                entity.Property(e => e.Ambiente)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ambiente");

                entity.Property(e => e.Calidad)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("calidad");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod");

                entity.Property(e => e.Costos)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("costos");

                entity.Property(e => e.Exposicion)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("exposicion");

                entity.Property(e => e.Legal)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("legal");

                entity.Property(e => e.Ocurrencia)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ocurrencia");

                entity.Property(e => e.Ordenamientos)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ordenamientos");

                entity.Property(e => e.Produccion)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("produccion");

                entity.Property(e => e.Retorno)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("retorno");

                entity.Property(e => e.Ssl)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ssl");
            });

            modelBuilder.Entity<PrioridadPanasa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("prioridad_panasa");

                entity.Property(e => e.Ambiente)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ambiente");

                entity.Property(e => e.Calidad)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("calidad");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod");

                entity.Property(e => e.Costos)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("costos");

                entity.Property(e => e.Exposicion)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("exposicion");

                entity.Property(e => e.Legal)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("legal");

                entity.Property(e => e.Ocurrencia)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ocurrencia");

                entity.Property(e => e.Ordenamientos)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ordenamientos");

                entity.Property(e => e.Produccion)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("produccion");

                entity.Property(e => e.Retorno)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("retorno");

                entity.Property(e => e.Ssl)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ssl");
            });

            modelBuilder.Entity<ProdDiv4>(entity =>
            {
                entity.ToTable("Prod_div4");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FECHA");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GRUPO");

                entity.Property(e => e.Maquina)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAQUINA");

                entity.Property(e => e.Produccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCCION");

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUPERVISOR");

                entity.Property(e => e.Turno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TURNO");
            });

            modelBuilder.Entity<ProyGerenciaPanasa>(entity =>
            {
                entity.HasKey(e => e.Cod);

                entity.ToTable("ProyGerencia_panasa");

                entity.Property(e => e.Cod).ValueGeneratedNever();

                entity.Property(e => e.Abr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("abr");

                entity.Property(e => e.Ago)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ago");

                entity.Property(e => e.Avance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("avance");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cliente");

                entity.Property(e => e.Codii)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codii");

                entity.Property(e => e.Des)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("des");

                entity.Property(e => e.Dic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dic");

                entity.Property(e => e.Ene)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ene");

                entity.Property(e => e.Est)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("est");

                entity.Property(e => e.Feb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("feb");

                entity.Property(e => e.Fecfin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecfin");

                entity.Property(e => e.Gant)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gant");

                entity.Property(e => e.Jul)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("jul");

                entity.Property(e => e.Jun)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("jun");

                entity.Property(e => e.Mar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mar");

                entity.Property(e => e.May)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("may");

                entity.Property(e => e.Nomproy)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nov)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nov");

                entity.Property(e => e.Oct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("oct");

                entity.Property(e => e.Prioridad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prioridad");

                entity.Property(e => e.Sep)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sep");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");

                entity.Property(e => e.Validacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("validacion");
            });

            modelBuilder.Entity<ProyGerencium>(entity =>
            {
                entity.HasKey(e => e.Cod);

                entity.Property(e => e.Abr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("abr");

                entity.Property(e => e.Ago)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ago");

                entity.Property(e => e.Avance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("avance");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cliente");

                entity.Property(e => e.Codii)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codii");

                entity.Property(e => e.Des)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("des");

                entity.Property(e => e.Dic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dic");

                entity.Property(e => e.Ene)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ene");

                entity.Property(e => e.Est)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("est");

                entity.Property(e => e.Feb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("feb");

                entity.Property(e => e.Fecfin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecfin");

                entity.Property(e => e.Gant)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gant");

                entity.Property(e => e.Jul)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("jul");

                entity.Property(e => e.Jun)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("jun");

                entity.Property(e => e.Mar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mar");

                entity.Property(e => e.May)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("may");

                entity.Property(e => e.Nomproy)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nov)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nov");

                entity.Property(e => e.Oct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("oct");

                entity.Property(e => e.Prioridad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prioridad");

                entity.Property(e => e.Sep)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sep");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");

                entity.Property(e => e.Validacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("validacion");
            });

            modelBuilder.Entity<Proyecto>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Proyecto_1");

                entity.ToTable("Proyecto");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AhorroClie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AhorroIng)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AhorroTotalProy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AltFin)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AreaSol)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Añofin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("añofin");

                entity.Property(e => e.Añoini)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("añoini");

                entity.Property(e => e.CenCos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusProyecto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Estatus_Proyecto");

                entity.Property(e => e.FecApro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Apro");

                entity.Property(e => e.FecCulEst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Cul_Est");

                entity.Property(e => e.FecCulReal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Cul_Real");

                entity.Property(e => e.FecImplementacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Implementacion");

                entity.Property(e => e.FecParada)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Parada");

                entity.Property(e => e.Fecact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecact");

                entity.Property(e => e.Finalizado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FreRepRes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fre_Rep_Res");

                entity.Property(e => e.Hhsem1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HHsem1");

                entity.Property(e => e.Hhsem2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HHsem2");

                entity.Property(e => e.Hhsem3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HHsem3");

                entity.Property(e => e.Hhsem4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HHsem4");

                entity.Property(e => e.Hhsem5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HHsem5");

                entity.Property(e => e.Horaact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("horaact");

                entity.Property(e => e.MetMedRes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nivel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomProy)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Proy");

                entity.Property(e => e.NomSol)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObjGral)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Obj_Gral");

                entity.Property(e => e.Obs)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PorcAporteIngInd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PorcCli)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Porefic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("porefic");

                entity.Property(e => e.Problema)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Progreso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SolicitudId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Solicitud_Id");

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProyecto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Validacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProyectoIp>(entity =>
            {
                entity.HasKey(e => e.Cod);

                entity.ToTable("Proyecto_IP");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod");

                entity.Property(e => e.Areasol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("areasol");

                entity.Property(e => e.Asignado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("asignado");

                entity.Property(e => e.Avance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("avance");

                entity.Property(e => e.Bscc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bscc");

                entity.Property(e => e.Bsce)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bsce");

                entity.Property(e => e.Bscg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bscg");

                entity.Property(e => e.Bsci)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bsci");

                entity.Property(e => e.Bscm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bscm");

                entity.Property(e => e.Clasificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clasificacion");

                entity.Property(e => e.Clasificacion1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clasificacion1");

                entity.Property(e => e.Concc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("concc");

                entity.Property(e => e.Conce)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("conce");

                entity.Property(e => e.Concg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("concg");

                entity.Property(e => e.Conci)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("conci");

                entity.Property(e => e.Concm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("concm");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estproy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estproy");

                entity.Property(e => e.Fecapro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecapro");

                entity.Property(e => e.Fecestcul)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecestcul");

                entity.Property(e => e.Fecimp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecimp");

                entity.Property(e => e.Fecini)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecini");

                entity.Property(e => e.Fecparada)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecparada");

                entity.Property(e => e.Fecrealcul)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecrealcul");

                entity.Property(e => e.Frerep)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("frerep");

                entity.Property(e => e.H1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("h1");

                entity.Property(e => e.H2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("h2");

                entity.Property(e => e.H3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("h3");

                entity.Property(e => e.H4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("h4");

                entity.Property(e => e.H5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("h5");

                entity.Property(e => e.Nivel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nivel");

                entity.Property(e => e.Nomproy)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nomproy");

                entity.Property(e => e.Nomsol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomsol");

                entity.Property(e => e.Obssem)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("obssem");

                entity.Property(e => e.Odt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("odt");

                entity.Property(e => e.Odtcc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("odtcc");

                entity.Property(e => e.Odtce)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("odtce");

                entity.Property(e => e.Odtcg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("odtcg");

                entity.Property(e => e.Odtci)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("odtci");

                entity.Property(e => e.Odtcm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("odtcm");

                entity.Property(e => e.Porefic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("porefic");

                entity.Property(e => e.Porpza)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("porpza");

                entity.Property(e => e.Porred)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("porred");

                entity.Property(e => e.Prioridad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prioridad");

                entity.Property(e => e.Res1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("res1");

                entity.Property(e => e.Res2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("res2");

                entity.Property(e => e.Res3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("res3");

                entity.Property(e => e.Res4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("res4");

                entity.Property(e => e.Res5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("res5");

                entity.Property(e => e.Resdpto)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("resdpto");

                entity.Property(e => e.Sup1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sup1");

                entity.Property(e => e.Sup2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sup2");

                entity.Property(e => e.Tasa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tasa");

                entity.Property(e => e.Tipoproy1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoproy1");

                entity.Property(e => e.Tipoproy2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoproy2");

                entity.Property(e => e.Tipoproy3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoproy3");

                entity.Property(e => e.Tipoproy4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoproy4");

                entity.Property(e => e.Tipoproy5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoproy5");

                entity.Property(e => e.Totalbs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("totalbs");

                entity.Property(e => e.Totalus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("totalus");

                entity.Property(e => e.Uscc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("uscc");

                entity.Property(e => e.Usce)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usce");

                entity.Property(e => e.Uscg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("uscg");

                entity.Property(e => e.Usci)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usci");

                entity.Property(e => e.Uscm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("uscm");

                entity.Property(e => e.Validacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("validacion");

                entity.Property(e => e.Wo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("wo");
            });

            modelBuilder.Entity<ProyectoPanasa>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("Proyecto_panasa");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AhorroClie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AhorroIng)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AhorroTotalProy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AltFin)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AreaSol)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Añofin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("añofin");

                entity.Property(e => e.Añoini)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("añoini");

                entity.Property(e => e.CenCos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusProyecto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Estatus_Proyecto");

                entity.Property(e => e.FecApro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Apro");

                entity.Property(e => e.FecCulEst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Cul_Est");

                entity.Property(e => e.FecCulReal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Cul_Real");

                entity.Property(e => e.FecImplementacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Implementacion");

                entity.Property(e => e.FecParada)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Parada");

                entity.Property(e => e.Fecact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecact");

                entity.Property(e => e.Finalizado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FreRepRes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fre_Rep_Res");

                entity.Property(e => e.Hhsem1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HHsem1");

                entity.Property(e => e.Hhsem2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HHsem2");

                entity.Property(e => e.Hhsem3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HHsem3");

                entity.Property(e => e.Hhsem4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HHsem4");

                entity.Property(e => e.Hhsem5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HHsem5");

                entity.Property(e => e.Horaact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("horaact");

                entity.Property(e => e.MetMedRes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nivel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomProy)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Proy");

                entity.Property(e => e.NomSol)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObjGral)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Obj_Gral");

                entity.Property(e => e.Obs)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PorcAporteIngInd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PorcCli)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Porefic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("porefic");

                entity.Property(e => e.Problema)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Progreso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SolicitudId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Solicitud_Id");

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProyecto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Validacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProyectoRc>(entity =>
            {
                entity.ToTable("Proyecto_RC");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Areasol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("areasol");

                entity.Property(e => e.Avance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("avance");

                entity.Property(e => e.Benpot)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("benpot");

                entity.Property(e => e.Ccasol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ccasol");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Cuenta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cuenta");

                entity.Property(e => e.Estproy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estproy");

                entity.Property(e => e.Feccul)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("feccul");

                entity.Property(e => e.Fecini)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecini");

                entity.Property(e => e.Fecsol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecsol");

                entity.Property(e => e.Formpro)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("formpro");

                entity.Property(e => e.Nomproy)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("nomproy");

                entity.Property(e => e.Nomsol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomsol");

                entity.Property(e => e.Obj)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("obj");

                entity.Property(e => e.Proalt)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("proalt");

                entity.Property(e => e.Resdpto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("resdpto");

                entity.Property(e => e.Validacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("validacion");
            });

            modelBuilder.Entity<ProyectoRcAhoGral>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Proyecto_RC_aho_gral");

                entity.Property(e => e.Ahomes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ahomes");

                entity.Property(e => e.Ahomin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ahomin");

                entity.Property(e => e.Ahormes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ahormes");

                entity.Property(e => e.Areasol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("areasol");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Mes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mes");
            });

            modelBuilder.Entity<ProyectoRcAhorro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Proyecto_RC_ahorros");

                entity.Property(e => e.Ahomes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ahomes");

                entity.Property(e => e.Ahormes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ahormes");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Mes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mes");
            });

            modelBuilder.Entity<ProyectoRespaldo>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("Proyecto_Respaldo");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AhorroClie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AhorroIng)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AhorroTotalProy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AltFin)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AreaSol)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Añofin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("añofin");

                entity.Property(e => e.Añoini)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("añoini");

                entity.Property(e => e.CenCos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusProyecto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Estatus_Proyecto");

                entity.Property(e => e.FecApro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Apro");

                entity.Property(e => e.FecCulEst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Cul_Est");

                entity.Property(e => e.FecCulReal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Cul_Real");

                entity.Property(e => e.FecImplementacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Implementacion");

                entity.Property(e => e.FecParada)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Parada");

                entity.Property(e => e.Fecact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecact");

                entity.Property(e => e.Finalizado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FreRepRes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fre_Rep_Res");

                entity.Property(e => e.Hhsem1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HHsem1");

                entity.Property(e => e.Hhsem2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HHsem2");

                entity.Property(e => e.Hhsem3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HHsem3");

                entity.Property(e => e.Hhsem4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HHsem4");

                entity.Property(e => e.Hhsem5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HHsem5");

                entity.Property(e => e.Horaact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("horaact");

                entity.Property(e => e.MetMedRes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nivel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomProy)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Proy");

                entity.Property(e => e.NomSol)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObjGral)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Obj_Gral");

                entity.Property(e => e.Obs)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PorcAporteIngInd)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PorcCli)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Porefic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("porefic");

                entity.Property(e => e.Problema)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Progreso)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SolicitudId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Solicitud_Id");

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProyecto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Validacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProyectoSsl>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("PK_Proyecto_ssl_comite");

                entity.ToTable("Proyecto_ssl");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod");

                entity.Property(e => e.Avance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("avance");

                entity.Property(e => e.Ben)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ben");

                entity.Property(e => e.Comite)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("comite");

                entity.Property(e => e.Ejecutante)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ejecutante");

                entity.Property(e => e.Estproy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estproy");

                entity.Property(e => e.Factor1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("factor1");

                entity.Property(e => e.Factor2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("factor2");

                entity.Property(e => e.Factor3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("factor3");

                entity.Property(e => e.Factor4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("factor4");

                entity.Property(e => e.Factor5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("factor5");

                entity.Property(e => e.Fecestcul)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecestcul");

                entity.Property(e => e.Fecimp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecimp");

                entity.Property(e => e.Fecini)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecini");

                entity.Property(e => e.Fecrealcul)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecrealcul");

                entity.Property(e => e.Fecsol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecsol");

                entity.Property(e => e.Formulacion)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("formulacion");

                entity.Property(e => e.Frerep)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("frerep");

                entity.Property(e => e.Impacto)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("impacto");

                entity.Property(e => e.Nomproy)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("nomproy");

                entity.Property(e => e.Nomsol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomsol");

                entity.Property(e => e.Objetivo)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("objetivo");

                entity.Property(e => e.Porcum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("porcum");

                entity.Property(e => e.Prioridad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prioridad");

                entity.Property(e => e.Tiempo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tiempo");

                entity.Property(e => e.Validacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("validacion");
            });

            modelBuilder.Entity<RecursosTarea>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Recursos_tareas");

                entity.Property(e => e.IdTarea).HasColumnName("ID_Tarea");

                entity.Property(e => e.Recurso)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Tarea)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TipoRecurso)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Recurso");
            });

            modelBuilder.Entity<RotaCaliV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RotaCali_v");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fecha")
                    .IsFixedLength();

                entity.Property(e => e.Grupo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("grupo")
                    .IsFixedLength();

                entity.Property(e => e.IdGrupo).HasColumnName("Id_grupo");

                entity.Property(e => e.Turno).HasColumnName("turno");
            });

            modelBuilder.Entity<RotaCalidum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Rcfecha).HasColumnName("RCFecha");

                entity.Property(e => e.Rcgrupo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RCGrupo");

                entity.Property(e => e.RcidRotCal).HasColumnName("RCIdRotCal");

                entity.Property(e => e.Rcturno).HasColumnName("RCTurno");
            });

            modelBuilder.Entity<Rotacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Rotacion");

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.Libre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("libre");

                entity.Property(e => e.Turno1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("turno1");

                entity.Property(e => e.Turno2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("turno2");

                entity.Property(e => e.Turno3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("turno3");
            });

            modelBuilder.Entity<RotacionMcbo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Rotacion_mcbo");

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.Libre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("libre");

                entity.Property(e => e.Turno1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("turno1");

                entity.Property(e => e.Turno2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("turno2");
            });

            modelBuilder.Entity<Satisfaccion>(entity =>
            {
                entity.ToTable("Satisfaccion");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.A1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("a1");

                entity.Property(e => e.A2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("a2");

                entity.Property(e => e.C1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("c1");

                entity.Property(e => e.C2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("c2");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod");

                entity.Property(e => e.G1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("g1");

                entity.Property(e => e.I1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("i1");

                entity.Property(e => e.Nivel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nivel");

                entity.Property(e => e.Obs)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("obs");

                entity.Property(e => e.T1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("t1");

                entity.Property(e => e.T2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("t2");
            });

            modelBuilder.Entity<SatisfaccionIp>(entity =>
            {
                entity.ToTable("Satisfaccion_IP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.A1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("a1");

                entity.Property(e => e.A2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("a2");

                entity.Property(e => e.C1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("c1");

                entity.Property(e => e.C2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("c2");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod");

                entity.Property(e => e.G1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("g1");

                entity.Property(e => e.I1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("i1");

                entity.Property(e => e.Nivel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nivel");

                entity.Property(e => e.Obs)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("obs");

                entity.Property(e => e.T1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("t1");

                entity.Property(e => e.T2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("t2");
            });

            modelBuilder.Entity<SatisfaccionPanasa>(entity =>
            {
                entity.ToTable("Satisfaccion_panasa");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.A1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("a1");

                entity.Property(e => e.A2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("a2");

                entity.Property(e => e.C1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("c1");

                entity.Property(e => e.C2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("c2");

                entity.Property(e => e.Cod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cod");

                entity.Property(e => e.G1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("g1");

                entity.Property(e => e.I1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("i1");

                entity.Property(e => e.Nivel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nivel");

                entity.Property(e => e.Obs)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("obs");

                entity.Property(e => e.T1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("t1");

                entity.Property(e => e.T2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("t2");
            });

            modelBuilder.Entity<Solicitud>(entity =>
            {
                entity.ToTable("Solicitud");

                entity.HasComment("Tabla que alberga los datos asociados a la solicitud de proyectos\r\n");

                entity.Property(e => e.SolicitudId)
                    .HasColumnName("Solicitud_Id")
                    .HasComment("Identificacion de la solicitud");

                entity.Property(e => e.AreaSol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Area_Sol")
                    .HasComment("Área del solicitante");

                entity.Property(e => e.Añosol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("añosol");

                entity.Property(e => e.Beneficios)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("beneficios");

                entity.Property(e => e.Causas)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.CcaSol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCA_Sol");

                entity.Property(e => e.CcsaSol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCSA_Sol")
                    .HasComment("Numero del centro de costos de sub-area a donde se cargaran los gastos");

                entity.Property(e => e.FacExito1)
                    .HasColumnType("text")
                    .HasColumnName("Fac_Exito1");

                entity.Property(e => e.FecSol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Sol")
                    .HasComment("Fecha de solicitud del proyecto");

                entity.Property(e => e.Justificacion)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justificacion");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NomProy)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Nom_proy")
                    .HasComment("Nombre del proyecto solicitado");

                entity.Property(e => e.NomSol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Sol")
                    .HasComment("Nombre del solicitante");

                entity.Property(e => e.Objetivo)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("objetivo");

                entity.Property(e => e.Prioridad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProAlt)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Responsables)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("responsables");

                entity.Property(e => e.Retorno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("retorno");

                entity.Property(e => e.SubAa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SubAA")
                    .HasComment("Nombre de la sub area donde se aplicará el proyecto");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");

                entity.Property(e => e.Tipoproy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoproy");

                entity.Property(e => e.Validacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.X)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("x");

                entity.Property(e => e.Y)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("y");
            });

            modelBuilder.Entity<SolicitudCambio>(entity =>
            {
                entity.ToTable("solicitud_cambio");

                entity.Property(e => e.Accion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accion");

                entity.Property(e => e.Analisis)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("analisis");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("area");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaEje)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha_eje");

                entity.Property(e => e.FechaReq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha_req");

                entity.Property(e => e.FechaSol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha_sol");

                entity.Property(e => e.Justificacion)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("justificacion");

                entity.Property(e => e.Nomsol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomsol");

                entity.Property(e => e.Sitact)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("sitact");

                entity.Property(e => e.Sitpro)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("sitpro");

                entity.Property(e => e.Validacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("validacion");

                entity.Property(e => e.VarEsp)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("var_esp");
            });

            modelBuilder.Entity<SolicitudCod>(entity =>
            {
                entity.ToTable("solicitud_cod");

                entity.Property(e => e.Abc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("abc");

                entity.Property(e => e.Almacen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("almacen");

                entity.Property(e => e.Altura)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("altura");

                entity.Property(e => e.Ancho)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ancho");

                entity.Property(e => e.Articulo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("articulo");

                entity.Property(e => e.Canthojas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("canthojas");

                entity.Property(e => e.Cantrollos)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cantrollos");

                entity.Property(e => e.Cat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cat");

                entity.Property(e => e.Clase)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clase");

                entity.Property(e => e.Codcom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codcom");

                entity.Property(e => e.Coddes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coddes");

                entity.Property(e => e.Codgrupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codgrupo");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Comprador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("comprador");

                entity.Property(e => e.Cond)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cond");

                entity.Property(e => e.Costo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("costo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Descripcion2)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("descripcion2");

                entity.Property(e => e.Factorc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("factorc");

                entity.Property(e => e.Factorp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("factorp");

                entity.Property(e => e.Factorps)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("factorps");

                entity.Property(e => e.Factorps2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("factorps2");

                entity.Property(e => e.Factorv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("factorv");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grupo");

                entity.Property(e => e.Grupoimp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grupoimp");

                entity.Property(e => e.Linea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("linea");

                entity.Property(e => e.Long)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("long");

                entity.Property(e => e.Lote)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lote");

                entity.Property(e => e.Marca)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("marca");

                entity.Property(e => e.Obs)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("obs");

                entity.Property(e => e.Pal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pal");

                entity.Property(e => e.Peso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("peso");

                entity.Property(e => e.Pesob)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pesob");

                entity.Property(e => e.Preciol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("preciol");

                entity.Property(e => e.Solicitante)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("solicitante");

                entity.Property(e => e.Tipo1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo1");

                entity.Property(e => e.Tipo2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo2");

                entity.Property(e => e.Ubi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ubi");

                entity.Property(e => e.Uma)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("uma");

                entity.Property(e => e.Umc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("umc");

                entity.Property(e => e.Ume)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ume");

                entity.Property(e => e.Umh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("umh");

                entity.Property(e => e.Uml)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("uml");

                entity.Property(e => e.Ump)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ump");

                entity.Property(e => e.Umpe)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("umpe");

                entity.Property(e => e.Umv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("umv");

                entity.Property(e => e.Validacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("validacion");

                entity.Property(e => e.Vol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vol");
            });

            modelBuilder.Entity<SolicitudCodigo2>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("solicitud_codigo_2");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Codbarra)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codbarra");

                entity.Property(e => e.Codigoeq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigoeq");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Fabricante)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fabricante");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Item)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("item");

                entity.Property(e => e.Precio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("precio");
            });

            modelBuilder.Entity<SolicitudLab>(entity =>
            {
                entity.HasKey(e => e.IdSol);

                entity.ToTable("solicitud_lab");

                entity.Property(e => e.IdSol).HasColumnName("id_sol");

                entity.Property(e => e.Ana1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ana1");

                entity.Property(e => e.Ana2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ana2");

                entity.Property(e => e.Ana3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ana3");

                entity.Property(e => e.App)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("app");

                entity.Property(e => e.Archivo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("archivo");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Codprod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codprod");

                entity.Property(e => e.Descens)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("descens");

                entity.Property(e => e.Dptosol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dptosol");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.Fecsol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecsol");

                entity.Property(e => e.Lote)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lote");

                entity.Property(e => e.Nomsol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomsol");

                entity.Property(e => e.Obj)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("obj");

                entity.Property(e => e.Proveedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("proveedor");

                entity.Property(e => e.Ruta)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ruta");

                entity.Property(e => e.Validacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("validacion");
            });

            modelBuilder.Entity<SolicitudNueProd>(entity =>
            {
                entity.HasKey(e => e.IdSol);

                entity.ToTable("solicitud_nue_prod");

                entity.Property(e => e.IdSol).HasColumnName("id_sol");

                entity.Property(e => e.Analisis)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("analisis");

                entity.Property(e => e.Aplicacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aplicacion");

                entity.Property(e => e.Archivo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("archivo");

                entity.Property(e => e.Areasol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("areasol");

                entity.Property(e => e.Bencuan)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("bencuan");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.Conope)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("conope");

                entity.Property(e => e.Dptosol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dptosol");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.Fecsol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecsol");

                entity.Property(e => e.Nomprod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomprod");

                entity.Property(e => e.Nomsol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomsol");

                entity.Property(e => e.Producto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("producto");

                entity.Property(e => e.Proveedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("proveedor");

                entity.Property(e => e.Reqesp)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("reqesp");

                entity.Property(e => e.Reqins)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("reqins");

                entity.Property(e => e.Ruta)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ruta");

                entity.Property(e => e.Sitact)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("sitact");

                entity.Property(e => e.Tipocliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipocliente");

                entity.Property(e => e.Validacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("validacion");

                entity.Property(e => e.Venta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("venta");
            });

            modelBuilder.Entity<SolicitudPanasa>(entity =>
            {
                entity.HasKey(e => e.SolicitudId);

                entity.ToTable("Solicitud_panasa");

                entity.Property(e => e.SolicitudId)
                    .HasColumnName("Solicitud_Id")
                    .HasComment("Identificacion de la solicitud");

                entity.Property(e => e.AreaSol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Area_Sol")
                    .HasComment("Área del solicitante");

                entity.Property(e => e.Añosol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("añosol");

                entity.Property(e => e.Beneficios)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("beneficios");

                entity.Property(e => e.Causas)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.CcaSol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCA_Sol");

                entity.Property(e => e.CcsaSol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCSA_Sol")
                    .HasComment("Numero del centro de costos de sub-area a donde se cargaran los gastos");

                entity.Property(e => e.FecSol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Sol")
                    .HasComment("Fecha de solicitud del proyecto");

                entity.Property(e => e.Justificacion)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("justificacion");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NomProy)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Nom_proy")
                    .HasComment("Nombre del proyecto solicitado");

                entity.Property(e => e.NomSol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Sol")
                    .HasComment("Nombre del solicitante");

                entity.Property(e => e.Objetivo)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("objetivo");

                entity.Property(e => e.Prioridad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProAlt)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Responsables)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("responsables");

                entity.Property(e => e.Retorno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("retorno");

                entity.Property(e => e.SubAa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SubAA")
                    .HasComment("Nombre de la sub area donde se aplicará el proyecto");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");

                entity.Property(e => e.Tipoproy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoproy");

                entity.Property(e => e.Validacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.X)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("x");

                entity.Property(e => e.Y)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("y");
            });

            modelBuilder.Entity<SolicitudT>(entity =>
            {
                entity.HasKey(e => e.IdSol);

                entity.ToTable("solicitud_ts");

                entity.Property(e => e.IdSol).HasColumnName("id_sol");

                entity.Property(e => e.Area1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("area1");

                entity.Property(e => e.Area2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("area2");

                entity.Property(e => e.Casa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("casa");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Fecfin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecfin");

                entity.Property(e => e.Fecini)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecini");

                entity.Property(e => e.Fecsol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecsol");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("motivo");

                entity.Property(e => e.Nomproy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nomproy");

                entity.Property(e => e.Nomsol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomsol");

                entity.Property(e => e.Obs)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("obs");

                entity.Property(e => e.Validacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("validacion");
            });

            modelBuilder.Entity<Stsidea>(entity =>
            {
                entity.HasKey(e => e.StideaId);

                entity.ToTable("STSidea");

                entity.Property(e => e.StideaId).HasColumnName("STideaID");

                entity.Property(e => e.Stdescrip)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("STdescrip");
            });

            modelBuilder.Entity<SupAud>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sup_aud");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TallerAutomotrizMc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Taller_Automotriz_MC");

                entity.Property(e => e.Equipo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEnt).HasColumnName("Fecha_ent");

                entity.Property(e => e.FechaSal).HasColumnName("Fecha_sal");

                entity.Property(e => e.Ficha)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Grupo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HoraEnt)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Hora_ent");

                entity.Property(e => e.HoraSal)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Hora_sal");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MotivoRep)
                    .IsUnicode(false)
                    .HasColumnName("Motivo_rep");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.PersonalResp)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Personal_resp");

                entity.Property(e => e.TiempoRep)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Tiempo_rep");

                entity.Property(e => e.TipoMant)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_mant");

                entity.Property(e => e.TipoServ)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_serv");

                entity.Property(e => e.TrabRealizado)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Trab_realizado");
            });

            modelBuilder.Entity<Tarea>(entity =>
            {
                entity.HasKey(e => e.IdTarea);

                entity.Property(e => e.IdTarea).HasColumnName("Id_Tarea");

                entity.Property(e => e.Avance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("avance");

                entity.Property(e => e.Cli)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cli");

                entity.Property(e => e.Cliing)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cliing");

                entity.Property(e => e.FecEnt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Ent");

                entity.Property(e => e.Idm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDM");

                entity.Property(e => e.Ing)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ing");

                entity.Property(e => e.Res)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tarea1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Tarea");
            });

            modelBuilder.Entity<TareaActividad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tarea_Actividad");

                entity.Property(e => e.Actividad)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdTarea).HasColumnName("ID_Tarea");

                entity.Property(e => e.Tarea)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Tiempo).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<TareasEquipo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tareas_equipos");

                entity.Property(e => e.Compañia)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Dpto)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdEquipo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ID_Equipo");

                entity.Property(e => e.IdTarea)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_Tarea");

                entity.Property(e => e.Linea)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Tarea)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Tiemp).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<TareasIp>(entity =>
            {
                entity.HasKey(e => e.IdTarea);

                entity.ToTable("TareasIP");

                entity.Property(e => e.IdTarea)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Tarea");

                entity.Property(e => e.Avance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("avance");

                entity.Property(e => e.Cli)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cli");

                entity.Property(e => e.Cliing)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cliing");

                entity.Property(e => e.FecEnt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Ent");

                entity.Property(e => e.Idm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDM");

                entity.Property(e => e.Ing)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ing");

                entity.Property(e => e.Res)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tarea)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TareasPanasa>(entity =>
            {
                entity.HasKey(e => e.IdTarea);

                entity.ToTable("Tareas_panasa");

                entity.Property(e => e.IdTarea)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Tarea");

                entity.Property(e => e.Avance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("avance");

                entity.Property(e => e.Cli)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cli");

                entity.Property(e => e.Cliing)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cliing");

                entity.Property(e => e.FecEnt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fec_Ent");

                entity.Property(e => e.Idm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDM");

                entity.Property(e => e.Ing)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ing");

                entity.Property(e => e.Res)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tarea)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transporte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Transporte");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cedula");

                entity.Property(e => e.Clase)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clase");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.PlacaVeh)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("placa_veh");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Ficha)
                    .HasName("PK_Usuarios_1");

                entity.Property(e => e.Ficha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ficha");

                entity.Property(e => e.AhoAcu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Aho_Acu");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo");

                entity.Property(e => e.Casa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("casa");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cedula");

                entity.Property(e => e.Celular)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("celular");

                entity.Property(e => e.Clave)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clave");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Cump)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cump");

                entity.Property(e => e.Dpto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dpto");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empresa");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.Extension)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extension");

                entity.Property(e => e.FecIng)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecNac)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecVac)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiltroConsultarProy)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Filtro_consultarProy");

                entity.Property(e => e.Hhsem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HHsem");

                entity.Property(e => e.MetaAho)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MetaSatis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nivel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nivel");

                entity.Property(e => e.NomFoto)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("nom_foto");

                entity.Property(e => e.NomSol)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.RutaFoto)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ruta_foto");

                entity.Property(e => e.SatisAcu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Satis_Acu");

                entity.Property(e => e.Sueldo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sueldo");

                entity.Property(e => e.Usuario1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<UsuarioVcc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Usuario_VCC");

                entity.Property(e => e.Clave)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ficha)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsuariosSgi>(entity =>
            {
                entity.HasKey(e => e.Ficha);

                entity.ToTable("Usuarios_SGI");

                entity.Property(e => e.Ficha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ficha");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("area");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cargo");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cedula");

                entity.Property(e => e.Clave)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clave");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Dpto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dpto");

                entity.Property(e => e.Ext)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ext");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pais");

                entity.Property(e => e.Tlf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tlf");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
