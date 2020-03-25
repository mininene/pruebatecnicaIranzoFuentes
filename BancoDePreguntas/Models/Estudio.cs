using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancoDePreguntas.Models
{
    public class Estudio
    {
        public int Id { get; set; }
        public string NombreEstudio { get; set; }

        public virtual ICollection<Pregunta> Preguntas { get; set; }
    }
}