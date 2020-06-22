using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiCoreClientes.Application.DTO.DTO
{
    public class ClientesDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
