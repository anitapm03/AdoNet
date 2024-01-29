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
using static System.Runtime.InteropServices.JavaScript.JSType;
#region procedures
/*
 * CREATE PROCEDURE SP_DEPARTAMENTOS
AS 
	SELECT * FROM DEPARTAMENTOS
GO

CREATE PROCEDURE SP_INSERT_DEPARTAMENTO
(@DEPTNO INT,
@NOMBREDEPT NVARCHAR(50),
@LOCALIDADDEPT NVARCHAR(50))
AS
	INSERT INTO DEPARTAMENTOS VALUES
	(@DEPTNO, @NOMBREDEPT, @LOCALIDADDEPT)
	PRINT 'DEPARTAMENTO INSERTADO CORRECTAMENTE'
GO
*/
#endregion
namespace AdoNet
{
    public partial class Form10MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form10MensajesServidor()
        {
            InitializeComponent();
            string connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;

            //para el msg
            this.cn.InfoMessage += Cn_InfoMessage;
            //cosas del procedure
            this.loadDeptos();
        }
        //metodo autogenerado para los msgs
        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblMensajesServidor.Text = e.Message;
        }

        private void loadDeptos()
        {
            this.lstDepartamentos.Items.Clear();
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_DEPARTAMENTOS";

            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.lstDepartamentos.Items.Add(
                    this.reader["DNOMBRE"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int iddepto = int.Parse(this.txtNumero.Text);
            string dnombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;

            SqlParameter parNumero = new SqlParameter("@DEPTNO", iddepto);
            this.com.Parameters.Add(parNumero);
            SqlParameter parNombre = new SqlParameter("@NOMBREDEPT", dnombre);
            this.com.Parameters.Add(parNombre);
            SqlParameter parLoc = new SqlParameter("@LOCALIDADDEPT", localidad);
            this.com.Parameters.Add(parLoc);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "SP_INSERT_DEPARTAMENTO";

            this.cn.Open();
            int inserted = this.com.ExecuteNonQuery();

            this.com.Parameters.Clear();
            this.reader.Close();
            this.cn.Close();
            MessageBox.Show("insertados: " + inserted);
            this.loadDeptos();
        }

        private void lblMensajesServidor_Click(object sender, EventArgs e)
        {

        }
    }
}
