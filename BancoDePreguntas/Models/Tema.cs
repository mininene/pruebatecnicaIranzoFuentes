using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancoDePreguntas.Models
{
    public class Tema
    {
        public int Id { get; set; }
        public string NombreTema { get; set; }

        public virtual ICollection<Pregunta> Preguntas { get; set; }
    }
}