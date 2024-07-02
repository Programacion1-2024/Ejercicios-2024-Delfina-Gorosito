using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Prestamo
    {
        public string IdPrestamo { get; set;}
        public string MontoTotalo { get; set;}
        public DateTime FechaPrestamo { get; set;}
        public DateTime FechaDevolucion { get;}
        public bool Estado {  get; set;}
    }
}
