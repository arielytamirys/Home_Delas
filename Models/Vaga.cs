using System.ComponentModel.DataAnnotations;

namespace NewJob.Models
{
    public class Vaga
    {
        [Key, Required]
        public int Id_Vaga { get; set; }

        [Required]
        public string Empresa { get; set; }
        
        [Required]
        public string Setor { get; set; }

        [Required]
        public string Responsavel { get; set; }

        [Required]
        public string CNPJ { get; set; }

        [Required]
        public string Vagas { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public string Link_Vaga { get; set; }

        
        // CHAVE ESTRANGEIRAS
        private int LoginId_login { get; set; }
        public Login Login { get; set; }

        // CHAVE ESTRANGEIRAS
        private int ContatoId_contato { get; set; }
        public Contato Contato { get; set; }
    }
}