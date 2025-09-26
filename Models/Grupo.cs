using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Clarify.Models;

[Table("Grupos")]
public class Grupo
{
    [Key]
    public int GrupoId { get; set; }
    
    [Required(ErrorMessage = "Descrição é obrigatório")]
    [StringLength(100, ErrorMessage = "A descricao deve ter entre 10 e 100 caracteres", MinimumLength = 10)]
    public string Descricao { get; set; }
    
    [JsonIgnore]
    public ICollection<Conta> Contas { get; set; }

    public Grupo()
    {
        Contas = new List<Conta>();
    }
}