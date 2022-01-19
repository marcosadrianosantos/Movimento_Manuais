using Microsoft.AspNetCore.Mvc;
using MovimentosManuais.Application.Interfaces;
using System;

namespace MovimentosManuais.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService service;

        public ProdutoController(IProdutoService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(service.GetAll());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
