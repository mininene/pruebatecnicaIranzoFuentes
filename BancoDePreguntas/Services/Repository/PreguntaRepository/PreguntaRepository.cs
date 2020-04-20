using BancoDePreguntas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancoDePreguntas.Services.Repository.PreguntaRepository
{
    public class PreguntaRepository : GenericRepository<Pregunta>, IPreguntaRepository
    {

        public IQueryable<Pregunta> GetPreguntas(int? searchEstudio, int? searchAsign, int? searchTipo, int? searchIdioma)
        {
            var query = (from s in _context.Pregunta
                        select s).OrderBy(s=>s.FechaActualizacion);

            if (searchEstudio != null && searchAsign != null && searchTipo != null && searchIdioma != null)
            {
                query = query.Where(s => s.EstudioId == searchEstudio && s.AsignaturaId == searchAsign
                && s.TipoId == searchTipo && s.IdiomaId == searchIdioma)
                .OrderBy(s => s.EstudioId);

                return query;
            }


            if (searchEstudio == null && searchAsign != null && searchTipo != null && searchIdioma != null)
            {
                query = query.Where(s =>  s.AsignaturaId == searchAsign && s.TipoId == searchTipo && s.IdiomaId == searchIdioma)
                .OrderBy(s => s.EstudioId);

                return query;
            }


                       
            if (searchEstudio != null && searchAsign == null && searchTipo != null && searchIdioma != null)
            {
                query = query.Where(s => s.TipoId == searchTipo && s.IdiomaId == searchIdioma)
               .OrderBy(s => s.EstudioId);

                return query;
            }


            if (searchEstudio != null && searchAsign != null && searchTipo == null && searchIdioma != null)
            {
                query = query.Where(s => s.EstudioId == searchEstudio && s.AsignaturaId == searchAsign
                  && s.IdiomaId == searchIdioma)
                  .OrderBy(s => s.EstudioId);
            }


                                 
            if (searchEstudio != null && searchAsign != null && searchTipo != null && searchIdioma == null)
            {
                query = query.Where(s => s.EstudioId == searchEstudio && s.AsignaturaId == searchAsign
                 )
                  .OrderBy(s => s.EstudioId);

                return query;
            }


            if (searchEstudio == null && searchAsign == null && searchTipo == null && searchIdioma != null)
            {
                query = query.Where(s =>s.IdiomaId == searchIdioma)
                .OrderBy(s => s.EstudioId);

                return query;
            }


            if (searchEstudio == null && searchAsign == null && searchTipo != null && searchIdioma == null)
            {
                query = query.Where(s => s.TipoId == searchTipo)
                .OrderBy(s => s.EstudioId);

                return query;
            }


            if (searchEstudio == null && searchAsign == null && searchTipo != null && searchIdioma == null)
            {
                query = query.Where(s => s.TipoId == searchTipo)
                .OrderBy(s => s.EstudioId);

                return query;
            }

            if (searchEstudio == null && searchAsign != null && searchTipo == null && searchIdioma == null)
            {
                query = query.Where(s => s.AsignaturaId == searchAsign)
                .OrderBy(s => s.EstudioId);

                return query;
            }

            if (searchEstudio != null && searchAsign == null && searchTipo == null && searchIdioma == null)
            {
                query = query.Where(s => s.EstudioId == searchEstudio)
                .OrderBy(s => s.EstudioId);

                return query;
            }

            if (searchEstudio != null && searchAsign == null && searchTipo == null && searchIdioma != null)
            {
                query = query.Where(s => s.EstudioId == searchEstudio && s.IdiomaId == searchIdioma)
               .OrderBy(s => s.EstudioId);

                return query;
             
            }

            if (searchEstudio == null && searchAsign != null && searchTipo != null && searchIdioma == null)
            {
                 query = query.Where(s =>  s.AsignaturaId == searchAsign
                && s.TipoId == searchTipo)
                .OrderBy(s => s.EstudioId);

                return query;

            }

            if (searchEstudio == null && searchAsign != null && searchTipo == null && searchIdioma != null)
            {
                query = query.Where(s => s.AsignaturaId == searchAsign
                  && s.IdiomaId == searchIdioma)
                  .OrderBy(s => s.EstudioId);


                return query;

            }


            if (searchEstudio != null && searchAsign == null && searchTipo != null && searchIdioma == null)
            {
                query = query.Where(s => s.EstudioId == searchEstudio 
               && s.TipoId == searchTipo )
               .OrderBy(s => s.EstudioId);

                return query;

            }


            if (searchEstudio != null && searchAsign != null && searchTipo == null && searchIdioma == null)
            {
                query = query.Where(s => s.EstudioId==searchEstudio
               && s.AsignaturaId == searchAsign)
               .OrderBy(s => s.EstudioId);

                return query;

            }

            if (searchEstudio == null && searchAsign == null && searchTipo != null && searchIdioma != null)
            {
                query = query.Where(s => s.TipoId == searchTipo
               && s.IdiomaId == searchIdioma)
               .OrderBy(s => s.EstudioId);

                return query;

            }





            else { return query; }
        }






                                    
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
        //public IQueryable<Pregunta> GetString(string searchString)
        //{
        //    var query = from s in _context.Pregunta
        //                select s;
        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        query = query.Where(s => s.PreguntaTextual.Contains(searchString));
        //    }return query;
        //}




        //public IQueryable<Pregunta> Geto(int searchString)
        //{
        //    var query = from s in _context.Pregunta
        //                select s;

        //    query = query.Where(s => s.AsignaturaId == searchString);

        //    return query;
        //}
    }
}