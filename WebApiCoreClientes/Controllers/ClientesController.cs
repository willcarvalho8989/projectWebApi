using System;
using System.Collections.Generic;
using System.Linq;
using WebApiCoreClientes.Application.DTO.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCoreClientes.Application.Interfaces;

namespace WebApiCoreClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {

        private readonly IApplicationServiceClientes _applicationServiceClientes;

        public ClientesController(IApplicationServiceClientes ApplicationServiceClientes)
        {
            _applicationServiceClientes = ApplicationServiceClientes;
        }

        // GET: api/Clientes
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceClientes.ListarTodos());
        }

        // GET: api/Clientes/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceClientes.ListarId(id));
        }

        // POST: api/Clientes
        [HttpPost]
        public ActionResult Post([FromBody] ClientesDTO clientesDTO)
        {
            try
            {
                if(clientesDTO == null)
                {
                    return NotFound();
                }

                _applicationServiceClientes.Adicionar(clientesDTO);
                return Ok("Cliente cadastrado!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT: api/Clientes/5
        [HttpPut]
        public ActionResult Put([FromBody] ClientesDTO clientesDTO)
        {
            try
            {
                if(clientesDTO == null)
                {
                    return NotFound();
                }

                _applicationServiceClientes.Atualizar(clientesDTO);
                return Ok("Cliente atualizado!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ClientesDTO clientesDTO)
        {
            try
            {
                if (clientesDTO == null)
                {
                    return NotFound();
                }

                _applicationServiceClientes.Remover(clientesDTO);
                return Ok("Cliente deletado!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
