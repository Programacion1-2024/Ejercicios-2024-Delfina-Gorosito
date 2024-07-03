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
        public int IdPrestamo { get; set;}
        public DateTime FechaPrestamo { get; set;}
        public DateTime FechaDevolucion { get;}
        public DateTime FechaLimite{ get; }
        public Cliente Cliente { get; set;}

    }
}
