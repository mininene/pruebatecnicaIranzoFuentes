using BancoDePreguntas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancoDePreguntas.DAL
{
    public class PreguntaInitializer: System.Data.Entity.DropCreateDatabaseAlways<PreguntaContext>
    {

        protected override void Seed(PreguntaContext context)
        {
          
            var listaEstudio = new List<Estudio>
            {

            new Estudio{Id=1,NombreEstudio= "Medio"},
            new Estudio{Id=2,NombreEstudio= "Superior"},
            new Estudio{Id=3,NombreEstudio= "Avanzado"},
            

            };
            listaEstudio.ForEach(s => context.Estudio.Add(s));
            context.SaveChanges();

            var listaAsignatura = new List<Asignatura>
            {
            new Asignatura{Id=1,NombreAsignatura= "Literatura"},
            new Asignatura{Id=2, NombreAsignatura= "Matematica"},
            new Asignatura{Id=3, NombreAsignatura= "Fisica"},
            new Asignatura{Id=4, NombreAsignatura= "Quimica"},
            

            };
            listaAsignatura.ForEach(s => context.Asignatura.Add(s));
            context.SaveChanges();

            var listaTema = new List<Tema>
            {
            new Tema{Id=1,NombreTema= "Calculo"},
            new Tema{Id=2,NombreTema= "Integrales"},
            new Tema{Id=3, NombreTema= "Narrativa"},
            new Tema{Id=4, NombreTema= "Lirica"},
            new Tema{Id=5, NombreTema= "Inercia"},
            new Tema{Id=6, NombreTema= "Movimiento"},

            };
            listaTema.ForEach(s => context.Tema.Add(s));
            context.SaveChanges();

            var listaTipoPregunta = new List<TipoPregunta>
            {
            
            new TipoPregunta{Id=1, TipoDePregunta= "Selección Multiple"},

            };
            listaTipoPregunta.ForEach(s => context.TipoPregunta.Add(s));
            context.SaveChanges();

            var listaIdioma = new List<Idioma>
            {
            
            new Idioma{Id=1,Lenguaje= "Español"},
            new Idioma{Id=2, Lenguaje= "Ingles"},
          

            };
            listaIdioma.ForEach(s => context.Idioma.Add(s));
            context.SaveChanges();

            var listaRespuestas = new List<Respuesta>
            {
            new Respuesta{Id=1,Respuestas= "Verdadero"},
            new Respuesta{Id=2, Respuestas= "Falso"},
            new Respuesta{Id=3,Respuestas= "True"},
             new Respuesta{Id=4,Respuestas= "False"},
                         
            };
            listaRespuestas.ForEach(s => context.Respuesta.Add(s));
            context.SaveChanges();

            var listaGradoDificultad = new List<GradoDificultad>
            {
            new GradoDificultad{Id=1,Nivel="Bajo"},
            new GradoDificultad{Id=2, Nivel="Medio"},
            new GradoDificultad{Id=3, Nivel="Alto"},

            };
            listaGradoDificultad.ForEach(s => context.GradoDificultad.Add(s));
            context.SaveChanges();

            var listaTiempoRealizacion = new List<TiempoRealizacion>
            {
            new TiempoRealizacion{Id=1,Tiempo="5"},
            new TiempoRealizacion{Id=2, Tiempo= "10"},
            new TiempoRealizacion{Id=3, Tiempo= "15"},

            };
            listaTiempoRealizacion.ForEach(s => context.TiempoRealizacion.Add(s));
            context.SaveChanges();


            var listaPregunta = new List<Pregunta>
            {
               
      new Pregunta{TemaId=3,TipoId=1, IdiomaId=1,DificultadId=2,TiempodId=1,AsignaturaId=1,EstudioId=2, RespuestaId=1, PreguntaTextual="¿Es verosimil?",FechaCreacion=DateTime.Parse("2020-03-25"), FechaActualizacion =DateTime.Parse("2020-03-26")},
      new Pregunta{TemaId=1,TipoId=1, IdiomaId=2,DificultadId=1,TiempodId=2,AsignaturaId=2,EstudioId=3, RespuestaId=3, PreguntaTextual="¿10*10=100?",FechaCreacion=DateTime.Parse("2020-03-25"), FechaActualizacion=DateTime.Parse("2020-03-26")},
      new Pregunta{TemaId=1,TipoId=1, IdiomaId=1,DificultadId=1,TiempodId=3,AsignaturaId=2,EstudioId=2, RespuestaId=2, PreguntaTextual="4-2 = 1",FechaCreacion=DateTime.Parse("2020-03-25"), FechaActualizacion=DateTime.Parse("2020-03-26")},
      new Pregunta{TemaId=1,TipoId=1, IdiomaId=1,DificultadId=2,TiempodId=2,AsignaturaId=2,EstudioId=3, RespuestaId=1, PreguntaTextual="2x2 =4",FechaCreacion=DateTime.Parse("2020-03-25"), FechaActualizacion =DateTime.Parse("2020-03-26")},
      new Pregunta{TemaId=4,TipoId=1, IdiomaId=1,DificultadId=1,TiempodId=1,AsignaturaId=1,EstudioId=2, RespuestaId=2, PreguntaTextual="¿elegía es antonimo de Lirica?",FechaCreacion=DateTime.Parse("2020-03-25"), FechaActualizacion=DateTime.Parse("2020-03-26")},
      new Pregunta{TemaId=2,TipoId=1, IdiomaId=2,DificultadId=3,TiempodId=3,AsignaturaId=2,EstudioId=3, RespuestaId=4, PreguntaTextual="∫2xdx=x",FechaCreacion=DateTime.Parse("2020-03-25"), FechaActualizacion=DateTime.Parse("2020-03-26")},
      new Pregunta{TemaId=5,TipoId=1, IdiomaId=1,DificultadId=2,TiempodId=1,AsignaturaId=3,EstudioId=2, RespuestaId=1, PreguntaTextual="¿La inercia es una propiedad?",FechaCreacion=DateTime.Parse("2020-03-25"), FechaActualizacion =DateTime.Parse("2020-03-26")},
      new Pregunta{TemaId=1,TipoId=1, IdiomaId=2,DificultadId=1,TiempodId=2,AsignaturaId=2,EstudioId=1, RespuestaId=4, PreguntaTextual="25*25 = 225",FechaCreacion=DateTime.Parse("2020-03-25"), FechaActualizacion=DateTime.Parse("2020-03-26")},
      new Pregunta{TemaId=3,TipoId=1, IdiomaId=1,DificultadId=3,TiempodId=3,AsignaturaId=1,EstudioId=2, RespuestaId=1, PreguntaTextual="¿Homero escribio la Ilíada?",FechaCreacion=DateTime.Parse("2020-03-25"), FechaActualizacion=DateTime.Parse("2020-03-26")},
      new Pregunta{TemaId=1,TipoId=1, IdiomaId=2,DificultadId=3,TiempodId=1,AsignaturaId=2,EstudioId=3, RespuestaId=3, PreguntaTextual="∫2xdx=x^2",FechaCreacion=DateTime.Parse("2020-03-25"), FechaActualizacion=DateTime.Parse("2020-03-26")},

            };
     

            listaPregunta.ForEach(s => context.Pregunta.Add(s));
            context.SaveChanges();

           



        }

    }
}