using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebPixar.Models;

namespace WebPixar.Repositories
{
    public class PeliculasRepository
    {
        PixarContext context;
        public PeliculasRepository(PixarContext context)
        {
            this.context = context;
        }
        public IEnumerable<Pelicula> GetPeliculas()
        {
            return context.Peliculas;
        }
        public Pelicula GetPeliculaById(int id)
        {

            return context.Peliculas.Where(x => x.Id == id)
                .Include(x=>x.Apariciones)
                .ThenInclude((Aparicion y) 
                => y.IdPersonajeNavigation)
                .FirstOrDefault();
        }
    }
}
