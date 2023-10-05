using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriveXpress_annafreitask.modells
{
    [Table("Restaurant")]
    public class Restaurante
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public String phone { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public Categoria categoria { get; set; }

        public ICollection<cardapio> Cardapio { get; set; }
    }



}

