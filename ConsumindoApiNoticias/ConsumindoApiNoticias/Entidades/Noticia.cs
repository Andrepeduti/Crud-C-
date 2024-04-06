using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoApiNoticias.Entidades
{
    internal class Noticia
    {
        public int NoticiaId { get; set; }
        public string? NoticiaTitulo { get; set; }
        public string? NoticiaDescricao { get; set; }
        public DateTime NoticiaData { get; set; }
        public string? PublicadorNome { get; set; }
        public string? NoticiaLocal { get; set; }
        public bool validacao = true;
    }
}
