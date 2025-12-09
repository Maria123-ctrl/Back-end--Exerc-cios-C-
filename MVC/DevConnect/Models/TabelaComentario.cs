using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tabela_comentario")]
public partial class TabelaComentario
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Column("id_publicacao")]
    public int IdPublicacao { get; set; }

    [Column("texto")]
    [StringLength(255)]
    public string Texto { get; set; } = null!;

    [ForeignKey("IdPublicacao")]
    [InverseProperty("TabelaComentario")]
    public virtual TabelaPublicacao IdPublicacaoNavigation { get; set; } = null!;

    [ForeignKey("IdUsuario")]
    [InverseProperty("TabelaComentario")]
    public virtual TabelaUsuario IdUsuarioNavigation { get; set; } = null!;
}
