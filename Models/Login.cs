using System.ComponentModel.DataAnnotations;

namespace NewJob.Models
{
    public class Login
    {
        [Key, Required]
        public int Id {get; set;}

        [Required]
        public string Email {get; set;}
       
        [Required]
        public string Senha {get; set;}

        [Required]
        public string Confirmar {get; set;}
    }
}