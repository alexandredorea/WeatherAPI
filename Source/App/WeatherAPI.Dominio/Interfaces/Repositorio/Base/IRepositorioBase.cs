using System.Collections.Generic;

namespace WeatherAPI.Dominio.Interfaces.Repositorio.Base
{
    /// <summary>
    /// Interface de Repositório Básicos para as demais classes
    /// </summary>
    /// <typeparam name="TipoEntidade">Tipo de Entidade que deseja passar</typeparam>
    public interface IRepositorioBase<TipoEntidade> where TipoEntidade : class
    {
        /// <summary>
        /// Metódo de Adicionar no Banco de Dados
        /// </summary>
        /// <param name="entidade">Entidade que será inserida no banco</param>
        void Adicionar(TipoEntidade entidade);

        /// <summary>
        /// Obter um objeto pelo Id
        /// </summary>
        /// <param name="id">Campo identificador para busca</param>
        /// <returns>Objeto preenchido com o tipo da entidade</returns>
        TipoEntidade ObterPorId(int id);

        /// <summary>
        /// Obtem todos os dados da entidade
        /// </summary>
        /// <returns>Objeto preenchido com o tipo da entidade</returns>
        IEnumerable<TipoEntidade> ObterTodos();

        /// <summary>
        /// Metódo responsável por atualizar a entidade no banco de dados
        /// </summary>
        /// <param name="entidade">Entidade que será inserida no banco</param>
        void Atualizar(TipoEntidade entidade);

        /// <summary>
        /// Metódo responsável por excluir a informação do banco
        /// </summary>
        /// <param name="entidade">Entidade que será inserida no banco</param>
        void Remover(TipoEntidade entidade);

        /// <summary>
        /// Sobreescrita do metódo dispose para liberar a memória
        /// </summary>
        void Dispose();
    }
}
