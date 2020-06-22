using System;
using System.Collections.Generic;
using WebApiCoreClientes.Application.DTO.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCoreClientes.Application.Interfaces;

namespace WebApiCoreClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecosController : ControllerBase
    {
        private readonly IApplicationServiceEnderecos _applicationServiceEnderecos;

        public EnderecosController(IApplicationServiceEnderecos ApplicationServiceEnderecos)
        {
            _applicationServiceEnderecos = ApplicationServiceEnderecos;
        }

        // GET: api/Enderecos
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceEnderecos.ListarTodos());
        }

        // GET: api/Enderecos/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceEnderecos.ListarId(id));
        }

        // POST: api/Enderecos
        [HttpPost]
        public ActionResult Post([FromBody] EnderecosDTO enderecosDTO)
        {
            try
            {
                if (enderecosDTO == null)
                {
                    return NotFound();
                }

                _applicationServiceEnderecos.Adicionar(enderecosDTO);
                return Ok("Endereço cadastrado!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT: api/Enderecos/5
        [HttpPut]
        public ActionResult Put([FromBody] EnderecosDTO enderecosDTO)
        {
            try
            {
                if (enderecosDTO == null)
                {
                    return NotFound();
                }

                _applicationServiceEnderecos.Atualizar(enderecosDTO);
                return Ok("Endereço atualizado!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] EnderecosDTO enderecosDTO)
        {
            try
            {
                if (enderecosDTO == null)
                {
                    return NotFound();
                }

                _applicationServiceEnderecos.Remover(enderecosDTO);
                return Ok("Endereço deletado!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
