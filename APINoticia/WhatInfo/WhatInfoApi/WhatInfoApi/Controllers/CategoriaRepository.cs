using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WhatInfoApi.Context;
using WhatInfoApi.Interface;
using WhatInfoApi.models;

namespace WhatInfoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> GetCategorias()
        {
            return _context.Categorias.ToList();
        }

        [HttpGet("id", Name = "ObterCategoria")]
        public Categoria GetId(int id)
        {
            return _context.Categorias.FirstOrDefault(c => c.CategoriaId == id);
            
        }
        public Categoria Create(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            return categoria;
        }

        public Categoria Update(Categoria categoria)
        {
            _context.Entry(categoria).State = EntityState.Modified;
            _context.SaveChanges();
            return categoria;
        }
        public Categoria Delete(int id)
        {
            var categorias = _context.Categorias.Find(id);
            _context.Categorias.Remove(categorias);
            _context.SaveChanges();
            return categorias;
        }

    }
}
