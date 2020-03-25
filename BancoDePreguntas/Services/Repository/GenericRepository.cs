using BancoDePreguntas.DAL;
using BancoDePreguntas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BancoDePreguntas.Services.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public PreguntaContext _context = null;
        public DbSet<T> table = null;

        public GenericRepository()
        {
            this._context = new PreguntaContext();
            table = _context.Set<T>();
        }

        public GenericRepository(PreguntaContext context)
        {
            this._context = context;
            table = _context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }

        public virtual async Task<T> GetById(object id)
        {
            return await table.FindAsync(id);
        }

        public virtual void Insert(T obj)
        {
            table.Add(obj);
        }

        public virtual void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public virtual async Task Delete(object id)
        {
            T existing = await table.FindAsync(id);
            table.Remove(existing);
        }

        public virtual async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public virtual async Task<IEnumerable<Pregunta>> ListaPreguntas()
        {
            return await _context.Pregunta.ToListAsync();
        }

        public virtual async Task<IEnumerable<Estudio>> ListaEstudio()
        {
            return await _context.Estudio.ToListAsync();
        }

        public virtual async Task<IEnumerable<Asignatura>> ListaAsignatura()
        {
            return await _context.Asignatura.ToListAsync();
        }

        public virtual async Task<IEnumerable<Tema>> ListaTema()
        {
            return await _context.Tema.ToListAsync();
        }

        public virtual async Task<IEnumerable<Idioma>> ListaIdioma()
        {
            return await _context.Idioma.ToListAsync();
        }

        public virtual async Task<IEnumerable<TipoPregunta>> ListaTipoPregunta()
        {
            return await _context.TipoPregunta.ToListAsync();
        }

        public virtual async Task<IEnumerable<TiempoRealizacion>> ListaTiempo()
        {
            return await _context.TiempoRealizacion.ToListAsync();
        }

        public virtual async Task<IEnumerable<GradoDificultad>> ListaDificultad()
        {
            return await _context.GradoDificultad.ToListAsync();
        }

        public virtual async Task<IEnumerable<Respuesta>> ListaRespuesta()
        {
            return await _context.Respuesta.ToListAsync();
        }

       
    }
}