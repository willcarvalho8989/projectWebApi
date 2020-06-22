using WebApiCoreClientes.Mapper.Interfaces;
using WebApiCoreClientes.Domain.Models;
using WebApiCoreClientes.Application.DTO.DTO;
using System.Collections.Generic;

namespace WebApiCoreClientes.Mapper.Services
{
    public class MapperClientes : IMapperClientes
    {
        List<ClientesDTO> clientesDTOs = new List<ClientesDTO>();

        #region Mapeamentos
        public Clientes MapperUnidadeClientes(ClientesDTO clientesDTO)
        {
            Clientes clientes = new Clientes
            {
                Id = clientesDTO.Id,
                Nome = clientesDTO.Nome,
                Cpf = clientesDTO.Cpf,
                Idade = clientesDTO.Idade,
                DataNascimento = clientesDTO.DataNascimento
            };

            return clientes;
        }

        public IEnumerable<ClientesDTO> MapperListaClientes(IEnumerable<Clientes> clientes)
        {
            foreach (var item in clientes)
            {
                ClientesDTO clienteDTO = new ClientesDTO
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Cpf = item.Cpf,
                    DataNascimento = item.DataNascimento,
                    Idade = item.Idade
                };

                clientesDTOs.Add(clienteDTO);
            }

            return clientesDTOs;
        }

        public ClientesDTO MapperDTO(Clientes clientes)
        {
            ClientesDTO clienteDTO = new ClientesDTO
            {
                Id = clientes.Id,
                Nome = clientes.Nome,
                Cpf = clientes.Cpf,
                DataNascimento = clientes.DataNascimento,
                Idade = clientes.Idade
            };

            return clienteDTO;
        }
        #endregion
    }
}
