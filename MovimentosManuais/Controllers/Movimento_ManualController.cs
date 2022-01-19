using Microsoft.AspNetCore.Mvc;
using MovimentosManuais.Application.Interfaces;
using MovimentosManuais.Application.ViewModel.Movimento_Manual;
using System;

namespace MovimentosManuais.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Movimento_ManualController : ControllerBase
    {
        private readonly IMovimento_ManualService service;

        public Movimento_ManualController(IMovimento_ManualService service)
        {
            this.service = service;
        }

        [HttpPost]
        public IActionResult Post(Movimento_ManualViewModel movimentoManual)
        {
            try
            {
                return Ok(service.Post(movimentoManual));
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
