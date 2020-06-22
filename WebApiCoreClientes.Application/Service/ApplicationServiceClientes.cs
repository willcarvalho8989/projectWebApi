using System;
using System.Collections.Generic;
using WebApiCoreClientes.Application.Interfaces;
using WebApiCoreClientes.Application.DTO.DTO;
using WebApiCoreClientes.Domain.Core.Interfaces.Services;
using AutoMapper;
using WebApiCoreClientes.Mapper;
using WebApiCoreClientes.Mapper.Interfaces;

namespace WebApiCoreClientes.Application.Service
{
    public class ApplicationServiceClientes : IApplicationServiceClientes
    {
        private readonly IServiceClientes _serviceClientes;
        private readonly IMapperClientes _mapperClientes;

        public ApplicationServiceClientes(IServiceClientes ServiceClientes, IMapperClientes MapperClientes)
        {
            _serviceClientes = ServiceClientes;
            _mapperClientes = MapperClientes;
        }

        public void Adicionar(ClientesDTO item)
        {
            var clientes = _mapperClientes.MapperUnidadeClientes(item);
            _serviceClientes.Adicionar(clientes);
        }

        public void Atualizar(ClientesDTO item)
        {
            var clientes = _mapperClientes.MapperUnidadeClientes(item);
            _serviceClientes.Atualizar(clientes);
        }

        public ClientesDTO ListarId(int id)
        {
            var clientes = _serviceClientes.ListarId(id);
            return _mapperClientes.MapperDTO(clientes);
        }

        public IEnumerable<ClientesDTO> ListarTodos()
        {
            var listaClientes = _serviceClientes.ListarTodos();
            return _mapperClientes.MapperListaClientes(listaClientes);
        }

        public void Remover(ClientesDTO item)
        {
            var clientes = _mapperClientes.MapperUnidadeClientes(item);
            _serviceClientes.Remover(clientes);
        }
    }
}
