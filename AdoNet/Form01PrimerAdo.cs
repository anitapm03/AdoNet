using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdoNet
{
    public partial class Form01PrimerAdo : Form
    {
        //declaramos los obj de acceso a datos 
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form01PrimerAdo()
        {
            InitializeComponent();
            this.connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            //establecemos la cadena de conexion
            this.cn = new SqlConnection(this.connectionString);

            //vamos a recuperar un evento de la conexión para que 
            //nos indique su cambio de estado
            this.cn.StateChange += Cn_StateChange; //+= TAB
            this.com = new SqlCommand();

        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblMensaje.Text = "la conexion esta pasando de " + e.OriginalState
                + " a " + e.CurrentState;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.cn.State == ConnectionState.Closed)
                {
                    this.cn.Open();
                }

                this.lblMensaje.BackColor = Color.Green;
            }
            catch (SqlException ex)
            {
                this.lblMensaje.Text = "Exception SQL: " + ex.ToString();
                this.lblMensaje.BackColor = Color.Red;
            }

        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            //indicamos la conexión que utilizaa el command
            this.com.Connection = this.cn;

            //creamos la consulta a realizar
            string sql = "SELECT * FROM EMP";

            //indicamos el tipo de consulta a ejecuutar en el command
            this.com.CommandType = CommandType.Text;

            //indicamos al command la consulta
            this.com.CommandText = sql;

            //aqui la conexion debe estar abierta
            //ejecutamos la consulta de seleccion en el command
            //dicho método nos devuelve un objeto datareader
            this.reader = this.com.ExecuteReader();

            //leemos el nombre de la primera columna
            //string columna = this.reader.GetName(0);
            //string tipoDato = this.reader.GetDataTypeName(0);
            for (int i = 0; i < this.reader.FieldCount; i++)
            {
                string columna = this.reader.GetName(i);
                string tipoDato = this.reader.GetDataTypeName(i);

                this.lstColumnas.Items.Add(columna);
                this.lstTiposDato.Items.Add(tipoDato);

            }
            
            //leemos un registro
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstApellidos.Items.Add(apellido);
            }
            
            this.reader.Close();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblMensaje.BackColor = Color.Red;
        }

        private void lstTiposDato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
