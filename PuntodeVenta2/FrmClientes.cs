using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntodeVenta2.Models;

namespace PuntodeVenta2
{
    public partial class FrmClientes : Form
    {
        public int id;
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            AgregarClientes();
            TodosClientes();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            TodosClientes();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            
            BuscarCliente();
        }

        private void BuscarCliente()
        {
            
            using (var context = new AplicationDbContext())
            {
                var clientes = context.Clientes.Where(x => x.Nombre.Contains(txtBuscador.Text)).ToList();
                dgvClientes.DataSource = clientes;
            }

        }

        private void AgregarClientes()
        {
            using (var context = new AplicationDbContext())
            {
                //paso 1 crear el objeto 
                var cliente1 = new Clientes();
                cliente1.Nombre = txtNombres.Text;
                cliente1.ApellidoPaterno = txtApellidoPaterno.Text;
                cliente1.ApellidoMaterno = txtApellidoMaterno.Text;
                cliente1.Sexo = rbtnFemenino.Checked ? "Femenino" : "Masculino";
                cliente1.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                cliente1.RFC = txtRFC.Text;

                //Paso 2: Notificamos a EFC que queremos agregar un cliente
                context.Clientes.Add(cliente1);

                //Paso 3: Guardamos los cambios
                context.SaveChanges();

            }
        }
        private void TodosClientes()
        {
            using (var context = new AplicationDbContext())
            {
                var clientes = context.Clientes.ToList();
                dgvClientes.DataSource = clientes;
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value.ToString());
            txtNombres.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtApellidoPaterno.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtApellidoMaterno.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            if (dgvClientes.CurrentRow.Cells[4].Value.ToString() == "Femenino")
            {
                rbtnFemenino.Checked = true;
            }
            else
            {
                rbtnMasculino.Checked = true;
            }
            dtpFechaNacimiento.Value = Convert.ToDateTime(dgvClientes.CurrentRow.Cells[5].Value.ToString());
            txtRFC.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new AplicationDbContext())
            {
                if (id != 0)
                {
                    //Busqueda ORM
                    var cliente = context.Empleados.First(x => x.Id == id);
                    if (cliente != null)
                    {
                        cliente.Nombre = txtNombres.Text;
                        cliente.ApellidoPaterno = txtApellidoPaterno.Text;
                        cliente.ApellidoMaterno = txtApellidoMaterno.Text;
                        cliente.Sexo = rbtnFemenino.Checked ? "Femenino" : "Masculino";
                        cliente.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                        cliente.RFC = txtRFC.Text;
                        context.SaveChanges();
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            using (var context = new AplicationDbContext())
            {
                if (id != 0)
                {
                    //Busqueda con un ORM
                    var cliente = context.Clientes.First(x => x.Id == id);
                    if (cliente != null)
                    {
                        context.Remove(cliente);
                        context.SaveChanges();
                    }
                }

            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
