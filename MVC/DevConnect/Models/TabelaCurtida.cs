using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tabela_curtida")]
[Index("IdUsuario", "IdPublicacao", Name = "UQ__tabela_c__F0961F6F88157051", IsUnique = true)]
[Index("IdUsuario", "IdPublicacao", Name = "UQ__tabela_c__F0961F6FCE813104", IsUnique = true)]
public partial class TabelaCurtida
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_usuario")]
    public int? IdUsuario { get; set; }

    [Column("id_publicacao")]
    public int? IdPublicacao { get; set; }

    [ForeignKey("IdPublicacao")]
    [InverseProperty("TabelaCurtida")]
    public virtual TabelaPublicacao? IdPublicacaoNavigation { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("TabelaCurtida")]
    public virtual TabelaUsuario? IdUsuarioNavigation { get; set; }
}
