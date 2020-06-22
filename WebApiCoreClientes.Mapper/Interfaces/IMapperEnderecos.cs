using System.Collections.Generic;
using WebApiCoreClientes.Domain.Models;
using WebApiCoreClientes.Application.DTO.DTO;

namespace WebApiCoreClientes.Mapper.Interfaces
{
    public interface IMapperEnderecos
    {
        Enderecos MapperUnidadeEnderecos(EnderecosDTO enderecosDTO);

        IEnumerable<EnderecosDTO> MapperListaEnderecos(IEnumerable<Enderecos> listaEnderecos);

        EnderecosDTO MapperDTO(Enderecos enderecos);
    }
}
