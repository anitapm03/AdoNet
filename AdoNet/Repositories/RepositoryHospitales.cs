using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Repositories
{
    public class RepositoryHospitales
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryHospitales()
        {
            string connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand(); 
            this.com.Connection = this.cn;
        }

        public List<Hospital> GetHospitales()
        {
            string sql = "SELECT * FROM HOSPITAL";

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<Hospital> hospitales = new List<Hospital>();
            while (this.reader.Read())
            {
                int id = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                string nombre = this.reader["NOMBRE"].ToString();
                string dir = this.reader["DIRECCION"].ToString();
                string telf = this.reader["TELEFONO"].ToString();
                int numCamas = int.Parse(this.reader["NUM_CAMA"].ToString());

                Hospital hospital = new Hospital();
                hospital.idHospital = id;
                hospital.Nombre = nombre;
                hospital.Direccion = dir;
                hospital.Telefono = telf;
                hospital.NumeroCamas = numCamas;

                hospitales.Add( hospital );
            }

            this.reader.Close();
            this.cn.Close();

            return hospitales;
        }

        public Hospital FindHospital(int idHospital)
        {
            string sql = "SELECT * FROM HOSPITAL WHERE HOSPITAL_COD = @id";

            SqlParameter idparam = new SqlParameter("@id", idHospital);
            this.com.Parameters.Add(idparam);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            this.reader.Read();
            int id = int.Parse(this.reader["HOSPITAL_COD"].ToString());
            string nombre = this.reader["NOMBRE"].ToString();
            string dir = this.reader["DIRECCION"].ToString();
            string telf = this.reader["TELEFONO"].ToString();
            int numCamas = int.Parse(this.reader["NUM_CAMA"].ToString());

            Hospital hospital = new Hospital();
            hospital.idHospital = id;
            hospital.Nombre = nombre;
            hospital.Direccion = dir;
            hospital.Telefono = telf;
            hospital.NumeroCamas = numCamas;

            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();

            return hospital;

        }

        public int InsertarHospital
            (int id, string nombre, string dir, string telf, int camas)
        {
            string sql = "INSERT INTO HOSPITAL VALUES(@id, @nombre, @dir, @telf, @camas)";
            SqlParameter pamId = new SqlParameter("@id", id);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamDir = new SqlParameter("@dir", dir);
            SqlParameter pamTelf = new SqlParameter("@telf", telf);
            SqlParameter pamCamas = new SqlParameter("@camas", camas);

            this.com.Parameters.Add(pamId);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamDir);
            this.com.Parameters.Add(pamTelf);
            this.com.Parameters.Add(pamCamas);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            int results = this.com.ExecuteNonQuery();

            this.com.Parameters.Clear();
            this.cn.Close();

            return results;
        }

        public int ModificarHospital
            (int id, string nombre, string dir, string telf, int camas)
        {
            string sql = "UPDATE HOSPITAL SET NOMBRE = @nombre," +
                "DIRECCION = @dir, TELEFONO = @telf, NUM_CAMA = @camas " +
                "WHERE HOSPITAL_COD = @id";
            SqlParameter pamId = new SqlParameter("@id", id);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamDir = new SqlParameter("@dir", dir);
            SqlParameter pamTelf = new SqlParameter("@telf", telf);
            SqlParameter pamCamas = new SqlParameter("@camas", camas);

            this.com.Parameters.Add(pamId);
            this.com.Parameters.Add(pamNombre);
            this.com.Parameters.Add(pamDir);
            this.com.Parameters.Add(pamTelf);
            this.com.Parameters.Add(pamCamas);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            int results = this.com.ExecuteNonQuery();

            this.com.Parameters.Clear();
            this.cn.Close();

            return results;

        }

        public int EliminarHospital(int idHospital)
        {
            string sql = "DELETE FROM HOSPITAL WHERE HOSPITAL_COD = @id";
            SqlParameter pamId = new SqlParameter("@id", idHospital);
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
