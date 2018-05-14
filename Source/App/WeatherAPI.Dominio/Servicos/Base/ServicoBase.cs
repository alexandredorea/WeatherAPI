using System;
using System.Collections.Generic;
using WeatherAPI.Dominio.Interfaces.Repositorio.Base;
using WeatherAPI.Dominio.Interfaces.Servico.Base;

namespace WeatherAPI.Dominio.Servicos.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TipoEntidade"></typeparam>
    public class ServicoBase<TipoEntidade> : IDisposable, IServicoBase<TipoEntidade> where TipoEntidade : class
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IRepositorioBase<TipoEntidade> _repositorio;

        /// <summary>
        /// Método construtor
        /// </summary>
        /// <param name="entidade">Instância da entidade</param>
        public ServicoBase(IRepositorioBase<TipoEntidade> entidade)
        {
            _repositorio = entidade;
        }

        /// <summary>
        /// Adicionar a entidade no banco de dados
        /// </summary>
        /// <param name="endidade">Entidade preenchida</param>
        public void Adicionar(TipoEntidade endidade)
        {
            _repositorio.Adicionar(endidade);
        }

        /// <summary>
        /// Atualizar a informação da entidade em questão no banco de dados
        /// </summary>
        /// <param name="entidade">Entidade preenchida</param>
        public void Atualizar(TipoEntidade entidade)
        {
            _repositorio.Atualizar(entidade);
        }

        /// <summary>
        /// Obtem uma entidade especifica
        /// </summary>
        /// <param name="id">Identificado da entidade</param>
        /// <returns>Entidade preenchida</returns>
        public TipoEntidade ObterPorId(int id)
        {
            return _repositorio.ObterPorId(id);
        }

        /// <summary>
        /// Obtem todas as entidades no banco de dados
        /// </summary>
        /// <returns>Entidade preenchida</returns>
        public IEnumerable<TipoEntidade> ObterTodos()
        {
            return _repositorio.ObterTodos();
        }

        /// <summary>
        /// Remove a informação especifica no banco de dados
        /// </summary>
        /// <param name="entidade">Entidade a ser removida</param>
        public void Remover(TipoEntidade entidade)
        {
            _repositorio.Remover(entidade);
        }

        /// <summary>
        /// Libera a memória
        /// </summary>
        public void Dispose()
        {
            _repositorio.Dispose();
        }
    }
}
