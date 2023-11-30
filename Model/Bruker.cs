using System.ComponentModel.DataAnnotations;

namespace KartverkCase.Model
{
    public class Bruker
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Fornavn { get; set; }
        [Required]
        [MaxLength(50)]
        public string Etternavn { get; set; }
        [Required]
        [MaxLength(50)]
        public string Adresse { get; set; }
        [Required]
        [MaxLength(50)]
        public DateTime Fødselsdato { get; set; }
        [Required]
        [MaxLength(50)]
        public string TelefonNr { get; set; }
        [Required]
        [MaxLength(50)]
        public string Epost { get; set; }

    }
}
