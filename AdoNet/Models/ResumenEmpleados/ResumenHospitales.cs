using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Models.ResumenEmpleados
{
    public class ResumenHospitales
    {
        public List<EmpleadoHospital> Empleados { get; set; }
        public int SumaSalarial { get; set; }
        public int MediaSalarial { get; set; }
        public int Personas { get; set; }

    public ResumenHospitales()
    {
        this.Empleados = new List<EmpleadoHospital>();
    }
}
}
