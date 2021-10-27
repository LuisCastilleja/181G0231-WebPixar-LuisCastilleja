using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebPixar.Models;
using WebPixar.Repositories;
namespace WebPixar.Models.ViewModels
{
    public class PortadasViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Portada { get; set; }
        public string Codigo { get; set; }

        public PortadasViewModel(Pelicula pelicula)
        {
            Id = pelicula.Id;
            Nombre = pelicula.Nombre;
            Portada = string.Concat(pelicula.Id.ToString(),"_p.jpg");
            Codigo = Regex.Replace(pelicula.Nombre, "~[a-zA-Z0-9]", "");
        }
    }
}
