using AdoNet.Helpers;
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
    public class RepositoryParametrosSalida
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryParametrosSalida() 
        {
            string connectionString = HelperConfiguration.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<string> GetDepartamentos()
        {

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_DEPARTAMENTOS";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<string> departamentos = new List<string>();
            while (this.reader.Read())
            {
                departamentos.Add(this.reader["DNOMBRE"].ToString());
            }
            this.reader.Close();
            this.cn.Close();

            return departamentos;
        }

        public ResumenEmpleados GetResumenEmpleados(string nombreDepartamento)
        {
            
            SqlParameter parNombre = new SqlParameter("@NOMBRE", nombreDepartamento);
            this.com.Parameters.Add(parNombre);

            //un paramretro de salida no lleva valor, se recupera
            SqlParameter pamSuma = new SqlParameter();
            pamSuma.Value = 0;
            pamSuma.ParameterName = "@SUMA";
            //debemos indicar la direccion del parametro
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
            this.com.CommandText = "SP_EMPLEADOS_DEPARTAMENTO";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            ResumenEmpleados resumen = new ResumenEmpleados();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                resumen.Apellidos.Add(apellido);

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
