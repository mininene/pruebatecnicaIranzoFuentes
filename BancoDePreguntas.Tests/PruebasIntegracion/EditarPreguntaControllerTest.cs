﻿using BancoDePreguntas.Controllers;
using BancoDePreguntas.Models;
using BancoDePreguntas.Services.Repository.PreguntaRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BancoDePreguntas.Tests.PruebasIntegracion
{
    [TestClass]
    public class EditarPreguntaControllerTest
    {
        EditarPreguntaController listacontroller = new EditarPreguntaController();
        private IPreguntaRepository repositorio = new PreguntaRepository();
        private Pregunta pregunta = new Pregunta { TemaId = 1, TipoId = 2, IdiomaId = 3, DificultadId = 2, TiempodId = 2, AsignaturaId = 1, EstudioId = 1, RespuestaId = 1, PreguntaTextual = "¿2x2 =4?", FechaCreacion = DateTime.Parse("2006-04-11"), FechaActualizacion = DateTime.Parse("2006-04-11") };

        [TestMethod]
        public async Task Index()

        {
            var resultado = await listacontroller.Index();
            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado is ActionResult);

        }

        //[TestMethod]
        //public async Task Edit()

        //{
        //    repositorio.Update(pregunta);
        //    await repositorio.Save();
        //    var guardado = await repositorio.GetById(pregunta.Id);
        //    //Assert.IsTrue(guardado is ActionResult);
        //}
    }
}
