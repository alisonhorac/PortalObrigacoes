using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository
{
    public interface IRepository<TEntidade> : IDisposable where TEntidade : class
    {
        /// <summary>
        /// Cria a nova entidade
        /// </summary>
        /// <param name="obj">Entidade a ser criada</param>
        /// <returns>Retorna a entidade adicionada</returns>
        TEntidade Inserir(TEntidade obj);

        /// <summary>
        /// Atualiza a entidade
        /// </summary>
        /// <param name="obj">Entidade com dados atualizados</param>
        /// <returns>Retorna a entidade atualizada</returns>
        TEntidade Alterar(TEntidade obj);

        /// <summary>
        /// Exclui a entidade através do Identificador único
        /// </summary>
        /// <param name="id">Identificador único da entidade</param>
        bool Excluir(Guid id);

        /// <summary>
        /// Exclui a entidade através do Identificador único
        /// </summary>
        /// <param name="id">Identificador único da entidade</param>
        bool Excluir(int id);

        /// <summary>
        /// Consulta uma entidade através do identificador único
        /// </summary>
        /// <param name="id">Identificador único da entidade</param>
        /// <returns>Retorna a entidade consultada</returns>
        TEntidade Consultar(int id);

        /// <summary>
        /// Consulta uma entidade através do identificador único
        /// </summary>
        /// <param name="id">Identificador único da entidade</param>
        /// <returns>Retorna a entidade consultada</returns>
        TEntidade Consultar(Guid id);

        /// <summary>
        /// Consulta através de uma expressão
        /// </summary>
        /// <param name="query">Expressão Linq com a consulta</param>
        /// <example>
        /// </example>
        /// <returns name="IEnumerable<TEntidade>"/>
        IEnumerable<TEntidade> Consultar(Expression<Func<TEntidade, bool>> query);

        /// <summary>
        /// Consulta uma lista paginada
        /// </summary>
        /// <param name="t">Número de registros por capturar</param>
        /// <param name="s">Número de registros que vai ignorar</param>
        /// <example>
        /// Possui uma paginação de dez registros por página, então
        /// <see cref="ListarPaginado(10,0)"/> vai retornar os dez primeiros registros
        /// <see cref="ListarPaginado(20,10)"/> vai retornar dez registros e ignorar os dez primeiros
        /// <see cref="ListarPaginado(30,20)"/> vai retornar dez registros e ignorar os vinte primeiros
        /// </example>
        /// <returns name="IEnumerable<TEntidade>"/>
        IEnumerable<TEntidade> Listar(int t, int s);

        /// <summary>
        /// Lista todos os dados da entidade
        /// </summary>
        /// <returns>Retorna todos os dados da entidade</returns>
        IEnumerable<TEntidade> Listar();

        /// <summary>
        /// Lista todos os dados da entidade aplicando filtros
        /// </summary>
        /// <param name="fil">Parâmetros referente ao Where da expressão</param>
        /// <param name="ord">Parâmetro referente ao OrderBy da expressão</param>
        /// <example>
        /// Para uma entidade Pessoa que possui diversas propriedades
        /// <see cref="Listar(p => p.IsAtiva && p.IsFisica, p => p.Nome, p => p.Id);"/>
        /// </example>
        /// <returns></returns>
        IEnumerable<TEntidade> Listar(Expression<Func<TEntidade, bool>> fil, params Expression<Func<TEntidade, object>>[] ord);

        /// <summary>
        /// Confirma as alterações na base de dados através do Entity Framework
        /// </summary>
        /// <returns>Número de linhas afetadas</returns>
        int SaveChanges();
    }
}
