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
    public partial class Form02BuscadorEmpleados : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form02BuscadorEmpleados()
        {
            InitializeComponent();
            this.connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int salario = int.Parse(this.txtSalario.Text);
            string sql = "SELECT * FROM EMP WHERE SALARIO >= " + salario;
            //siempre que trabajemos con acceso a datos se usa 
            //el metodo entrar-salir. debemos abrir la conexion,
            //usar todo lo que necesitemos y despues cerrar los recursos.
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();

            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string sal = this.reader["SALARIO"].ToString();

                this.lstEmpleados.Items.Add(apellido + " - " + sal);

            }
            //liberamos todos los recursos
            this.reader.Close();
            this.cn.Close();

        }

        private void btnBuscarOficio_Click(object sender, EventArgs e)
        {
            string oficio = this.txtOficio.Text;
            string sql = "SELECT * FROM EMP WHERE OFICIO = '" + oficio + "'";

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();

            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string of = this.reader["OFICIO"].ToString();

                this.lstEmpleados.Items.Add(apellido + " - " + of);
            }
            //liberamos todos los recursos
            this.reader.Close();
            this.cn.Close();
        }
    }
}
