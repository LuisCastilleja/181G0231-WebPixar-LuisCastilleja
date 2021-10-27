using System;
using System.Collections.Generic;

#nullable disable

namespace WebPixar.Models
{
    public partial class Personaje
    {
        public Personaje()
        {
            Apariciones = new HashSet<Aparicion>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Aparicion> Apariciones { get; set; }
    }
}
