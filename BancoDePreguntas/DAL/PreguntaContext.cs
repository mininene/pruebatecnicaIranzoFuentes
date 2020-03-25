using BancoDePreguntas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BancoDePreguntas.DAL
{
    public class PreguntaContext:DbContext
    {
        public PreguntaContext() : base("PreguntaContext")
        { }

        public DbSet<Pregunta> Pregunta { get; set; }
        public DbSet<Estudio> Estudio { get; set; }
        public DbSet<Asignatura> Asignatura { get; set; }
        public DbSet<Tema> Tema { get; set; }
        public DbSet<TipoPregunta> TipoPregunta { get; set; }
        public DbSet<Idioma> Idioma { get; set; }
        public DbSet<Respuesta> Respuesta { get; set; }
        public DbSet<GradoDificultad> GradoDificultad { get; set; }
        public DbSet<TiempoRealizacion> TiempoRealizacion { get; set; }
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
          
        }

        
    }
}