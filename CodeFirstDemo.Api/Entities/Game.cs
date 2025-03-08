using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo.Api.Entities
{
    public class Game
    {
        public int Id { get; set; }  // Primary Key

        [Required] // Boş bırakılamaz
        public string Name { get; set; } // Oyunun adı

        [Required]
        public string Platform { get; set; } // Oynandığı platform

        [Range(0, 10, ErrorMessage = "Rating değeri 0 ile 10 arasında olmalıdır.")]
        public decimal Rating { get; set; } // Oyunun puanı (0-10)
    }
}
