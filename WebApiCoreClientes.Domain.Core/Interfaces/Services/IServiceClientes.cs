using System;
using System.Collections.Generic;
using System.Text;
using WebApiCoreClientes.Application.DTO.DTO;
using WebApiCoreClientes.Domain.Models;

namespace WebApiCoreClientes.Domain.Core.Interfaces.Services
{
    public interface IServiceClientes
    {
        public void Adicionar(Clientes item);

        public void Atualizar(Clientes item);

        public Clientes ListarId(int id);

        public IEnumerable<Clientes> ListarTodos();

        public void Remover(Clientes item);
    }
}
