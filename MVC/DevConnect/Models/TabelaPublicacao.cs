using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tabela_publicacao")]
public partial class TabelaPublicacao
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("descricao")]
    [StringLength(255)]
    public string Descricao { get; set; } = null!;

    [Column("imagem_url")]
    [StringLength(255)]
    public string? ImagemUrl { get; set; }

    [Column("data_publi")]
    public DateOnly? DataPubli { get; set; }

    [Column("id_usuario")]
    public int? IdUsuario { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("TabelaPublicacao")]
    public virtual TabelaUsuario? IdUsuarioNavigation { get; set; }

    [InverseProperty("IdPublicacaoNavigation")]
    public virtual ICollection<TabelaComentario> TabelaComentario { get; set; } = new List<TabelaComentario>();

    [InverseProperty("IdPublicacaoNavigation")]
    public virtual ICollection<TabelaCurtida> TabelaCurtida { get; set; } = new List<TabelaCurtida>();
}
