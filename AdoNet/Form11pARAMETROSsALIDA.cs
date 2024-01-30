using AdoNet.Models.ResumenEmpleados;
using AdoNet.Repositories;
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
#region PROCEDURES
/*
ALTER PROCEDURE SP_EMPLEADOS_DEPARTAMENTO
(@NOMBRE NVARCHAR(50),
@SUMA INT OUT,
@MEDIA INT OUT,
@PERSONAS INT OUT)
AS
	DECLARE @IDDEPARTAMENTO INT
	SELECT @IDDEPARTAMENTO = DEPT_NO FROM DEPT
	WHERE DNOMBRE = @NOMBRE
	SELECT * FROM EMP WHERE DEPT_NO = @IDDEPARTAMENTO
	SELECT @SUMA =ISNULL(SUM(SALARIO), 0),
	@MEDIA =ISNULL(AVG(SALARIO), 0),
	@PERSONAS = COUNT(EMP_NO) FROM EMP
	WHERE DEPT_NO = @IDDEPARTAMENTO
GO
*/
#endregion
namespace AdoNet
{
    public partial class Form11pARAMETROSsALIDA : Form
    {
        RepositoryParametrosSalida repo;

        public Form11pARAMETROSsALIDA()
        {
            InitializeComponent();
            this.repo = new RepositoryParametrosSalida();

            this.loadDepartamentos();
        }

        private void loadDepartamentos()
        {
            List<string> depts = this.repo.GetDepartamentos();
            foreach (string data in depts)
            {
                this.cmbDeptos.Items.Add(data);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string dnombre = this.cmbDeptos.SelectedItem.ToString();
            ResumenEmpleados resumen = this.repo.GetResumenEmpleados(dnombre);

            this.lstEmpleados.Items.Clear();
            foreach (string data in resumen.Apellidos)
            {
                this.lstEmpleados.Items.Add(data);
            }
            this.txtSuma.Text = resumen.SumaSalarial.ToString();
            this.txtMedia.Text = resumen.MediaSalarial.ToString();
            this.txtPersonas.Text = resumen.Personas.ToString();
        }
    }
}
