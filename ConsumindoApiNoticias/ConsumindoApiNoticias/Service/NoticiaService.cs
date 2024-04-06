using ConsumindoApiNoticias.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoApiNoticias.Service
{
    internal class NoticiaService
    {
        public async Task<Noticia> Getnoticias(int id)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"https://localhost:7054/Noticia/{id}");
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var jsonConvert = JsonConvert.DeserializeObject<Noticia>(jsonResponse);

            if (jsonConvert != null)
            {
                return jsonConvert;
            }else
            {
                return new Noticia
                {
                    validacao = false
                };
            }
        }
    }
}
