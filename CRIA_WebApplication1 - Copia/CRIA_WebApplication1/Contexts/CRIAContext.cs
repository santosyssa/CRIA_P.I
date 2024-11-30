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

    public virtual DbSet<Aluno> Alunos { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Financeiro> Financeiros { get; set; }

    public virtual DbSet<Inscricao> Inscricaos { get; set; }

    public virtual DbSet<Matricula> Matriculas { get; set; }

    public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=NICOLAS;Initial Catalog=CRIA;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>(entity =>
        {
            entity.HasKey(e => e.IdAluno).HasName("PK__aluno__0C5BC849B5A522C1");

            entity.ToTable("aluno");

            entity.HasIndex(e => e.Telefone, "UQ__aluno__2A16D97F75363BE9").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__aluno__AB6E616459AD1A8D").IsUnique();

            entity.Property(e => e.IdAluno).HasColumnName("idAluno");
            entity.Property(e => e.DataNascimento).HasColumnName("dataNascimento");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Telefone)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("telefone");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.IdCurso).HasName("PK__curso__8551ED053A7CFF0F");

            entity.ToTable("curso");

            entity.HasIndex(e => e.Nome, "UQ__curso__6F71C0DCDAFE64DC").IsUnique();

            entity.Property(e => e.IdCurso).HasColumnName("idCurso");
            entity.Property(e => e.Duracao).HasColumnName("duracao");
            entity.Property(e => e.Habilitacao)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("habilitacao");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Financeiro>(entity =>
        {
            entity.HasKey(e => e.IdFin).HasName("PK__financei__39C10175E978FF08");

            entity.ToTable("financeiro");

            entity.Property(e => e.IdFin).HasColumnName("idFin");
            entity.Property(e => e.AVencer).HasColumnName("aVencer");
            entity.Property(e => e.DataVenc).HasColumnName("dataVenc");
            entity.Property(e => e.Pago).HasColumnName("pago");
        });

        modelBuilder.Entity<Inscricao>(entity =>
        {
            entity.HasKey(e => e.Ra).HasName("PK__inscrica__32143317F5AF4711");

            entity.ToTable("inscricao");

            entity.HasIndex(e => e.Email, "UQ__inscrica__AB6E6164586A0CB0").IsUnique();

            entity.Property(e => e.Ra).HasColumnName("ra");
            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Fam).HasColumnName("fam");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");

            entity.HasOne(d => d.FamNavigation).WithMany(p => p.Inscricaos)
                .HasForeignKey(d => d.Fam)
                .HasConstraintName("FK__inscricao__fam__4E88ABD4");
        });

        modelBuilder.Entity<Matricula>(entity =>
        {
            entity.HasKey(e => e.Ra).HasName("PK__matricul__3214331741396DD3");

            entity.ToTable("matricula");

            entity.HasIndex(e => e.Turno, "UQ__matricul__179B81C3211108B6").IsUnique();

            entity.HasIndex(e => e.Campus, "UQ__matricul__BC61E0A8CC518598").IsUnique();

            entity.Property(e => e.Ra).HasColumnName("ra");
            entity.Property(e => e.Campus)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("campus");
            entity.Property(e => e.Curso).HasColumnName("curso");
            entity.Property(e => e.Mensalidade).HasColumnName("mensalidade");
            entity.Property(e => e.Nome).HasColumnName("nome");
            entity.Property(e => e.Semestre).HasColumnName("semestre");
            entity.Property(e => e.Turno)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("turno");

            entity.HasOne(d => d.CursoNavigation).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.Curso)
                .HasConstraintName("FK__matricula__curso__49C3F6B7");

            entity.HasOne(d => d.MensalidadeNavigation).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.Mensalidade)
                .HasConstraintName("FK__matricula__mensa__4AB81AF0");

            entity.HasOne(d => d.NomeNavigation).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.Nome)
                .HasConstraintName("FK__matricula__nome__48CFD27E");
        });

        modelBuilder.Entity<TipoUsuario>(entity =>
        {
            entity.HasKey(e => e.IdTipoUsuario).HasName("PK__tipoUsua__03006BFFD9C4C4A1");

            entity.ToTable("tipoUsuario");

            entity.HasIndex(e => e.Nome, "UQ__tipoUsua__6F71C0DC10A06E4C").IsUnique();

            entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PK__usuario__3717C982FB9ACD83");

            entity.ToTable("usuario");

            entity.HasIndex(e => e.Email, "UQ__usuario__AB6E6164709B4910").IsUnique();

            entity.Property(e => e.IdUser).HasColumnName("idUser");
            entity.Property(e => e.Acesso).HasColumnName("acesso");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Senha)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("senha");

            entity.HasOne(d => d.AcessoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.Acesso)
                .HasConstraintName("FK__usuario__acesso__3B75D760");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
