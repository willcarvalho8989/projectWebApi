using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiCoreClientes.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryBase<T> where T : class
    {
        void Adicionar(T item);

        T ListarId(int id);

        IEnumerable<T> ListarTodos();

        void Remover(T item);

        void Atualizar(T item);
    }
}
