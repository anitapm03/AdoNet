using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form03EliminarEnfermos : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form03EliminarEnfermos()
        {
            InitializeComponent();

            this.connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();

            this.cargarEnfermos();
        }

        private void cargarEnfermos()
        {
            string sql = "SELECT * FROM ENFERMO";

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEnfermos.Items.Clear();

            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string inscripcion = this.reader["INSCRIPCION"].ToString();

                this.lstEnfermos.Items.Add(inscripcion + " - " + apellido);
            }

            this.reader.Close();
            this.cn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            int insc = int.Parse(this.txtInscripcion.Text);
            string slq = "DELETE FROM ENFERMO WHERE INSCRIPCION = @insc";

            SqlParameter paminsc = new SqlParameter();
            paminsc.ParameterName = "@insc";
            paminsc.DbType = DbType.Int32;
            paminsc.Value = insc;

            //direction por defecto es Input, por lo que no 
            //es necesario indicarlo a no ser que lo deseemos modificar
            paminsc.Direction = ParameterDirection.Input;

            //añadimos el parametro a la coleccion del command
            this.com.Parameters.Add(paminsc);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = slq;

            this.cn.Open();
            //las consultas de accion devuelven un int
            //que es el numero de registros afectados
            int eliminados = this.com.ExecuteNonQuery();
            
            this.cn.Close();
            this.com.Parameters.Clear();

            MessageBox.Show("Se han eliminado " + eliminados + " efermos.");
            this.cargarEnfermos();
        }
    }
}
