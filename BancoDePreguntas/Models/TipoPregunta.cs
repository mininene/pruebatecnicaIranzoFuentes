using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancoDePreguntas.Models
{
    public class TipoPregunta
    {
        public int Id { get; set; }
        public string TipoDePregunta { get; set; }

        public virtual ICollection<Pregunta> Preguntas { get; set; }
    }
}