using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ReunionDiaApi.Models
{
    public partial class DbNeoContext : DbContext
    {
        public DbNeoContext()
        {
        }

        public DbNeoContext(DbContextOptions<DbNeoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AsistenReu> AsistenReus { get; set; } = null!;
        public virtual DbSet<CargoReu> CargoReus { get; set; } = null!;
        public virtual DbSet<Centro> Centros { get; set; } = null!;
        public virtual DbSet<Division> Divisions { get; set; } = null!;
        public virtual DbSet<Empresa> Empresas { get; set; } = null!;
        public virtual DbSet<Ksf> Ksfs { get; set; } = null!;
        public virtual DbSet<Linea> Lineas { get; set; } = null!;
        public virtual DbSet<Pai> Pais { get; set; } = null!;
        public virtual DbSet<RespoReu> RespoReus { get; set; } = null!;
        public virtual DbSet<ReunionDium> ReunionDia { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AsistenReu>(entity =>
            {
                entity.HasKey(e => e.IdAsistencia);

                entity.ToTable("AsistenReu");

                entity.Property(e => e.ArObser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ararea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ARArea");

                entity.Property(e => e.Arfecha)
                    .HasColumnType("date")
                    .HasColumnName("ARFecha");

                entity.Property(e => e.AridCargoR).HasColumnName("ARIdCargoR");

                entity.HasOne(d => d.AridCargoRNavigation)
                    .WithMany(p => p.AsistenReus)
                    .HasForeignKey(d => d.AridCargoR)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AsistenReu_CargoReu");
            });

            modelBuilder.Entity<CargoReu>(entity =>
            {
                entity.HasKey(e => e.IdCargoR);

                entity.ToTable("CargoReu");

                entity.Property(e => e.Cearea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CEArea");

                entity.Property(e => e.Crempresa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREmpresa");

                entity.Property(e => e.Cresta).HasColumnName("CREsta");

                entity.Property(e => e.Crnombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CRNombre");
            });

            modelBuilder.Entity<Centro>(entity =>
            {
                entity.HasKey(e => e.IdCentro);

                entity.ToTable("Centro");

                entity.HasComment("centro de produccion");

                entity.Property(e => e.IdCentro).HasComment("identificador del centro");

                entity.Property(e => e.Cdetalle)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("CDetalle")
                    .HasComment("Detalle del centro");

                entity.Property(e => e.Cestado)
                    .HasColumnName("CEstado")
                    .HasComment("0: Inactivo, 1:Activo");

                entity.Property(e => e.Cnom)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("CNom")
                    .HasComment("nombre del centro");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Centros)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK_Centro_Empresa");
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.HasKey(e => e.IdDivision);

                entity.ToTable("Division");

                entity.Property(e => e.Ddetalle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DDetalle");

                entity.Property(e => e.Destado).HasColumnName("DEstado");

                entity.Property(e => e.Dnombre)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DNombre");

                entity.HasOne(d => d.IdCentroNavigation)
                    .WithMany(p => p.Divisions)
                    .HasForeignKey(d => d.IdCentro)
                    .HasConstraintName("FK_Division_Centro");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("Empresa");

                entity.Property(e => e.Edescri)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EDescri");

                entity.Property(e => e.Eestado).HasColumnName("EEstado");

                entity.Property(e => e.Enombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENombre");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Empresas)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Empresa_Pais");
            });

            modelBuilder.Entity<Ksf>(entity =>
            {
                entity.HasKey(e => e.Idksf);

                entity.ToTable("KSF");

                entity.Property(e => e.KsfNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Linea>(entity =>
            {
                entity.HasKey(e => e.IdLinea);

                entity.ToTable("Linea");

                entity.HasComment("linea de produccion");

                entity.Property(e => e.IdLinea).HasComment("identificador de la linea");

                entity.Property(e => e.IdCentro).HasComment("identificador del centro");

                entity.Property(e => e.LcenCos)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LCenCos");

                entity.Property(e => e.Ldetalle)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("LDetalle")
                    .HasComment("Detalle de la linea");

                entity.Property(e => e.Lestado)
                    .HasColumnName("LEstado")
                    .HasComment("0: Inactivo, 1:Activo");

                entity.Property(e => e.Lnom)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("LNom")
                    .HasComment("nombre de la linea");

                entity.Property(e => e.Lofic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOFIC");

                entity.HasOne(d => d.IdCentroNavigation)
                    .WithMany(p => p.Lineas)
                    .HasForeignKey(d => d.IdCentro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Linea_Centro");

                entity.HasOne(d => d.IdDivisionNavigation)
                    .WithMany(p => p.Lineas)
                    .HasForeignKey(d => d.IdDivision)
                    .HasConstraintName("FK_Linea_Division");
            });

            modelBuilder.Entity<Pai>(entity =>
            {
                entity.HasKey(e => e.IdPais);

                entity.Property(e => e.Pestado).HasColumnName("PEstado");

                entity.Property(e => e.Pnombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PNombre");
            });

            modelBuilder.Entity<RespoReu>(entity =>
            {
                entity.HasKey(e => e.IdResReu);

                entity.ToTable("RespoReu");

                entity.Property(e => e.Rresta).HasColumnName("RREsta");

                entity.Property(e => e.Rrnombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RRNombre");
            });

            modelBuilder.Entity<ReunionDium>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AfectadoKsf)
                    .HasMaxLength(50)
                    .IsUnicode(false);

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

                entity.Property(e => e.Division)
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

                entity.Property(e => e.OrdenTrabajo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanDeAccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Plan_de_accion");

                entity.Property(e => e.Produfin)
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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
