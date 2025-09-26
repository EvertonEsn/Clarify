using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Clarify.Models;

public class Lancamento
{
    [Key] 
    public int LancamentoId { get; set; }

    [Required] 
    public int NumLancamento { get; set; }

    [Required(ErrorMessage = "Descrição é obrigatório")]
    [StringLength(200, ErrorMessage = "A descricao deve ter entre 10 e 200 caracteres", MinimumLength = 10)]
    public string Descricao { get; set; }

    public DateTime DataLancamento { get; set; }

    [JsonIgnore] 
    public ICollection<Partida> Partidas { get; set; }

    public Lancamento()
    {
        Partidas =  new List<Partida>();
    }

}