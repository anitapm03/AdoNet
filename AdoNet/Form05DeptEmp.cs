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
    public partial class Form05DeptEmp : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form05DeptEmp()
        {
            InitializeComponent();
            this.connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();

            this.loadDepartamentos();
        }

        private void loadDepartamentos()
        {
            string sql = "SELECT * FROM DEPT";

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstDepartamentos.Items.Clear();

            while (this.reader.Read())
            {
                string dnombre = this.reader["DNOMBRE"].ToString();

                this.lstDepartamentos.Items.Add(dnombre);

            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string oficio = this.txtOficio.Text;
            string salario = this.txtSalario.Text;

            string nombre = this.lstEmpleados.SelectedItem.ToString();

            string sql = "UPDATE EMP SET SALARIO = @sal, " +
                "OFICIO = @of WHERE APELLIDO = @ap";

            SqlParameter sal = new SqlParameter();
            sal.ParameterName = "@sal";
            sal.DbType = DbType.String;
            sal.Value = salario;

            sal.Direction = ParameterDirection.Input;
            this.com.Parameters.Add(sal);

            SqlParameter of = new SqlParameter();
            of.ParameterName = "@of";
            of.DbType = DbType.String;
            of.Value = oficio;

            of.Direction = ParameterDirection.Input;
            this.com.Parameters.Add(of);

            SqlParameter ap = new SqlParameter();
            ap.ParameterName = "@ap";
            ap.DbType = DbType.String;
            ap.Value = nombre;

            ap.Direction = ParameterDirection.Input;
            this.com.Parameters.Add(ap);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            int modificados = this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();
            MessageBox.Show("Modificados: " + modificados);
            this.txtOficio.Clear();
            this.txtSalario.Clear();

            this.lstDepartamentos_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dnombre = this.lstDepartamentos.SelectedItem.ToString();

            string sql = "SELECT * FROM EMP E " +
                "INNER JOIN DEPT D ON E.DEPT_NO = D.DEPT_NO " +
                "WHERE D.DNOMBRE = @dn";

            SqlParameter dn = new SqlParameter();
            dn.ParameterName = "@dn";
            dn.DbType = DbType.String;
            dn.Value = dnombre;

            dn.Direction = ParameterDirection.Input;
            this.com.Parameters.Add(dn);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();

            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();

                this.lstEmpleados.Items.Add(apellido);
            }
            this.com.Parameters.Clear();
            this.reader.Close();
            this.cn.Close();
        }

        private void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string apellido = this.lstEmpleados.SelectedItem.ToString();
            this.txtOficio.Clear();
            this.txtSalario.Clear();

            string sql = "SELECT * FROM EMP WHERE APELLIDO = @nom";

            SqlParameter nom = new SqlParameter();
            nom.ParameterName = "@nom";
            nom.DbType = DbType.String;
            nom.Value = apellido;

            nom.Direction = ParameterDirection.Input;
            this.com.Parameters.Add(nom);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.txtOficio.Clear();
            this.txtSalario.Clear();

            while (this.reader.Read())
            {
                string oficio = this.reader["OFICIO"].ToString();
                string salario = this.reader["SALARIO"].ToString();

                this.txtOficio.Text = oficio;
                this.txtSalario.Text = salario;
            }
            this.com.Parameters.Clear();
            this.reader.Close();
            this.cn.Close();
        }
    }
}
