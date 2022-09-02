using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    [Table("Types")]
    public class Types
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Por favor, informe o nome")]
        [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Cor de exibição")]
        [Required(ErrorMessage = "Por favor, informe a cor")]
        [StringLength(7, ErrorMessage = "A cor deve possuir no máximo 7 caracteres")]
        public string Color { get; set; } = string.Empty;

        public ICollection<PokemonTypes> PokemonsOfThisType { get; set; } = new List<PokemonTypes>();
        public ICollection<Weaknesses> PokemonsWithThisWeaknesses { get; set; } = new List<Weaknesses>();

    }
}