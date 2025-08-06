using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSuperHerois.Entities;

public class SuperPoder
{
    [Key]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Informe o super poder")]
    public string? Super_poder { get; set; }
    public string? Descricao { get; set; }

    [ForeignKey(SuperHeroiId)]
    public Guid SuperHeroiId { get; set; }
    public SuperHeroi? SuperHerois { get; set; }
}