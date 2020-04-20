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

        IQueryable<Pregunta> GetPreguntas(int? searchEstudio, int? searchAsign, int? searchTipo, int? searchIdioma);
        ////IQueryable<Pregunta> GetPreguntas(VMPreguntaSearch searchModel);
        //IQueryable<Pregunta> GetString(string searchString);
        //IQueryable<Pregunta> Geto(int searchString);
    }
}
