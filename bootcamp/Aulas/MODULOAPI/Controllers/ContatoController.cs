using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MODULOAPI.Context;
using MODULOAPI.Entities;

namespace MODULOAPI.Controllers
{
      [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController (AgendaContext context) 
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
           return CreatedAtAction(nameof(ObterId), new { id = contato.Id},contato);
            // return Ok(contato);
        }

        [HttpGet("{id}")]
        public IActionResult ObterId(int id)
        {
            var contato = _context.Contatos.Find(id);
            //verifica se contato é null
            if (contato == null)
            {
                return NotFound();
            }
            return Ok(contato);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, Contato contato)
        {
                var contatoBanco = _context.Contatos.Find(id);
                  if (contatoBanco == null)
            {
                return NotFound();
            }
            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;
            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();
            return Ok(contatoBanco);
                
        }

    public IActionResult Deletar(int id)
    {
        var contatoBanco = _context.Contatos.Find(id);
        if (contatoBanco == null)
        {
            return NotFound();
        }
        _context.Contatos.Remove(contatoBanco);
        _context.SaveChanges();
        var message = $"contato : {contatoBanco.Nome} removido com sucesso.";
        return Ok(message);
            //return NoContent();
        }
        [HttpGet("{nome}")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatoBanco = _context.Contatos.Where(x => x.Nome.Contains(nome));
            if (contatoBanco == null)
            {
                return NotFound();
            }
            return Ok(contatoBanco);

        }

    }
}