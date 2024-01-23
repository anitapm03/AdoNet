using AdoNet.Models;
using AdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form07Hospitales : Form
    {
        private RepositoryHospitales repo;
        private List<int> idsHospitales;
        public Form07Hospitales()
        {
            InitializeComponent();
            this.repo = new RepositoryHospitales();
            this.idsHospitales = new List<int>();
            this.loadHospitales();

        }

        private void loadHospitales()
        {
            List<Hospital> hospitales = this.repo.GetHospitales();
            this.lstHospitales.Items.Clear();
            this.idsHospitales.Clear();

            foreach (Hospital h in hospitales)
            {
                this.lstHospitales.Items.Add(h.Nombre);
                this.idsHospitales.Add(h.idHospital);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string dir = this.txtDireccion.Text;
            string telf = this.txtTelefono.Text;
            int camas = int.Parse(this.txtCamas.Text);

            int insertados = this.repo.InsertarHospital(id, nombre, dir, telf, camas);

            this.loadHospitales();

            MessageBox.Show("Hospitales insertados: " + insertados);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string dir = this.txtDireccion.Text;
            string telf = this.txtTelefono.Text;
            int camas = int.Parse(this.txtCamas.Text);

            int modificados = this.repo.ModificarHospital(id, nombre, dir, telf, camas);

            this.loadHospitales();
            MessageBox.Show("Hospitales modificados: " + modificados);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = this.lstHospitales.SelectedIndex;

            if (index != -1)
            {
                int id = this.idsHospitales[index];

                int eliminados = this.repo.EliminarHospital(id);

                this.loadHospitales();
                MessageBox.Show("Hospitales eliminados: " + eliminados);
            }
        }

        private void lstHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstHospitales.SelectedIndex;

            if (index != -1)
            {
                int id = this.idsHospitales[index];

                Hospital h = this.repo.FindHospital(id);

                this.txtId.Text = h.idHospital.ToString();
                this.txtNombre.Text = h.Nombre.ToString();
                this.txtDireccion.Text = h.Direccion.ToString();
                this.txtTelefono.Text = h.Telefono.ToString();
                this.txtCamas.Text = h.NumeroCamas.ToString();
            }
        }
    }
}
