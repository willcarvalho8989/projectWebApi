using System;
using System.Collections.Generic;
using WebApiCoreClientes.Domain.Core.Interfaces.Repositorys;
using WebApiCoreClientes.Domain.Core.Interfaces.Services;

namespace WebApiCoreClientes.Domain.Services.Services
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> Repository)
        {
            _repository = Repository;
        }

        public virtual void Adicionar(T item)
        {
            _repository.Adicionar(item);
        }

        public virtual T ListarId(int id)
        {
            return _repository.ListarId(id);
        }
        public virtual IEnumerable<T> ListarTodos()
        {
            return _repository.ListarTodos();
        }
        public virtual void Remover(T item)
        {
            _repository.Remover(item);
        }
        public virtual void Atualizar(T item)
        {
            _repository.Atualizar(item);
        }
    }

}
