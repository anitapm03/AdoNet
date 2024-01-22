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
    public partial class Form04ModificarSalas : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form04ModificarSalas()
        {
            InitializeComponent();

            this.connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();

            this.loadSalas();
        }

        private void loadSalas()
        {
            string sql = "SELECT * FROM SALA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstSalas.Items.Clear();

            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();

                this.lstSalas.Items.Add(nombre);
            }

            this.reader.Close();
            this.cn.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombreNuevo = this.txtNombre.Text;
            string nombreAntiguo = this.lstSalas.SelectedItem.ToString();
            string sql = "UPDATE SALA SET NOMBRE = @nuevo WHERE NOMBRE = @antiguo ";

            SqlParameter paramnuevo = new SqlParameter();
            paramnuevo.ParameterName = "@nuevo";
            paramnuevo.DbType = DbType.String;
            paramnuevo.Value = nombreNuevo;

            paramnuevo.Direction = ParameterDirection.Input;
            this.com.Parameters.Add(paramnuevo);

            SqlParameter paramantiguo = new SqlParameter();
            paramantiguo.ParameterName = "@antiguo";
            paramantiguo.DbType = DbType.String;
            paramantiguo.Value = nombreAntiguo;

            paramantiguo.Direction = ParameterDirection.Input;
            this.com.Parameters.Add(paramantiguo);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            int modificados = this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();

            MessageBox.Show("Se han modificado " + modificados + " salas.");

            this.loadSalas();
        }
    }
}
