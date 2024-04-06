using WhatInfoApi.models;
using Microsoft.EntityFrameworkCore;

namespace WhatInfoApi.Context;
public class AppDbContext : DbContext
    {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Noticia> Noticias { get; set; }
    }

