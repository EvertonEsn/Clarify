using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Clarify.Models;

[Table("Contas")]
public class Conta
{
    [Key]
    public int ContaId { get; set; }
    
    [Required(ErrorMessage = "Nome é obrigatório")]
    [StringLength(40, ErrorMessage = "O nome deve ter entre 5 e 40 caracteres", MinimumLength = 5)]
    public string? Nome  { get; set; }
    
    public int GrupoId { get; set; }
    
    [JsonIgnore]
    public Grupo Grupo { get; set; }
    
    [JsonIgnore]
    public ICollection<Partida> Partidas { get; set; }

    public Conta()
    {
        Partidas = new List<Partida>();
    }
}