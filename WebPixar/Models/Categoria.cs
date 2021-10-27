using System;
using System.Collections.Generic;

#nullable disable

namespace WebPixar.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Cortometrajes = new HashSet<Cortometraje>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Cortometraje> Cortometrajes { get; set; }
    }
}
