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
    public class ApplicationServiceEnderecos : IApplicationServiceEnderecos
    {
        private readonly IServiceEnderecos _serviceEnderecos;
        private readonly IMapperEnderecos _mapperEnderecos;

        public ApplicationServiceEnderecos(IServiceEnderecos ServiceEnderecos, IMapperEnderecos MapperEnderecos)
        {
            _serviceEnderecos = ServiceEnderecos;
            _mapperEnderecos = MapperEnderecos;
        }

        public void Adicionar(EnderecosDTO item)
        {
            var enderecos = _mapperEnderecos.MapperUnidadeEnderecos(item);
            _serviceEnderecos.Adicionar(enderecos);
        }

        public void Atualizar(EnderecosDTO item)
        {
            var enderecos = _mapperEnderecos.MapperUnidadeEnderecos(item);
            _serviceEnderecos.Atualizar(enderecos);
        }

        public EnderecosDTO ListarId(int id)
        {
            var enderecos = _serviceEnderecos.ListarId(id);
            return _mapperEnderecos.MapperDTO(enderecos);
        }

        public IEnumerable<EnderecosDTO> ListarTodos()
        {
            var listaEnderecos = _serviceEnderecos.ListarTodos();
            return _mapperEnderecos.MapperListaEnderecos(listaEnderecos);
        }

        public void Remover(EnderecosDTO item)
        {
            var enderecos = _mapperEnderecos.MapperUnidadeEnderecos(item);
            _serviceEnderecos.Remover(enderecos);
        }
    }
}
