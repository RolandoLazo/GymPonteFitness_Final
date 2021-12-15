using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymPonteFitness_v1.Models
{
    public class Clase
    {
        public int ClaseId { get; set; }
        //==============================================
        public virtual int SalaId { get; set; }//Relacion con sala
        public virtual Sala Sala { get; set; }//Navegacion 

        //============================================
        public virtual int EmpleadoId { get; set; }//Relacion con sala
        public virtual Empleado Empleado { get; set; }//Navegacion 

        //============================================
        public virtual int AcvidadId { get; set; }//Relacion con sala
        public virtual Actividad Actividad { get; set; }//Navegacion 

        //============================================
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public string Horario { get; set; }

        //===============================================
        //public virtual List<Cliente> Clientes { get; set; }

    }
}
