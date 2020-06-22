using WebApiCoreClientes.Domain.Core.Interfaces.Repositorys;
using WebApiCoreClientes.Domain.Core.Interfaces.Services;
using WebApiCoreClientes.Domain.Models;

namespace WebApiCoreClientes.Domain.Services.Services
{
    public class ServiceClientes : ServiceBase<Clientes>, IServiceClientes
    {
        public readonly IRepositoryClientes _repositoryClientes;

        public ServiceClientes(IRepositoryClientes RepositoryClientes)
            : base(RepositoryClientes)
        {
            _repositoryClientes = RepositoryClientes;
        }

    }
}
