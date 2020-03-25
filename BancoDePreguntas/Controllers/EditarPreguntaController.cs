using System;
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

namespace BancoDePreguntas.Controllers
{
    public class EditarPreguntaController : Controller
    {
        private PreguntaContext db = new PreguntaContext();

        // GET: EditarPregunta2
        public async Task<ActionResult> Index()
        {
            var pregunta = db.Pregunta.Include(p => p.Asignatura).Include(p => p.Estudio).Include(p => p.GradoDificultad).Include(p => p.Idioma).Include(p => p.Respuesta).Include(p => p.Tema).Include(p => p.TiempoRealizacion).Include(p => p.TipoPregunta);
            return View(await pregunta.ToListAsync());
        }

        // GET: EditarPregunta2/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pregunta pregunta = await db.Pregunta.FindAsync(id);
            if (pregunta == null)
            {
                return HttpNotFound();
            }
            return View(pregunta);
        }

        // GET: EditarPregunta2/Create
        public ActionResult Create()
        {
            ViewBag.AsignaturaId = new SelectList(db.Asignatura, "Id", "NombreAsignatura");
            ViewBag.EstudioId = new SelectList(db.Estudio, "Id", "NombreEstudio");
            ViewBag.DificultadId = new SelectList(db.GradoDificultad, "Id", "Nivel");
            ViewBag.IdiomaId = new SelectList(db.Idioma, "Id", "Lenguaje");
            ViewBag.RespuestaId = new SelectList(db.Respuesta, "Id", "Respuestas");
            ViewBag.TemaId = new SelectList(db.Tema, "Id", "NombreTema");
            ViewBag.TiempodId = new SelectList(db.TiempoRealizacion, "Id", "Tiempo");
            ViewBag.TipoId = new SelectList(db.TipoPregunta, "Id", "TipoDePregunta");
            return View();
        }

        // POST: EditarPregunta2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,EstudioId,AsignaturaId,TemaId,TipoId,IdiomaId,PreguntaTextual,RespuestaId,DificultadId,TiempodId,FechaCreacion,FechaActualizacion")] Pregunta pregunta)
        {
            if (ModelState.IsValid)
            {
                db.Pregunta.Add(pregunta);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.AsignaturaId = new SelectList(db.Asignatura, "Id", "NombreAsignatura", pregunta.AsignaturaId);
            ViewBag.EstudioId = new SelectList(db.Estudio, "Id", "NombreEstudio", pregunta.EstudioId);
            ViewBag.DificultadId = new SelectList(db.GradoDificultad, "Id", "Nivel", pregunta.DificultadId);
            ViewBag.IdiomaId = new SelectList(db.Idioma, "Id", "Lenguaje", pregunta.IdiomaId);
            ViewBag.RespuestaId = new SelectList(db.Respuesta, "Id", "Respuestas", pregunta.RespuestaId);
            ViewBag.TemaId = new SelectList(db.Tema, "Id", "NombreTema", pregunta.TemaId);
            ViewBag.TiempodId = new SelectList(db.TiempoRealizacion, "Id", "Tiempo", pregunta.TiempodId);
            ViewBag.TipoId = new SelectList(db.TipoPregunta, "Id", "TipoDePregunta", pregunta.TipoId);
            return View(pregunta);
        }

        // GET: EditarPregunta2/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pregunta pregunta = await db.Pregunta.FindAsync(id);
            if (pregunta == null)
            {
                return HttpNotFound();
            }
            ViewBag.AsignaturaId = new SelectList(db.Asignatura, "Id", "NombreAsignatura", pregunta.AsignaturaId);
            ViewBag.EstudioId = new SelectList(db.Estudio, "Id", "NombreEstudio", pregunta.EstudioId);
            ViewBag.DificultadId = new SelectList(db.GradoDificultad, "Id", "Nivel", pregunta.DificultadId);
            ViewBag.IdiomaId = new SelectList(db.Idioma, "Id", "Lenguaje", pregunta.IdiomaId);
            ViewBag.RespuestaId = new SelectList(db.Respuesta, "Id", "Respuestas", pregunta.RespuestaId);
            ViewBag.TemaId = new SelectList(db.Tema, "Id", "NombreTema", pregunta.TemaId);
            ViewBag.TiempodId = new SelectList(db.TiempoRealizacion, "Id", "Tiempo", pregunta.TiempodId);
            ViewBag.TipoId = new SelectList(db.TipoPregunta, "Id", "TipoDePregunta", pregunta.TipoId);
            return View(pregunta);
        }

        // POST: EditarPregunta2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,EstudioId,AsignaturaId,TemaId,TipoId,IdiomaId,PreguntaTextual,RespuestaId,DificultadId,TiempodId,FechaCreacion,FechaActualizacion")] Pregunta pregunta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pregunta).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.AsignaturaId = new SelectList(db.Asignatura, "Id", "NombreAsignatura", pregunta.AsignaturaId);
            ViewBag.EstudioId = new SelectList(db.Estudio, "Id", "NombreEstudio", pregunta.EstudioId);
            ViewBag.DificultadId = new SelectList(db.GradoDificultad, "Id", "Nivel", pregunta.DificultadId);
            ViewBag.IdiomaId = new SelectList(db.Idioma, "Id", "Lenguaje", pregunta.IdiomaId);
            ViewBag.RespuestaId = new SelectList(db.Respuesta, "Id", "Respuestas", pregunta.RespuestaId);
            ViewBag.TemaId = new SelectList(db.Tema, "Id", "NombreTema", pregunta.TemaId);
            ViewBag.TiempodId = new SelectList(db.TiempoRealizacion, "Id", "Tiempo", pregunta.TiempodId);
            ViewBag.TipoId = new SelectList(db.TipoPregunta, "Id", "TipoDePregunta", pregunta.TipoId);
            return View(pregunta);
        }

        // GET: EditarPregunta2/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pregunta pregunta = await db.Pregunta.FindAsync(id);
            if (pregunta == null)
            {
                return HttpNotFound();
            }
            return View(pregunta);
        }

        // POST: EditarPregunta2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Pregunta pregunta = await db.Pregunta.FindAsync(id);
            db.Pregunta.Remove(pregunta);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
