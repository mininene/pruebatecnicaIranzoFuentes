using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BancoDePreguntas.Models
{
    public partial class Pregunta
    {
        public int Id { get; set; }

        [ForeignKey("Estudio")]
        public Nullable<int> EstudioId { get; set; }

        [ForeignKey("Asignatura")]
        public Nullable<int> AsignaturaId { get; set; }

        [ForeignKey("Tema")]
        public Nullable<int> TemaId { get; set; }

        [ForeignKey("TipoPregunta")]
        public Nullable<int> TipoId { get; set; }

        [ForeignKey("Idioma")]
        public Nullable<int> IdiomaId { get; set; }

        public string PreguntaTextual { get; set; }

        [ForeignKey("Respuesta")]
        public Nullable<int> RespuestaId { get; set; }

        [ForeignKey("GradoDificultad")]
        public Nullable<int> DificultadId { get; set; }
                      
        [ForeignKey("TiempoRealizacion")]
        public Nullable<int> TiempodId { get; set; }

        public System.DateTime FechaCreacion { get; set; }
       
        public System.DateTime FechaActualizacion { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]


        public virtual Estudio Estudio { get; set; }
        public virtual Asignatura Asignatura { get; set; }
        public virtual Tema Tema { get; set; }
        public virtual TipoPregunta TipoPregunta { get; set; }
        public virtual Idioma Idioma { get; set; }
        public virtual Respuesta Respuesta { get; set; }
        public virtual GradoDificultad GradoDificultad { get; set; }
        public virtual TiempoRealizacion TiempoRealizacion { get; set; }

    }

   
}