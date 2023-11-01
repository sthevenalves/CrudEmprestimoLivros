namespace EmprestimoLivros.Models
{
    public class EmprestimoModel
    {
        public int Id { get; set; }//coluna id na BD
        public String Recebedor { get; set; }
        public string Fornecedor { get; set;}
        public string LivroEmprestado { get; set; }
        public DateTime dataUltimaAtualizacao {  get; set; } = DateTime.Now;
    }
}
