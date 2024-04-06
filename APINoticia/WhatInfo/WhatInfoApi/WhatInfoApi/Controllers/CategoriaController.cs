using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WhatInfoApi.Context;
using WhatInfoApi.Filters;
using WhatInfoApi.Interface;
using WhatInfoApi.models;

namespace WhatInfoApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _repository;
        public CategoriaController(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [ServiceFilter(typeof(ApiLoggingFilter))]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            var categoria = _repository.GetCategorias();
            return Ok(categoria);
        }

        [HttpGet("{id}", Name = "ObterCategoria")]
        public ActionResult Get(int id)
        {
            var categoria = _repository.GetId(id);
            if (categoria is null)
            {
                return NotFound($"Categoria com ID: {id}, não encontrado");
            }
            return Ok(categoria);
        }

        [HttpPost]
        public ActionResult Post(Categoria categoria)
        {
            var categoriaCriada = _repository.Create(categoria);
            return new CreatedAtRouteResult("ObterCategoria", new { id = categoriaCriada.CategoriaId }, categoria);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Categoria categoria)
        {
            _repository.Update(categoria);
            return Ok(categoria);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var categoria = _repository.GetId(id);
            if (categoria == null)
            {
                return NotFound($"Categoria com ID {id} não foi encontrado");
            }
            var categoriaExcluida = _repository.Delete(id);
            return Ok(categoriaExcluida);
        }
    }
}
