using System.Linq;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BankSys.Models
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
    }
}
