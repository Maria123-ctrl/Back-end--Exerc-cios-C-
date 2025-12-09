using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tabela_usuario")]
public partial class TabelaUsuario
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nome_completo")]
    [StringLength(255)]
    public string? NomeCompleto { get; set; }

    [Column("nome_usuario")]
    [StringLength(30)]
    public string? NomeUsuario { get; set; }

    [Column("email")]
    [StringLength(255)]
    public string Email { get; set; } = null!;

    [Column("senha")]
    [StringLength(50)]
    public string Senha { get; set; } = null!;

    [Column("foto_perfil_url")]
    [StringLength(150)]
    public string? FotoPerfilUrl { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TabelaComentario> TabelaComentario { get; set; } = new List<TabelaComentario>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TabelaCurtida> TabelaCurtida { get; set; } = new List<TabelaCurtida>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TabelaPublicacao> TabelaPublicacao { get; set; } = new List<TabelaPublicacao>();

    [ForeignKey("IdusuarioSeguir")]
    [InverseProperty("IdusuarioSeguir")]
    public virtual ICollection<TabelaUsuario> IdusuarioSeguidor { get; set; } = new List<TabelaUsuario>();

    [ForeignKey("IdusuarioSeguidor")]
    [InverseProperty("IdusuarioSeguidor")]
    public virtual ICollection<TabelaUsuario> IdusuarioSeguir { get; set; } = new List<TabelaUsuario>();
}
