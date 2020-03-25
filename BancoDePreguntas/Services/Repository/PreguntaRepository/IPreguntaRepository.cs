using BancoDePreguntas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BancoDePreguntas.Services.Repository.PreguntaRepository
{
    public interface IPreguntaRepository : IGenericRepository<Pregunta>
    {
        //IQueryable<Pregunta> GetPreguntas(VMPreguntaSearch searchModel);
        IQueryable<Pregunta> GetPreguntas(string searchString);
    }
}
