using System.ComponentModel.DataAnnotations;

namespace NewJob.Models
{
    public class Link_Curso
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string Link_Cursos { get; set; }

    }
}