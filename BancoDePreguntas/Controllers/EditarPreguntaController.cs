﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BancoDePreguntas.DAL;
using BancoDePreguntas.Models;
using BancoDePreguntas.Services.Repository.PreguntaRepository;
using BancoDePreguntas.InfraestructuraTransversal.ControllerException;

namespace BancoDePreguntas.Controllers
{
    public class EditarPreguntaController : BaseController
    {
        private IPreguntaRepository repositorio = null;
        public EditarPreguntaController()
        {
            this.repositorio = new PreguntaRepository();
        }

        public EditarPreguntaController(IPreguntaRepository repositorio)
        {
            this.repositorio = repositorio;
        }

        // GET: Crear2
        public async Task<ActionResult> Index()
        {
            try
            {
                return View(await repositorio.GetAll());
            }
            catch (Exception ex)
            { throw new ControllerException("Error en task ActionResult Index", ex); }
        }

        // GET: Crear2/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Pregunta pregunta = await repositorio.GetById(id);
                if (pregunta == null)
                {
                    return HttpNotFound();
                }
                return View(pregunta);
            }
            catch (Exception ex)
            { throw new ControllerException("Error en task ActionResult Details", ex); }
        }

        // GET: Crear2/Create
        public async Task<ActionResult> Create()
        {
            ViewBag.AsignaturaId = new SelectList(await repositorio.ListaAsignatura(), "Id", "NombreAsignatura");
            ViewBag.EstudioId = new SelectList(await repositorio.ListaEstudio(), "Id", "NombreEstudio");
            ViewBag.DificultadId = new SelectList(await repositorio.ListaDificultad(), "Id", "Nivel");
            ViewBag.IdiomaId = new SelectList(await repositorio.ListaIdioma(), "Id", "Lenguaje");
            ViewBag.RespuestaId = new SelectList(await repositorio.ListaRespuesta(), "Id", "Respuestas");
            ViewBag.TemaId = new SelectList(await repositorio.ListaTema(), "Id", "NombreTema");
            ViewBag.TiempodId = new SelectList(await repositorio.ListaTiempo(), "Id", "Tiempo");
            ViewBag.TipoId = new SelectList(await repositorio.ListaTipoPregunta(), "Id", "TipoDePregunta");
            return View();
        }

        // POST: Crear2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,EstudioId,AsignaturaId,TemaId,TipoId,IdiomaId,PreguntaTextual,RespuestaId,DificultadId,TiempodId,FechaCreacion,FechaActualizacion")] Pregunta pregunta)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repositorio.Insert(pregunta);
                    await repositorio.Save();
                    return RedirectToAction("Index");
                }

                ViewBag.AsignaturaId = new SelectList(await repositorio.ListaAsignatura(), "Id", "NombreAsignatura", pregunta.AsignaturaId);
                ViewBag.EstudioId = new SelectList(await repositorio.ListaEstudio(), "Id", "NombreEstudio", pregunta.EstudioId);
                ViewBag.DificultadId = new SelectList(await repositorio.ListaDificultad(), "Id", "Nivel", pregunta.DificultadId);
                ViewBag.IdiomaId = new SelectList(await repositorio.ListaIdioma(), "Id", "Lenguaje", pregunta.IdiomaId);
                ViewBag.RespuestaId = new SelectList(await repositorio.ListaRespuesta(), "Id", "Respuestas", pregunta.RespuestaId);
                ViewBag.TemaId = new SelectList(await repositorio.ListaTema(), "Id", "NombreTema", pregunta.TemaId);
                ViewBag.TiempodId = new SelectList(await repositorio.ListaTiempo(), "Id", "Tiempo", pregunta.TiempodId);
                ViewBag.TipoId = new SelectList(await repositorio.ListaTipoPregunta(), "Id", "TipoDePregunta", pregunta.TipoId);
                return View(pregunta);
            }
            catch (Exception ex)
            { throw new ControllerException("Error en task ActionResult Create", ex); }
        }

        // GET: Crear2/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            try { 
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pregunta pregunta = await repositorio.GetById(id);
            if (pregunta == null)
            {
                return HttpNotFound();
            }
            ViewBag.AsignaturaId = new SelectList(await repositorio.ListaAsignatura(), "Id", "NombreAsignatura", pregunta.AsignaturaId);
            ViewBag.EstudioId = new SelectList(await repositorio.ListaEstudio(), "Id", "NombreEstudio", pregunta.EstudioId);
            ViewBag.DificultadId = new SelectList(await repositorio.ListaDificultad(), "Id", "Nivel", pregunta.DificultadId);
            ViewBag.IdiomaId = new SelectList(await repositorio.ListaIdioma(), "Id", "Lenguaje", pregunta.IdiomaId);
            ViewBag.RespuestaId = new SelectList(await repositorio.ListaRespuesta(), "Id", "Respuestas", pregunta.RespuestaId);
            ViewBag.TemaId = new SelectList(await repositorio.ListaTema(), "Id", "NombreTema", pregunta.TemaId);
            ViewBag.TiempodId = new SelectList(await repositorio.ListaTiempo(), "Id", "Tiempo", pregunta.TiempodId);
            ViewBag.TipoId = new SelectList(await repositorio.ListaTipoPregunta(), "Id", "TipoDePregunta", pregunta.TipoId);

            return View(pregunta);
            }
            catch (Exception ex)
            { throw new ControllerException("Error en task ActionResult GetbyId", ex); }
        }

        // POST: Crear2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,EstudioId,AsignaturaId,TemaId,TipoId,IdiomaId,PreguntaTextual,RespuestaId,DificultadId,TiempodId,FechaCreacion,FechaActualizacion")] Pregunta pregunta)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repositorio.Update(pregunta);
                    await repositorio.Save();
                    return RedirectToAction("Index");
                }
                ViewBag.AsignaturaId = new SelectList(await repositorio.ListaAsignatura(), "Id", "NombreAsignatura", pregunta.AsignaturaId);
                ViewBag.EstudioId = new SelectList(await repositorio.ListaEstudio(), "Id", "NombreEstudio", pregunta.EstudioId);
                ViewBag.DificultadId = new SelectList(await repositorio.ListaDificultad(), "Id", "Nivel", pregunta.DificultadId);
                ViewBag.IdiomaId = new SelectList(await repositorio.ListaIdioma(), "Id", "Lenguaje", pregunta.IdiomaId);
                ViewBag.RespuestaId = new SelectList(await repositorio.ListaRespuesta(), "Id", "Respuestas", pregunta.RespuestaId);
                ViewBag.TemaId = new SelectList(await repositorio.ListaTema(), "Id", "NombreTema", pregunta.TemaId);
                ViewBag.TiempodId = new SelectList(await repositorio.ListaTiempo(), "Id", "Tiempo", pregunta.TiempodId);
                ViewBag.TipoId = new SelectList(await repositorio.ListaTipoPregunta(), "Id", "TipoDePregunta", pregunta.TipoId);

                return View(pregunta);
            }
            catch (Exception ex)
            { throw new ControllerException("Error en task ActionResult Edit", ex); }
        }

        // GET: Crear2/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Pregunta pregunta = await repositorio.GetById(id);
                if (pregunta == null)
                {
                    return HttpNotFound();
                }
                return View(pregunta);
            }
            catch (Exception ex)
            { throw new ControllerException("Error en task ActionResult Delete", ex); }
        }

        // POST: Crear2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await repositorio.Delete(id);
                await repositorio.Save();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            { throw new ControllerException("Error en task ActionResult Delete", ex); }
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
