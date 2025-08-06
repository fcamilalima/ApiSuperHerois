using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSuperHerois.Entities;

public class Filme
{
    public Guid Id { get; set; }

    [Required(ErrorMessage="O filme é obrigatório!")]
    public string? Titulo { get; set; }

    public string? Descricao { get; set; }
    public string? Instrutor { get; set; }
    public DateTime Lancamento { get; set; }

    [ForeignKey("SuperHeroiId")]
    public Guid SuperHeroiId { get; set; }
    public SuperHeroi? SuperHeroi { get; set; }
}
