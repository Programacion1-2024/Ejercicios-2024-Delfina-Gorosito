using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Empleado
    {
        public string IdEmpleado { get; set; }
        public double Sueldo { get; set; }
        public string Puesto { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
