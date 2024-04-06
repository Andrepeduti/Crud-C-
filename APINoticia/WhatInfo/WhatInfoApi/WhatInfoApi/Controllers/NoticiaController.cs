using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using WhatInfoApi.Context;
using WhatInfoApi.models;

namespace WhatInfoApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NoticiaController : ControllerBase
    {
        private readonly AppDbContext _context;
        public NoticiaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Noticia>> Get()
        {
            var noticia = _context.Noticias.ToList();
            _context.SaveChanges();

            return Ok(noticia);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var noticia = _context.Noticias.FirstOrDefault(p => p.NoticiaId == id);
            if(noticia == null)
            {
                return NotFound($"Id {id} não encontrado, por favor preencha novamente");
            }
            return Ok(noticia);
        }

        [HttpPost]
        public ActionResult Post(Noticia noticia)
        {
            _context.Noticias.Add(noticia);
            _context.SaveChanges();

            //return CreatedAtAction(nameof(Get), new { id = noticia.NoticiaId }, noticia);
            return Ok("Noticia cadastrado com sucesso.");
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Noticia noticia)
        {
            if (id != noticia.NoticiaId)
            {
                return NotFound($"Id {id} está incorreto, informe outro!");
            }
            _context.Entry(noticia).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(noticia);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var noticia = _context.Noticias.FirstOrDefault(p => p.NoticiaId == id);
            if (noticia == null)
            {
                return NotFound($"Id {id} não encontrado, tente outro!");
            }
          
            _context.Remove(noticia);
            _context.SaveChanges();

            return Ok($"Noticia foi removida com sucesso!");
        }
    }
}
