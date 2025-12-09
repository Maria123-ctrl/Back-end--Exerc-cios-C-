using System;
using System.Collections.Generic;
using DevConnect.Models;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Contexts;

public partial class DevConnectContext : DbContext
{
    public DevConnectContext()
    {
    }

    public DevConnectContext(DbContextOptions<DevConnectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TabelaComentario> TabelaComentario { get; set; }

    public virtual DbSet<TabelaCurtida> TabelaCurtida { get; set; }

    public virtual DbSet<TabelaPublicacao> TabelaPublicacao { get; set; }

    public virtual DbSet<TabelaUsuario> TabelaUsuario { get; set; }

    public virtual DbSet<TbUsuario> TbUsuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DevCon_SA");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TabelaComentario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tabela_c__3213E83FBD0CFEEA");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.TabelaComentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tabela_co__id_pu__6EF57B66");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TabelaComentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tabela_co__id_us__6E01572D");
        });

        modelBuilder.Entity<TabelaCurtida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tabela_c__3213E83FB244BFE0");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.TabelaCurtida).HasConstraintName("FK__tabela_cu__id_pu__72C60C4A");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TabelaCurtida).HasConstraintName("FK__tabela_cu__id_us__71D1E811");
        });

        modelBuilder.Entity<TabelaPublicacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tabela_p__3213E83F1ACFA38C");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TabelaPublicacao).HasConstraintName("FK__tabela_pu__id_us__6B24EA82");
        });

        modelBuilder.Entity<TabelaUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tabela_u__3213E83FC0B8818D");

            entity.HasMany(d => d.IdusuarioSeguidor).WithMany(p => p.IdusuarioSeguir)
                .UsingEntity<Dictionary<string, object>>(
                    "TabelaSeguidor",
                    r => r.HasOne<TabelaUsuario>().WithMany()
                        .HasForeignKey("IdusuarioSeguidor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tabela_se__idusu__17F790F9"),
                    l => l.HasOne<TabelaUsuario>().WithMany()
                        .HasForeignKey("IdusuarioSeguir")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tabela_se__idusu__17036CC0"),
                    j =>
                    {
                        j.HasKey("IdusuarioSeguir", "IdusuarioSeguidor").HasName("PK__tabela_s__344C5A41A5267C06");
                        j.ToTable("tabela_seguidor");
                        j.IndexerProperty<int>("IdusuarioSeguir").HasColumnName("idusuarioSeguir");
                        j.IndexerProperty<int>("IdusuarioSeguidor").HasColumnName("idusuarioSeguidor");
                    });

            entity.HasMany(d => d.IdusuarioSeguir).WithMany(p => p.IdusuarioSeguidor)
                .UsingEntity<Dictionary<string, object>>(
                    "TabelaSeguidor",
                    r => r.HasOne<TabelaUsuario>().WithMany()
                        .HasForeignKey("IdusuarioSeguir")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tabela_se__idusu__17036CC0"),
                    l => l.HasOne<TabelaUsuario>().WithMany()
                        .HasForeignKey("IdusuarioSeguidor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tabela_se__idusu__17F790F9"),
                    j =>
                    {
                        j.HasKey("IdusuarioSeguir", "IdusuarioSeguidor").HasName("PK__tabela_s__344C5A41A5267C06");
                        j.ToTable("tabela_seguidor");
                        j.IndexerProperty<int>("IdusuarioSeguir").HasColumnName("idusuarioSeguir");
                        j.IndexerProperty<int>("IdusuarioSeguidor").HasColumnName("idusuarioSeguidor");
                    });
        });

        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_usuar__3213E83F3CA0ECA5");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
