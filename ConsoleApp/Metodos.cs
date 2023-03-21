using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Metodos
    {
        private readonly string url = "https://localhost:7152/api/Correos/Insertar";
        private HttpClient cliente = new();
        public async Task Enviar()
        {
            var correo = new Correo
            {
                Asunto = "Asunto del correo",
                Destinatarios = "correo@gmail.com; correo@gmail.com",
                Copias = "copia1@gmail.com; copia2@gmail.com",
                Cuerpo = "cuerpo del correo",
            };

            var respuesta = await cliente.PostAsJsonAsync(url, correo);
            if (respuesta.IsSuccessStatusCode)
            {
                Console.WriteLine("OK");
            }
           
        }
    }
}
