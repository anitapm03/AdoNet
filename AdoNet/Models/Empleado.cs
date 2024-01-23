using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Oficio { get; set; }
        public int Dir { get; set; }
        public string Fecha { get; set; }
        public int Salario { get; set; }
        public int Comision { get; set; }
        public int Deptno { get; set; }

    }
}
