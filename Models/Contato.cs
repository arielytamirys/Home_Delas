using System.ComponentModel.DataAnnotations;

namespace NewJob.Models
{
    public class Contato
    {
        [Key, Required]
        public int Id {get; set;}

        [Required]
        public string Email {get; set;}

        [Required]
        public string WhatsApp {get; set;}
    }
}