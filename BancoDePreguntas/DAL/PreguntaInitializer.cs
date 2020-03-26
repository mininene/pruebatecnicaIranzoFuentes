using BancoDePreguntas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancoDePreguntas.DAL
{
    public class PreguntaInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<PreguntaContext>
    {

        protected override void Seed(PreguntaContext context)
        {
          
            var listaEstudio = new List<Estudio>
            {
            new Estudio{Id=1,NombreEstudio= "Superior"},
            new Estudio{Id=2, NombreEstudio= "Avanzado"},

            };
            listaEstudio.ForEach(s => context.Estudio.Add(s));
            context.SaveChanges();

            var listaAsignatura = new List<Asignatura>
            {
            new Asignatura{Id=1,NombreAsignatura= "Literatura"},
            new Asignatura{Id=2, NombreAsignatura= "Matematica"},

            };
            listaAsignatura.ForEach(s => context.Asignatura.Add(s));
            context.SaveChanges();

            var listaTema = new List<Tema>
            {
            new Tema{Id=1,NombreTema= "Numeros Primos"},
            new Tema{Id=2, NombreTema= "Litografia"},

            };
            listaTema.ForEach(s => context.Tema.Add(s));
            context.SaveChanges();

            var listaTipoPregunta = new List<TipoPregunta>
            {
            new TipoPregunta{Id=1,TipoDePregunta= "Selección Sencilla"},
            new TipoPregunta{Id=2, TipoDePregunta= "Selección Multiple"},

            };
            listaTipoPregunta.ForEach(s => context.TipoPregunta.Add(s));
            context.SaveChanges();

            var listaIdioma = new List<Idioma>
            {
            new Idioma{Id=1,Lenguaje= "Español"},
            new Idioma{Id=2, Lenguaje= "Ingles"},
            new Idioma{Id=3, Lenguaje= "Frances"},

            };
            listaIdioma.ForEach(s => context.Idioma.Add(s));
            context.SaveChanges();

            var listaRespuestas = new List<Respuesta>
            {
            new Respuesta{Id=1,Respuestas= "Si"},
            new Respuesta{Id=2, Respuestas= "No"},
     

            };
            listaRespuestas.ForEach(s => context.Respuesta.Add(s));
            context.SaveChanges();

            var listaGradoDificultad = new List<GradoDificultad>
            {
            new GradoDificultad{Id=1,Nivel= "Bajo"},
            new GradoDificultad{Id=2, Nivel= "Medio"},
            new GradoDificultad{Id=3, Nivel= "Alto"},

            };
            listaGradoDificultad.ForEach(s => context.GradoDificultad.Add(s));
            context.SaveChanges();

            var listaTiempoRealizacion = new List<TiempoRealizacion>
            {
            new TiempoRealizacion{Id=1,Tiempo="20"},
            new TiempoRealizacion{Id=2, Tiempo= "12"},
            new TiempoRealizacion{Id=3, Tiempo= "15"},

            };
            listaTiempoRealizacion.ForEach(s => context.TiempoRealizacion.Add(s));
            context.SaveChanges();


            var listaPregunta = new List<Pregunta>
            {
               
      new Pregunta{TemaId=1,TipoId=2, IdiomaId=3,DificultadId=2,TiempodId=2,AsignaturaId=1,EstudioId=1, RespuestaId=1, PreguntaTextual="¿2x2 =4?",FechaCreacion=DateTime.Parse("2006-04-11"), FechaActualizacion =DateTime.Parse("2006-04-11")},
      new Pregunta{TemaId=2,TipoId=1, IdiomaId=2,DificultadId=1,TiempodId=3,AsignaturaId=1,EstudioId=2, RespuestaId=2, PreguntaTextual="¿Amar y querer son sinonimos?",FechaCreacion=DateTime.Parse("2006-04-11"), FechaActualizacion=DateTime.Parse("2006-04-11")},
      new Pregunta{TemaId=1,TipoId=2, IdiomaId=1,DificultadId=1,TiempodId=1,AsignaturaId=2,EstudioId=1, RespuestaId=1, PreguntaTextual="¿4-2 = 1?",FechaCreacion=DateTime.Parse("2006-04-11"), FechaActualizacion=DateTime.Parse("2006-04-11")},
      new Pregunta{TemaId=1,TipoId=2, IdiomaId=3,DificultadId=2,TiempodId=2,AsignaturaId=1,EstudioId=1, RespuestaId=1, PreguntaTextual="¿2x2 =4?",FechaCreacion=DateTime.Parse("2006-04-11"), FechaActualizacion =DateTime.Parse("2006-04-11")},
      new Pregunta{TemaId=2,TipoId=1, IdiomaId=2,DificultadId=1,TiempodId=3,AsignaturaId=1,EstudioId=2, RespuestaId=2, PreguntaTextual="¿probar?",FechaCreacion=DateTime.Parse("2006-04-11"), FechaActualizacion=DateTime.Parse("2006-04-11")},
      new Pregunta{TemaId=1,TipoId=2, IdiomaId=1,DificultadId=1,TiempodId=1,AsignaturaId=2,EstudioId=1, RespuestaId=1, PreguntaTextual="¿comida?",FechaCreacion=DateTime.Parse("2006-04-11"), FechaActualizacion=DateTime.Parse("2006-04-11")},
      new Pregunta{TemaId=2,TipoId=2, IdiomaId=3,DificultadId=2,TiempodId=2,AsignaturaId=1,EstudioId=1, RespuestaId=1, PreguntaTextual="¿6x9 =4?",FechaCreacion=DateTime.Parse("2006-04-11"), FechaActualizacion =DateTime.Parse("2006-04-11")},
      new Pregunta{TemaId=2,TipoId=2, IdiomaId=2,DificultadId=1,TiempodId=3,AsignaturaId=1,EstudioId=2, RespuestaId=2, PreguntaTextual="¿Amar y querer son sinonimos?",FechaCreacion=DateTime.Parse("2006-04-11"), FechaActualizacion=DateTime.Parse("2006-04-11")},
      new Pregunta{TemaId=1,TipoId=2, IdiomaId=1,DificultadId=1,TiempodId=1,AsignaturaId=2,EstudioId=1, RespuestaId=1, PreguntaTextual="¿4-2 = 1?",FechaCreacion=DateTime.Parse("2006-04-11"), FechaActualizacion=DateTime.Parse("2006-04-11")},
      new Pregunta{TemaId=2,TipoId=1, IdiomaId=3,DificultadId=2,TiempodId=1,AsignaturaId=2,EstudioId=1, RespuestaId=1, PreguntaTextual="¿6x2=12?",FechaCreacion=DateTime.Parse("2006-04-11"), FechaActualizacion=DateTime.Parse("2006-04-11")},

            };
     

            listaPregunta.ForEach(s => context.Pregunta.Add(s));
            context.SaveChanges();

           



        }

    }
}