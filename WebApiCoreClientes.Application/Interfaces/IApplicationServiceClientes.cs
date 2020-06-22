using System;
using System.Collections.Generic;
using WebApiCoreClientes.Application.DTO.DTO;

namespace WebApiCoreClientes.Application.Interfaces
{
    public interface IApplicationServiceClientes
    {
        void Adicionar(ClientesDTO item);

        ClientesDTO ListarId(int id);

        IEnumerable<ClientesDTO> ListarTodos();

        void Remover(ClientesDTO item);

        void Atualizar(ClientesDTO item);
    }
}
