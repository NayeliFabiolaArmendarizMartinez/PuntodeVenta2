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
    public partial class FrmEmpleados : Form
    {
        public int id;
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            AgregarEmpleados();
            TodosEmpleados();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            TodosEmpleados();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            
            BuscarEmpleado();
        }

        private void BuscarEmpleado()
        {
            
            using (var context = new AplicationDbContext())
            {
                var empleados = context.Empleados.Where(x => x.Nombre.Contains(txtBuscador.Text)).ToList();
                dgvEmpleados.DataSource = empleados;
            }
        }

        private void AgregarEmpleados()
        {
            using (var context = new AplicationDbContext())
            {
                //paso 1 crear el objeto 
                var empleado1 = new Empleados();
                empleado1.Nombre = txtNombres.Text;
                empleado1.ApellidoPaterno = txtApellidoPaterno.Text;
                empleado1.ApellidoMaterno = txtApellidoMaterno.Text;
                empleado1.Sexo = rbtnFemenino.Checked ? "Femenino" : "Masculino";
                empleado1.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                empleado1.RFC = txtRFC.Text;

                //Paso 2: Notificamos a EFC que queremos agregar un empleado
                context.Empleados.Add(empleado1);

                //Paso 3: Guardamos los cambios
                context.SaveChanges();

            }
        }
        private void TodosEmpleados()
        {
            using (var context = new AplicationDbContext())
            {
                var empleados = context.Empleados.ToList();
                dgvEmpleados.DataSource = empleados;
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value.ToString());
            txtNombres.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApellidoPaterno.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            txtApellidoMaterno.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            if(dgvEmpleados.CurrentRow.Cells[4].Value.ToString() == "Femenino")
            {
                rbtnFemenino.Checked = true;
            }
            else
            {
                rbtnMasculino.Checked = true;
            }
            dtpFechaNacimiento.Value = Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells[5].Value.ToString());
            txtRFC.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            using(var context = new AplicationDbContext())
            {
                if(id != 0)
                {
                    //Busqueda ORM
                    var empleado = context.Empleados.First(x => x.Id == id);
                    if(empleado != null)
                    {
                        empleado.Nombre = txtNombres.Text;
                        empleado.ApellidoPaterno = txtApellidoPaterno.Text;
                        empleado.ApellidoMaterno = txtApellidoMaterno.Text;
                        empleado.Sexo = rbtnFemenino.Checked ? "Femenino" : "Masculino";
                        empleado.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                        empleado.RFC = txtRFC.Text;
                        context.SaveChanges();
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            using (var context = new AplicationDbContext())
            {
                if(id != 0)
                {
                    //Busqueda con un ORM
                    var empleado = context.Empleados.First(x => x.Id == id);
                    if (empleado != null)
                    {
                        context.Remove(empleado);
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
