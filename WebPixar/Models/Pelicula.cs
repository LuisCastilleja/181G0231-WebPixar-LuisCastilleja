using System;
using System.Collections.Generic;

#nullable disable

namespace WebPixar.Models
{
    public partial class Pelicula
    {
        public Pelicula()
        {
            Apariciones = new HashSet<Aparicion>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreOriginal { get; set; }
        public string Descripción { get; set; }
        public DateTime? FechaEstreno { get; set; }

        public virtual ICollection<Aparicion> Apariciones { get; set; }
    }
}
