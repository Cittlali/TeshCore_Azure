using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teshCore.Models
{
    public class Alumnos
    {
        public int Id { get; set; }
        public string nombreAlumno{ get; set; }
        public string apellidoAlumno { get; set; }
        public int calificacionAlumno { get; set; }
        public DateTime fechaNacimientoAlumno { get; set; } 

    }
}
