using System.ComponentModel.DataAnnotations;

namespace EmprestimoLivros.Models
{
    public class EmprestimoModel
    {

        public int Id { get; set; }//coluna id na BD

        [Required(ErrorMessage = "Digite o nome do Recebedor")]
        public String Recebedor { get; set; }

        [Required(ErrorMessage = "Digite o nome do Fornecedor")]
        public string Fornecedor { get; set;}

        [Required(ErrorMessage = "Digite o nome do Livro")]
        public string LivroEmprestado { get; set; }

        public DateTime dataUltimaAtualizacao {  get; set; } = DateTime.Now;
    }
}
