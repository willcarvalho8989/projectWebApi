using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiCoreClientes.Domain.Models
{
    public class Enderecos : ModelBase
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

    }
}
