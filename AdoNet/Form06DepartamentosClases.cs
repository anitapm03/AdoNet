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
    public partial class Form06DepartamentosClases : Form
    {
        private RepositoryDepartamentos repo;
        private List<int> idsDeptos;
        public Form06DepartamentosClases()
        {
            InitializeComponent();

            this.repo = new RepositoryDepartamentos();
            this.idsDeptos = new List<int>();
            this.loadDepartamentos();
        }

        private void loadDepartamentos()
        {
            List<Departamento> deps = this.repo.GetDepartamentos();
            this.lstDepartamentos.Items.Clear();
            this.idsDeptos.Clear();

            foreach (Departamento dep in deps)
            {
                this.lstDepartamentos.Items.Add(dep.IdDepartamento + " - "
                    + dep.Nombre + " - " + dep.Localidad);

                this.idsDeptos.Add(dep.IdDepartamento);
            }
        }

        private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstDepartamentos.SelectedIndex;

            if (index != -1)
            {
                int id = this.idsDeptos[index];

                Departamento dep = this.repo.FindDepartamento(id);

                this.txtId.Text = dep.IdDepartamento.ToString();
                this.txtNombre.Text = dep.Nombre.ToString();
                this.txtLocalidad.Text = dep.Localidad.ToString();
            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string loc = this.txtLocalidad.Text;

            int insertados = this.repo.InsertarDepto(id, nombre, loc);

            this.loadDepartamentos();
            MessageBox.Show("Deptos insertados: " + insertados);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string loc = this.txtLocalidad.Text;

            int modificados = this.repo.ModificarDepto(id, nombre, loc);

            this.loadDepartamentos();
            MessageBox.Show("Deptos modificados: " + modificados);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = this.lstDepartamentos.SelectedIndex;

            if (index != -1)
            {
                int id = this.idsDeptos[index];

                int eliminados = this.repo.EliminarDepartamento(id);

                this.loadDepartamentos();
                MessageBox.Show("Deptos eliminados: " + eliminados);
            }
        }
    }
}
