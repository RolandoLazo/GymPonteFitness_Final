using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymPonteFitness_v1.Models
{
    public class Sala
    {
        public int SalaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual List<Clase> Clases { get; set; }
    }
}
