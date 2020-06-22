using System;
using System.Collections.Generic;
using WebApiCoreClientes.Domain.Models;

namespace WebApiCoreClientes.Domain.Core.Interfaces.Services
{
    public interface IServiceEnderecos
    {
        public void Adicionar(Enderecos item);

        public void Atualizar(Enderecos item);

        public Enderecos ListarId(int id);

        public IEnumerable<Enderecos> ListarTodos();

        public void Remover(Enderecos item);
    }
}
