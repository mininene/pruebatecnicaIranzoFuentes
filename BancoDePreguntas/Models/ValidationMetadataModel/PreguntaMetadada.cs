using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BancoDePreguntas.Models
{
    public class PreguntaMetadada
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey("Estudio")]
        public Nullable<int> EstudioId { get; set; }

        [Required]
        [ForeignKey("Asignatura")]
        public Nullable<int> AsignaturaId { get; set; }

        [Required]
        [ForeignKey("Tema")]
        public Nullable<int> TemaId { get; set; }

        [Required]
        [ForeignKey("TipoPregunta")]
        public Nullable<int> TipoId { get; set; }

        [Required]
        [ForeignKey("Idioma")]
        public Nullable<int> IdiomaId { get; set; }

        [Required]
        public string PreguntaTextual { get; set; }

        [Required]
        [ForeignKey("Respuesta")]
        public Nullable<int> RespuestaId { get; set; }

        [Required]
        [ForeignKey("GradoDificultad")]
        public Nullable<int> DificultadId { get; set; }

        [Required]
        [ForeignKey("TiempoRealizacion")]
        [Display(Name="Duración")]
        public Nullable<int> TiempodId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        public System.DateTime FechaCreacion { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime FechaActualizacion { get; set; }
    }

    [MetadataType(typeof(PreguntaMetadada))]
    public partial class Pregunta
    { }
}