using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Clarify.Utils;

namespace Clarify.Models;

[Table("Partidas")]
public class Partida
{
    [Key]
    public int PartidaId { get; set; }
    
    [Required]
    public TipoLancamento TipoLancamento { get; set; }
    
    [Required]
    public decimal Valor { get; set; }
    
    public int  LancamentoId { get; set; }
    
    public int ContaId { get; set; }
    
    [JsonIgnore]
    public Conta Conta { get; set; }
    
}