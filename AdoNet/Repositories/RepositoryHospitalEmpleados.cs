using AdoNet.Models.ResumenEmpleados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Repositories
{
    public class RepositoryHospitalEmpleados
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryHospitalEmpleados() 
        {
            string connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<string> GetListaHospitales()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_HOSPITALES";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<string> hospitales = new List<string>();
            while (this.reader.Read())
            {
                hospitales.Add(this.reader["NOMBRE"].ToString());
            }
            this.reader.Close();
            this.cn.Close();

            return hospitales;
        }

        public ResumenHospitales GetResumenHospital(string nombre)
        {
            SqlParameter parNombre = new SqlParameter("@NOMBRE", nombre);
            this.com.Parameters.Add(parNombre);

            SqlParameter pamSuma = new SqlParameter();
            pamSuma.Value = 0;
            pamSuma.ParameterName = "@SUMA";
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);

            SqlParameter pamMedia = new SqlParameter();
            pamMedia.Value = 0;
            pamMedia.ParameterName = "@MEDIA";
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);

            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.Value = 0;
            pamPersonas.ParameterName = "@PERSONAS";
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_HOSPITALES_EMPLEADOS";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            ResumenHospitales resumen = new ResumenHospitales();

            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string salario = this.reader["SALARIO"].ToString();

                EmpleadoHospital emp = new EmpleadoHospital();
                emp.Apellido = apellido;
                emp.Salario = int.Parse(salario);

                resumen.Empleados.Add(emp);
            }

            this.reader.Close();
            //dibujamos los params
            
            int suma = int.Parse(pamSuma.Value.ToString());
            int media = int.Parse(pamMedia.Value.ToString());
            int personas = int.Parse(pamPersonas.Value.ToString());
            resumen.SumaSalarial = suma;
            resumen.MediaSalarial = media;
            resumen.Personas = personas;
            
            this.com.Parameters.Clear();
            this.cn.Close();

            return resumen;
        }
    }
}
