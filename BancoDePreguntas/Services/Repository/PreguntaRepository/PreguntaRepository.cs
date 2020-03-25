using BancoDePreguntas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancoDePreguntas.Services.Repository.PreguntaRepository
{
    public class PreguntaRepository : GenericRepository<Pregunta>, IPreguntaRepository
    {


        //public IQueryable<Pregunta> GetPreguntas(VMPreguntaSearch searchModel)
        //{
        //    var result = _context.Pregunta.AsQueryable();
        //    if (searchModel != null)
        //    {
        //        if (searchModel.EstudioId.HasValue)
        //            result = result.Where(x => x.Id == searchModel.Id);
        //        //if (!string.IsNullOrEmpty(searchModel.Name))
        //        //    result = result.Where(x => x.Name.Contains(searchModel.Name));
        //        //if (searchModel.PriceFrom.HasValue)
        //        //    result = result.Where(x => x.Price >= searchModel.PriceFrom);
        //        //if (searchModel.PriceTo.HasValue)
        //        //    result = result.Where(x => x.Price <= searchModel.PriceTo);

        //    }
        //    return result;
        //}
        public IQueryable<Pregunta> GetPreguntas(string searchString)
        {
            var query = from s in _context.Pregunta
                        select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                query = query.Where(s => s.PreguntaTextual.Contains(searchString));
                    
                                       
            }
            return query;
        }
    }
}