using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        //criando tabela
        public DbSet<EmprestimoModel> Emprestimos { get; set; }
    }
}
/*
 * DbContext auxilia no processo de conexão com o Banco de Dados, é necessario 
 * o using Microsoft.EntityFrameworkCore;
 */
/*
 *  base(options) significa que ele ira pegar as opções do DbContext
 */