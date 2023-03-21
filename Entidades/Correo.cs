using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Correo
    {
        public int Id { get; set; }
        public string Destinatarios { get; set; }
        public string Copias { get; set; }
        public string Asunto { get; set; }
        public string Cuerpo { get; set; }
    }
}
