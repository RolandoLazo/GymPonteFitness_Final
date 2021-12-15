using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymPonteFitness_v1.Models
{
    public class ClienteClases
    {
        public int ClienteClasesId { get; set; }
        public virtual int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual int ClaseId { get; set; }
        public virtual Clase Clase { get; set; }
    }
}
