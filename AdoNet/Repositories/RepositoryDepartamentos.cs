using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Repositories
{
    public class RepositoryDepartamentos
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryDepartamentos()
        {
            string connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        //quiero realizar un crud sobre deptos
        // me gustaria dibujar los deptos
        //buscar los departamentos
        //insert, delete, update
        //metodo para recuperar todos los departamentos
        public List<Departamento> GetDepartamentos()
        {
            string sql = "SELECT * FROM DEPT";

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            //debemos crear la coleccion para devolver los departamentos
            List<Departamento> departamentos = new List<Departamento>();
            while (this.reader.Read())
            {
                int id = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombre = this.reader["DNOMBRE"].ToString();
                string loc = this.reader["LOC"].ToString();

                Departamento dept = new Departamento();
                dept.IdDepartamento = id;
                dept.Nombre = nombre;
                dept.Localidad = loc;

                departamentos.Add(dept);
            }
            this.reader.Close();
            this.cn.Close();
            return departamentos;
        }

        public Departamento FindDepartamento(int idDepartamento)
        {
            string sql = "SELECT * FROM DEPT WHERE DEPT_NO = @id";

            SqlParameter pamId = new SqlParameter("@id", idDepartamento);
            this.com.Parameters.Add(pamId);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            this.reader.Read();
            int id = int.Parse(this.reader["DEPT_NO"].ToString());
            string nombre = this.reader["DNOMBRE"].ToString();
            string loc = this.reader["LOC"].ToString();

            Departamento dep = new Departamento();
            dep.IdDepartamento = id;
            dep.Nombre = nombre;
            dep.Localidad = loc;

            this.reader.Close(); 
            this.com.Parameters.Clear();
            this.cn.Close();
            return dep;
        }

        public int InsertarDepto(int id, string nombre, string localidad)
        {
            string sql = "INSERT INTO DEPT VALUES(@id, @nombre, @localidad)";
            SqlParameter pamId = new SqlParameter("@id", id);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamLoc = new SqlParameter("@localidad", localidad);

            this.com.Parameters.Add(pamId);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamLoc);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            int results = this.com.ExecuteNonQuery();

            this.com.Parameters.Clear();
            this.cn.Close();

            return results;
        }


        public int ModificarDepto(int id, string nombre, string loc )
        {
            string sql = "UPDATE DEPT SET DNOMBRE=@nombre, LOC = @loc " +
                " WHERE DEPT_NO = @id";
            SqlParameter pamId = new SqlParameter("@id", id);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamLoc = new SqlParameter("@loc", loc);

            this.com.Parameters.Add(pamId);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamLoc);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            int results = this.com.ExecuteNonQuery();

            this.com.Parameters.Clear();
            this.cn.Close();

            return results;

        }

        public int EliminarDepartamento(int id)
        {
            string sql = "DELETE FROM DEPT WHERE DEPT_NO = @id";

            SqlParameter pamId = new SqlParameter("@id", id);
            this.com.Parameters.Add(pamId);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();

            int rows = this.com.ExecuteNonQuery();  

            this.com.Parameters.Clear();
            this.cn.Close();

            return rows;
        }
    }
}
