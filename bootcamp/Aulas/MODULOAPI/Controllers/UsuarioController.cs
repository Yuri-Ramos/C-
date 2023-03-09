using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MODULOAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    
    {
        [HttpGet("ObterDataHoraNow")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                date = DateTime.Now.ToLongDateString(),
                hora = DateTime.Now.ToShortDateString()
            };
            return Ok(obj);
        }
        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Nome: {nome}, seja bem vindo!";
            return Ok(new{mensagem});

        }
    }
}