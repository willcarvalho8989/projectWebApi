using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiCoreClientes.Domain.Models
{
    public class Clientes : ModelBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
