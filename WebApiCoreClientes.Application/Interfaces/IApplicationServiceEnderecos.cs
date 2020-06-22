using System;
using System.Collections.Generic;
using WebApiCoreClientes.Application.DTO.DTO;

namespace WebApiCoreClientes.Application.Interfaces
{
    public interface IApplicationServiceEnderecos
    {
        void Adicionar(EnderecosDTO item);

        EnderecosDTO ListarId(int id);

        IEnumerable<EnderecosDTO> ListarTodos();

        void Remover(EnderecosDTO item);

        void Atualizar(EnderecosDTO item);
    }
}
