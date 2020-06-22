using System;
using System.Collections.Generic;
using WebApiCoreClientes.Domain.Models;
using WebApiCoreClientes.Application.DTO.DTO;

namespace WebApiCoreClientes.Mapper.Interfaces
{
    public interface IMapperClientes
    {
        Clientes MapperUnidadeClientes(ClientesDTO clientesDTO);

        IEnumerable<ClientesDTO> MapperListaClientes(IEnumerable<Clientes> listaClientes);

        ClientesDTO MapperDTO(Clientes clientes);
    }
}
