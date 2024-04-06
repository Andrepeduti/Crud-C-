using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using WhatInfoApi.Validation;

namespace WhatInfoApi.models
{
    [Table("Categorias")]
    public class Categoria
    {
        public Categoria() //Inicializando a propriedade 
        {
            Noticia = new Collection<Noticia>();
        }
        [Key]
        public int CategoriaId { get; set; }
        [Required]
        [StringLength(15)]
        [ValidaPrimeiraLetra]
        public string? CategoriaName { get; set; }
        
        public ICollection<Noticia>? Noticia { get; set; }
    }
}
