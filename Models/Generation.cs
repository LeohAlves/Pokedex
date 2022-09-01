using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    [Table("Generation")]
    public class Generation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Por favor, informe o nome")]
        [StringLength(20, ErrorMessage = "O nome deve possuir no máximo 20 caracteres")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Mídia")]
        [Required(ErrorMessage = "Por favor, informe a Mídia")]
        [StringLength(1, ErrorMessage = "A Mídia deve possuir no máximo 1 caracteres")]
        public string Midia { get; set; } = string.Empty;
    }
}