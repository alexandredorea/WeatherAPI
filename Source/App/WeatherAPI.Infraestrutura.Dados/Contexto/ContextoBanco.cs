using Microsoft.EntityFrameworkCore;
using WeatherAPI.Dominio.Entidades;
using WeatherAPI.Infraestrutura.Dados.Mapeamento;

namespace WeatherAPI.Infraestrutura.Dados.Contexto
{
    /// <summary>
    /// 
    /// </summary>
    public class ContextoBanco : DbContext
    {
        /// <summary>
        /// Construtor de conexão com banco de dados
        /// </summary>
        /// <param name="conexao"></param>
        public ContextoBanco(DbContextOptions<ContextoBanco> conexao) : base(conexao)
        {
        }
        /// <summary>
        /// Instância da tabela Cidades
        /// </summary>
        public DbSet<Cidade> Cidades { get; set; }

        /// <summary>
        /// Sobreescrita do método de criação do banco de dados
        /// </summary>
        /// <param name="modelBuilder">Modelo de informações do banco</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MapeamentoDbCidade());
        }
    }
}
