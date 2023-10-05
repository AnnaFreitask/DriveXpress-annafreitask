using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveXpress_annafreitask.modells
{
    [Table("Cardapio")]
    public class cardapio
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public int Quantidad { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public double value { get; set; }
        [Required]
        public Cardapio food { get; set; }

        [Required]
        public int RestauranteId { get; set; } //produto pertence a um unico restaurante (produto associado a Key de restaurante)

        public Restaurante Restaurante { get; set; } //retorna dados restaurante
    }

    public enum Cardapio { 
    comida,
    bebida
    }


}