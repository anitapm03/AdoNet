using AdoNet.Models;
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

namespace AdoNet
{
    public partial class Form08Empleados : Form
    {
        private RepositoryEmpleados repo;
        private List<int> idsEmpleados;
        private List<string> oficios;
        public Form08Empleados()
        {
            InitializeComponent();
            this.repo = new RepositoryEmpleados();
            this.idsEmpleados = new List<int>();
            this.oficios = new List<string>();
            this.loadOf();
        }

        public void loadEmp()
        {
            List<Empleado> empleados = this.repo.GetEmpleados();
            this.lstOficios.Items.Clear();
            this.idsEmpleados.Clear();
            this.oficios.Clear();

            foreach (Empleado emp in empleados)
            {
                this.lstOficios.Items.Add(emp.Oficio);
                this.oficios.Add(emp.Oficio);
                this.idsEmpleados.Add(emp.Id);
            }
        }

        public void loadOf()
        {
            List<string> oficios = this.repo.GetOficios();
            this.lstOficios.Items.Clear();
            this.oficios.Clear();

            foreach (string of in oficios)
            {
                this.lstOficios.Items.Add(of);
                this.oficios.Add(of);

            }
        }

        private void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string oficio = this.lstOficios.SelectedItem.ToString();

            List<Empleado> empleados = this.repo.GetEmpOficios(oficio);
            this.lstEmpleados.Items.Clear();

            int sumaSalarial = 0;
            foreach (Empleado emp in empleados)
            {
                int sal = int.Parse(emp.Salario.ToString());
                //int com = int.Parse(emp.Comision.ToString());
                sumaSalarial += sal;

                this.lstEmpleados.Items.Add(emp.Apellido);
                this.idsEmpleados.Add(emp.Id);
            }

            this.lblSuma.Text = sumaSalarial.ToString();
        }

        private void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            string oficio = this.lstOficios.SelectedItem.ToString();
            int incremento = int.Parse(this.txtIncremento.Text);

            int actualizados = this.repo.AumentarSalario(incremento, oficio);

            this.lstOficios_SelectedIndexChanged(sender, e);
            MessageBox.Show("Se han acutalizado " + actualizados.ToString() + " empleados.");
        }
    }
}
