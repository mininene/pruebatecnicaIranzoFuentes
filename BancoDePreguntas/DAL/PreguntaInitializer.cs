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
 //new Pregunta{Tema="las Plantas",Tipo="variada",Idioma="Ingles", GradoDificultad = "2", TiempoRealización="20",CodAsignaturaId=1,CodEstudioId=1},
 //            };

      //new Pregunta{CodTemaId=1,CodTipoId=2, CodIdiomaId=3,CodDificultadId=2,CodTiempodId=2,CodAsignaturaId=1,CodEstudioId=1},
      //      };
      new Pregunta{},
            };

            listaPregunta.ForEach(s => context.Pregunta.Add(s));
            context.SaveChanges();

           



        }

    }
}