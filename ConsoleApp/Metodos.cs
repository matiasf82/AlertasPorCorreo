using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Metodos
    {
        private readonly string url = "https://localhost:7152/api/Correos/SendEmailAsync";
        private HttpClient cliente = new();

        //usando PostAsJsonAsync
        public async Task EnviarPostAsJsonAsync()
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

        //usando PostAsync() --> con este se puede enviar cualquier cosa (un archivo por ejemplo) en el paramero "contenido"
        //en este caso uso un StringContent (clase que deriva de HttpContent), es decir, se puede usar cualquier clase que herede de HttpContent
        public async Task EnviarPostAsync()
        {
            var correo = new Correo
            {
                Asunto = "Asunto del correo",
                Destinatarios = "correo@gmail.com; correo@gmail.com",
                Copias = "copia1@gmail.com; copia2@gmail.com",
                Cuerpo = "cuerpo del correo",
            };

            var json = JsonSerializer.Serialize(correo);
            var contenido =  new StringContent(json, Encoding.UTF8, "application/json");
            var respuesta = await cliente.PostAsync(url, contenido);
            if (respuesta.IsSuccessStatusCode)
            {
                Console.WriteLine("OK");
            }
        }

       //public async Task EnviarMail()
       // {
       //     var mail = new MailRequest();
       //     mail.Email = "matiasferreyra82@outlook.com.ar";
       //     mail.Subject = "asunto del mail";
       //     mail.Body = "cuerpo del mail, prueba numero 3";

       //     //var json = JsonSerializer.Serialize(mail);
       //     //var contenido = new StringContent(json, Encoding.UTF8, "application/json");
       //     var respuesta = await cliente.PostAsJsonAsync(url, mail);
       //     if (respuesta.IsSuccessStatusCode)
       //     {
       //         Console.WriteLine("OK");
       //     }
       // }
    }
}
