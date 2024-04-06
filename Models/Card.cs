using System.ComponentModel.DataAnnotations;

namespace Bank4.Models
{
    public class Card
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public int user_id { get; set; }

        [Required]
        public string CVV { get; set; }

        [Required]
        public string dateExpired { get; set; }

        [Required]
        public string PIN { get; set; }
    }
}
