using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using WhatInfoApi.Validation;

namespace WhatInfoApi.models
{
    [Table("Noticias")]
    public class Noticia
    {
        [Key]
        public int NoticiaId { get; set; }
        [Required]
        [StringLength(70)]
        [ValidaPrimeiraLetra]
        public string? NoticiaTitulo{ get; set; }
        [Required]
        public string? NoticiaDescricao { get; set; }
        public DateTime NoticiaData { get; set; }
        [Required]
        [ValidaPrimeiraLetra]
        public string? PublicadorNome { get; set; }
        [Required]
        public string? NoticiaLocal { get; set; }
        public int categoriaId { get; set; }
        [JsonIgnore]
        public Categoria? Categoria { get; set; }
    }
}
