using WebApiCoreClientes.Domain.Core.Interfaces.Repositorys;
using WebApiCoreClientes.Domain.Core.Interfaces.Services;
using WebApiCoreClientes.Domain.Models;

namespace WebApiCoreClientes.Domain.Services.Services
{
    public class ServiceEnderecos : ServiceBase<Enderecos>, IServiceEnderecos
    {
        private readonly IRepositoryEnderecos _repositoryEnderecos;

        public ServiceEnderecos(IRepositoryEnderecos RepositoryEnderecos)
            : base(RepositoryEnderecos)
        {
            _repositoryEnderecos = RepositoryEnderecos;
        }
    }
}
