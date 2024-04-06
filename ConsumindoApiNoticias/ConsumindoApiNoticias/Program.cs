using ConsumindoApiNoticias.Entidades;
using ConsumindoApiNoticias.Service;

namespace ConsumindoApiNoticia
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Informe um ID");
            int id = int.Parse(Console.ReadLine());

            NoticiaService noticiaService = new NoticiaService();
            Noticia noticia = await noticiaService.Getnoticias(id);

            if (noticia.validacao)
            {
                Console.WriteLine("Produto encontrado");
                Console.WriteLine("######################");
                Console.WriteLine("Titulo da Noticia: " + noticia.NoticiaTitulo);
                Console.WriteLine("Local da Noticia: " + noticia.NoticiaLocal);
                Console.WriteLine("Data da Noticia: " + noticia.NoticiaData);
                Console.WriteLine("Descrição da Noticia: " + noticia.NoticiaDescricao);
                Console.WriteLine("Publicador da Noticia: " + noticia.PublicadorNome);
                Console.WriteLine("######################");
            }
            else
            {
                noticia.validacao = false;
                Console.WriteLine("Não encontrado");
            }
        }
    }
}