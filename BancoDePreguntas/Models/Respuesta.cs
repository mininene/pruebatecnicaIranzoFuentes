using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancoDePreguntas.Models
{
    public class Respuesta
    {
        public int Id { get; set; }
        public string Respuestas { get; set; }

        public virtual ICollection<Pregunta> Preguntas { get; set; }
    }
}