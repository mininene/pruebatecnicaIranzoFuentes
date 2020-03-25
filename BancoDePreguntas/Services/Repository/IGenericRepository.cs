using BancoDePreguntas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDePreguntas.Services.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        Task Delete(object id);
        Task Save();

        Task<IEnumerable<Pregunta>> ListaPreguntas();
        Task<IEnumerable<Estudio>> ListaEstudio();
        Task<IEnumerable<Asignatura>> ListaAsignatura();
        Task<IEnumerable<Tema>> ListaTema();
        Task<IEnumerable<Idioma>> ListaIdioma();
        Task<IEnumerable<TipoPregunta>> ListaTipoPregunta();
        Task<IEnumerable<TiempoRealizacion>> ListaTiempo();
        Task<IEnumerable<GradoDificultad>> ListaDificultad();
        Task<IEnumerable<Respuesta>> ListaRespuesta();
       
    }
}
