using System;
using System.Collections.Generic;
using WebApiCoreClientes.Mapper.Interfaces;
using WebApiCoreClientes.Domain.Models;
using WebApiCoreClientes.Application.DTO.DTO;

namespace WebApiCoreClientes.Mapper.Services
{
    public class MapperEnderecos : IMapperEnderecos
    {
        List<EnderecosDTO> enderecosDTOs = new List<EnderecosDTO>();

        #region Mapeamentos
        public Enderecos MapperUnidadeEnderecos(EnderecosDTO enderecosDTO)
        {
            Enderecos enderecos = new Enderecos
            {
                Id = enderecosDTO.Id,
                Logradouro = enderecosDTO.Logradouro,
                Bairro = enderecosDTO.Bairro,
                Cidade = enderecosDTO.Cidade,
                Estado = enderecosDTO.Estado
            };

            return enderecos;
        }

        public IEnumerable<EnderecosDTO> MapperListaEnderecos(IEnumerable<Enderecos> enderecos)
        {
            foreach (var item in enderecos)
            {
                EnderecosDTO enderecosDTO = new EnderecosDTO
                {
                    Id = item.Id,
                    Logradouro = item.Logradouro,
                    Bairro = item.Bairro,
                    Cidade = item.Cidade,
                    Estado = item.Estado
                };

                enderecosDTOs.Add(enderecosDTO);
            }

            return enderecosDTOs;
        }

        public EnderecosDTO MapperDTO(Enderecos enderecos)
        {
            EnderecosDTO enderecoDTO = new EnderecosDTO
            {
                Id = enderecos.Id,
                Logradouro = enderecos.Logradouro,
                Bairro = enderecos.Bairro,
                Cidade = enderecos.Cidade,
                Estado = enderecos.Estado
            };

            return enderecoDTO;
        }
        #endregion
    }
}
