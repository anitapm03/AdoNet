using AdoNet.Models.ResumenEmpleados;
using AdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#region PROCEDURES
/*
 ALTER PROCEDURE SP_HOSPITALES_EMPLEADOS
(@NOMBRE NVARCHAR(50),
@SUMA INT OUT,
@MEDIA INT OUT,
@PERSONAS INT OUT)
AS
	DECLARE @IDHOSPITAL INT
	SELECT @IDHOSPITAL = HOSPITAL_COD FROM HOSPITAL
	WHERE NOMBRE = @NOMBRE
	SELECT APELLIDO, SALARIO
	FROM PLANTILLA WHERE HOSPITAL_COD = @IDHOSPITAL
	UNION
	SELECT APELLIDO, SALARIO FROM DOCTOR
	WHERE HOSPITAL_COD = @IDHOSPITAL
	
	SELECT 
        @SUMA = ISNULL(SUM(SALARIO), 0),
        @MEDIA = ISNULL(AVG(SALARIO), 0),
        @PERSONAS = COUNT(*)
    FROM (
        SELECT SALARIO FROM PLANTILLA WHERE HOSPITAL_COD = @IDHOSPITAL
        UNION
        SELECT SALARIO FROM DOCTOR WHERE HOSPITAL_COD = @IDHOSPITAL
    ) AS EMPLEADOS
GO
*/
#endregion
namespace AdoNet
{
    public partial class Form12salidaHospitales : Form
    {
        RepositoryHospitalEmpleados repo;

        public Form12salidaHospitales()
        {
            InitializeComponent();
            this.repo = new RepositoryHospitalEmpleados();

            this.loadHospitales();

        }

        private void loadHospitales()
        {
            List<string> hospitales = this.repo.GetListaHospitales();
            foreach (string hospital in hospitales)
            {
                this.cmbHospitales.Items.Add(hospital);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbHospitales.SelectedItem.ToString();
            ResumenHospitales resumen = this.repo.GetResumenHospital(nombre);

            this.lstEmpleadosHospital.Items.Clear();
            foreach (EmpleadoHospital emp in resumen.Empleados)
            {
                this.lstEmpleadosHospital.Items.Add(
                    emp.Apellido + " - " + emp.Salario);
            }
            
            this.txtSuma.Text = resumen.SumaSalarial.ToString();
            this.txtMedia.Text = resumen.MediaSalarial.ToString();
            this.txtPersonas.Text = resumen.Personas.ToString();
            
        }
    }
}
