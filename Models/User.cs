using System.ComponentModel.DataAnnotations;

namespace Bank4.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public double Balance { get; set; }
    }
}
