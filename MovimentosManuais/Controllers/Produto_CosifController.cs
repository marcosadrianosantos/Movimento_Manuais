using Microsoft.AspNetCore.Mvc;
using MovimentosManuais.Application.Interfaces;
using System;

namespace MovimentosManuais.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Produto_CosifController : ControllerBase
    {
        private readonly IProduto_CosifService service;

        public Produto_CosifController(IProduto_CosifService service)
        {
            this.service = service;
        }

        [HttpGet("{codProduto}")]
        public IActionResult GetByCodProduto(string codProduto)
        {
            try
            {
                return Ok(service.GetByCodProduto(codProduto));
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
