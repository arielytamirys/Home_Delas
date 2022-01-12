using System.ComponentModel.DataAnnotations;

namespace NewJob.Models
{
    public class Inicial
    {
        [Key, Required]
        public int Id {get; set;}

        // [Required]
        // public string Buscar {get; set;}

        // CHAVE ESTRANGEIRAS
        [Required]
        private int VagaId_vaga {get; set;}
        public Vaga Vagas {get; set;}

        // CHAVE ESTRANGEIRAS
        private int Link_CursoId_link_curso { get; set; }
        public Link_Curso Link_Curso { get; set; }

    }
}