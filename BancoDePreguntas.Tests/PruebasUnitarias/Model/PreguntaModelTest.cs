using BancoDePreguntas.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDePreguntas.Tests.PruebasUnitarias.Model
{
    [TestClass]
    public class PreguntaModelTest
    {

        [TestMethod]
        public void PreguntaCorrecto()
        {

            Pregunta pregunta = new Pregunta { TemaId = 1, TipoId = 2, IdiomaId = 3, DificultadId = 2, TiempodId = 2, AsignaturaId = 1, EstudioId = 1, RespuestaId = 1, PreguntaTextual = "¿2x2 =4?", FechaCreacion = DateTime.Parse("2006-04-11"), FechaActualizacion = DateTime.Parse("2006-04-11") };
            Assert.IsNotNull(pregunta);

        }

        [TestMethod]
        public void PreguntaPrimeroNulo()
        {

            Pregunta pregunta = new Pregunta { TemaId = null, TipoId = 2, IdiomaId = 3, DificultadId = 2, TiempodId = 2, AsignaturaId = 1, EstudioId = 1, RespuestaId = 1, PreguntaTextual = "¿2x2 =4?", FechaCreacion = DateTime.Parse("2006-04-11"), FechaActualizacion = DateTime.Parse("2006-04-11") };
            Assert.IsNull(pregunta.TemaId);

        }

        [TestMethod]
        public void PreguntaSegundoNulo()
        {

            Pregunta pregunta = new Pregunta { TemaId = 1, TipoId = null, IdiomaId = 3, DificultadId = 2, TiempodId = 2, AsignaturaId = 1, EstudioId = 1, RespuestaId = 1, PreguntaTextual = "¿2x2 =4?", FechaCreacion = DateTime.Parse("2006-04-11"), FechaActualizacion = DateTime.Parse("2006-04-11") };
            Assert.IsNull(pregunta.TipoId);

        }


        [TestMethod]
        public void PreguntaTextoVacio()
        {

            Pregunta pregunta = new Pregunta { TemaId = 1, TipoId = null, IdiomaId = 3, DificultadId = 2, TiempodId = 2, AsignaturaId = 1, EstudioId = 1, RespuestaId = 1, PreguntaTextual = "", FechaCreacion = DateTime.Parse("2006-04-11"), FechaActualizacion = DateTime.Parse("2006-04-11") };
            Assert.IsTrue(string.IsNullOrEmpty(pregunta.PreguntaTextual));

        }

        [TestMethod]
        public void Preguntafecha()
        {

            Pregunta pregunta = new Pregunta { TemaId = 1, TipoId = null, IdiomaId = 3, DificultadId = 2, TiempodId = 2, AsignaturaId = 1, EstudioId = 1, RespuestaId = 1, PreguntaTextual = "", FechaCreacion = DateTime.Parse("2006-04-11"), FechaActualizacion = DateTime.Parse("2006-04-11") };
            Assert.IsNotNull(pregunta.FechaCreacion);

        }
    }
}
