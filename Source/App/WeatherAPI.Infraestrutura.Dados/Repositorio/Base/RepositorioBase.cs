using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WeatherAPI.Dominio.Interfaces.Repositorio.Base;
using WeatherAPI.Infraestrutura.Dados.Contexto;

namespace WeatherAPI.Infraestrutura.Dados.Repositorio.Base
{
    public class RepositorioBase<TipoEntidade> : IDisposable, IRepositorioBase<TipoEntidade> where TipoEntidade : class
    {

        private readonly ContextoBanco _contexto;
        private DbSet<TipoEntidade> _entidade;

        /// <summary>
        /// Método construtor
        /// </summary>
        /// <param name="contextoBanco">Contexto do Banco de Dados</param>
        public RepositorioBase(ContextoBanco contextoBanco)
        {
            _contexto = contextoBanco;
            _entidade = contextoBanco.Set<TipoEntidade>();
        }

        /// <summary>
        /// Adicionar a entidade no banco de dados
        /// </summary>
        /// <param name="entidade">Objeto que será inserido no banco</param>
        public void Adicionar(TipoEntidade entidade)
        {
            if (entidade == null)
            {
                throw new ArgumentException("Objeto vazio");
            }
            _entidade.Add(entidade);
            _contexto.SaveChanges();
        }

        /// <summary>
        /// Atualizar a informação da entidade em questão no banco de dados
        /// </summary>
        /// <param name="entidade">Objeto que será atualizado no banco</param>
        public void Atualizar(TipoEntidade entidade)
        {
            if (entidade == null)
            {
                throw new ArgumentException("Objeto vazio");
            }
            _contexto.Entry(entidade).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        /// <summary>
        /// Liberar a memória
        /// </summary>
        public void Dispose()
        {
            _entidade = null;
            if (_contexto != null)
                _contexto.Dispose();
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Obtem uma entidade ou objeto especifico
        /// </summary>
        /// <param name="id">Identificado da entidade</param>
        /// <returns>Entidade preenchida</returns>
        public TipoEntidade ObterPorId(int id)
        {
            return _entidade.Find(id);
        }

        /// <summary>
        /// Obtem todas as entidades no banco de dados
        /// </summary>
        /// <returns>Entidade preenchida</returns>
        public IEnumerable<TipoEntidade> ObterTodos()
        {
            return _entidade.AsEnumerable();
        }

        /// <summary>
        /// Remove a informação especifica no banco de dados
        /// </summary>
        /// <param name="entidade">Entidade a ser removida</param>
        public void Remover(TipoEntidade entidade)
        {
            if (entidade == null)
            {
                throw new ArgumentException("Objeto vazio");
            }
            _entidade.Remove(entidade);
            _contexto.SaveChanges();
        }
    }
}
