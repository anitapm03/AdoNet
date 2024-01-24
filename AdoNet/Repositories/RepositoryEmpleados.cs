using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * mostrar oficios y suma salarial getemp
 * mostrar empleados con un oficio getempof
 * incrementar salario de esos empleados incrementarsalario
 * actualizar
 * 
 */
namespace AdoNet.Repositories
{
    public class RepositoryEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryEmpleados()
        {
            string connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<Empleado> GetEmpleados()
        {
            string sql = "SELECT * FROM EMP";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<Empleado> empleados = new List<Empleado>();

            while (this.reader.Read())
            {
                int id = int.Parse(this.reader["EMP_NO"].ToString());
                string apellido = this.reader["APELLIDO"].ToString();
                string oficio = this.reader["OFICIO"].ToString();
                int dir = int.Parse(this.reader["DIR"].ToString());
                string fecha = this.reader["FECHA_ALT"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                int comision = int.Parse(this.reader["COMISION"].ToString());
                int deptno = int.Parse(this.reader["DEPT_NO"].ToString());

                Empleado emp = new Empleado();
                emp.Id = id;
                emp.Apellido = apellido;
                emp.Oficio = oficio;
                emp.Dir = dir;
                emp.Fecha = fecha;
                emp.Salario = salario;
                emp.Comision = comision;
                emp.Deptno = deptno;
                
                empleados.Add(emp);
            }

            this.reader.Close();
            this.cn.Close();

            return empleados;
        }

        public List<string> GetOficios()
        {
            string sql = "SELECT OFICIO FROM EMP GROUP BY OFICIO";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<string> oficios = new List<string>();

            while (this.reader.Read())
            {
                string oficio = this.reader["OFICIO"].ToString();

                oficios.Add(oficio);
            }

            this.reader.Close();
            this.cn.Close();

            return oficios;
        }

        public List<Empleado> GetEmpOficios(string oficio)
        {
            string sql = "SELECT * FROM EMP WHERE OFICIO = @of";
            SqlParameter ofparam = new SqlParameter("@of", oficio);
            this.com.Parameters.Add(ofparam);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<Empleado> empleados = new List<Empleado>();
            while (this.reader.Read())
            {
                int id = int.Parse(this.reader["EMP_NO"].ToString());
                string apellido = this.reader["APELLIDO"].ToString();
                string of = this.reader["OFICIO"].ToString();
                int dir = int.Parse(this.reader["DIR"].ToString());
                string fecha = this.reader["FECHA_ALT"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                int comision = int.Parse(this.reader["COMISION"].ToString());
                int deptno = int.Parse(this.reader["DEPT_NO"].ToString());

                Empleado emp = new Empleado();
                emp.Id = id;
                emp.Apellido = apellido;
                emp.Oficio = of;
                emp.Dir = dir;
                emp.Fecha = fecha;
                emp.Salario = salario;
                emp.Comision = comision;
                emp.Deptno = deptno;

                empleados.Add(emp);
            }

            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();

            return empleados;
        }

        public int AumentarSalario(int aumento, string oficio)
        {
            string sql = "UPDATE EMP SET SALARIO = SALARIO + @incremento " +
                "WHERE OFICIO = @of";
            SqlParameter incparam = new SqlParameter("@incremento", aumento);
            this.com.Parameters.Add(incparam);
            SqlParameter ofparam = new SqlParameter("@of", oficio);
            this.com.Parameters.Add(ofparam);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();

            int actualizados = this.com.ExecuteNonQuery();

            this.com.Parameters.Clear();
            this.cn.Close();

            return actualizados;

        }


        public DatosEmpleadosOficio GetDatosEmpleadosOficio(string oficio)
        {
            string sql = "SELECT SUM(SALARIO) AS SUMASALARIAL, " +
                "AVG(SALARIO) AS MEDIASALARIAL, " +
                "MIN(SALARIO) AS MINIMOSALARIO, OFICIO " +
                "FROM EMP GROUP BY OFICIO HAVING OFICIO = @oficio";
            SqlParameter ofparam = new SqlParameter("@oficio", oficio);
            this.com.Parameters.Add(ofparam);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();

            this.reader = this.com.ExecuteReader();

            int sumasalarial = int.Parse(this.reader["SUMASALARIAL"].ToString());
            int mediasalarial = int.Parse(this.reader["MEDIASALARIAL"].ToString());
            int minimosalario = int.Parse(this.reader["MINIMOSALARIO"].ToString());

            DatosEmpleadosOficio datos = new DatosEmpleadosOficio();
            datos.SumaSalarial = sumasalarial;
            datos.MediaSalarial = mediasalarial;
            datos.MinimoSalario = minimosalario;

            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();

            return datos;
        }

    }
}
