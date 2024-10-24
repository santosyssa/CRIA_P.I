using System;
using System.Collections.Generic;
using CRIA_WebApplication1.Domains;
using Microsoft.EntityFrameworkCore;

namespace CRIA_WebApplication1.Contexts;

public partial class CRIAContext : DbContext
{
    public CRIAContext()
    {
    }

    public CRIAContext(DbContextOptions<CRIAContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Adm> Adms { get; set; }

    public virtual DbSet<ApiFam> ApiFams { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Matricula> Matriculas { get; set; }

    public virtual DbSet<Mentor> Mentors { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-IGB2804;Initial Catalog=CRIA;User Id=sa;Pwd=Senai132;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Adm>(entity =>
        {
            entity.HasKey(e => e.IdAdm).HasName("PK__ADM__73E8766D4C657A65");

            entity.ToTable("ADM");

            entity.Property(e => e.IdAdm).HasColumnName("id_ADM");
            entity.Property(e => e.Email)
                .HasMaxLength(600)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(600)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Senha)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("senha");
        });

        modelBuilder.Entity<ApiFam>(entity =>
        {
            entity.HasKey(e => e.IdApi).HasName("PK__API_FAM__73EB52D48DAFC8E8");

            entity.ToTable("API_FAM");

            entity.Property(e => e.IdApi).HasColumnName("id_API");
            entity.Property(e => e.IdCurso).HasColumnName("id_Curso");
            entity.Property(e => e.IdMentor).HasColumnName("id_Mentor");
            entity.Property(e => e.Ra).HasColumnName("ra");
            entity.Property(e => e.ValidarMatricula).HasColumnName("validar_Matricula");

            entity.HasOne(d => d.IdCursoNavigation).WithMany(p => p.ApiFams)
                .HasForeignKey(d => d.IdCurso)
                .HasConstraintName("FK__API_FAM__id_Curs__47DBAE45");

            entity.HasOne(d => d.IdMentorNavigation).WithMany(p => p.ApiFams)
                .HasForeignKey(d => d.IdMentor)
                .HasConstraintName("FK__API_FAM__id_Ment__46E78A0C");

            entity.HasOne(d => d.RaNavigation).WithMany(p => p.ApiFams)
                .HasForeignKey(d => d.Ra)
                .HasConstraintName("FK__API_FAM__ra__45F365D3");

            entity.HasOne(d => d.ValidarMatriculaNavigation).WithMany(p => p.ApiFams)
                .HasForeignKey(d => d.ValidarMatricula)
                .HasConstraintName("FK__API_FAM__validar__48CFD27E");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.IdCurso).HasName("PK__Curso__5860F2478507E52E");

            entity.ToTable("Curso");

            entity.Property(e => e.IdCurso).HasColumnName("id_Curso");
            entity.Property(e => e.Nome)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Matricula>(entity =>
        {
            entity.HasKey(e => e.IdMatri).HasName("PK__Matricul__B194DBCEFD9A09CD");

            entity.ToTable("Matricula");

            entity.Property(e => e.IdMatri).HasColumnName("id_Matri");
            entity.Property(e => e.IdCurso).HasColumnName("id_Curso");
            entity.Property(e => e.Mensaliade).HasColumnName("mensaliade");
            entity.Property(e => e.Ra).HasColumnName("ra");
            entity.Property(e => e.Validacao).HasColumnName("validacao");

            entity.HasOne(d => d.IdCursoNavigation).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.IdCurso)
                .HasConstraintName("FK__Matricula__id_Cu__3E52440B");

            entity.HasOne(d => d.RaNavigation).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.Ra)
                .HasConstraintName("FK__Matricula__ra__3D5E1FD2");
        });

        modelBuilder.Entity<Mentor>(entity =>
        {
            entity.HasKey(e => e.IdMentor).HasName("PK__Mentor__21E1EE4A1258FAFD");

            entity.ToTable("Mentor");

            entity.Property(e => e.IdMentor).HasColumnName("id_Mentor");
            entity.Property(e => e.IdCurso).HasColumnName("id_Curso");
            entity.Property(e => e.Nome)
                .HasMaxLength(600)
                .IsUnicode(false)
                .HasColumnName("nome");

            entity.HasOne(d => d.IdCursoNavigation).WithMany(p => p.Mentors)
                .HasForeignKey(d => d.IdCurso)
                .HasConstraintName("FK__Mentor__id_Curso__412EB0B6");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Ra).HasName("PK__Usuario__321433179114CC81");

            entity.ToTable("Usuario");

            entity.Property(e => e.Ra).HasColumnName("ra");
            entity.Property(e => e.Email)
                .HasMaxLength(600)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(600)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
