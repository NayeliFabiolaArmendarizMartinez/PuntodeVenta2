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
    public partial class FrmProductos : Form
    {
        public int id;
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            
            AgregarProductos();
            TodosProductos();
        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            TodosProductos();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }
        private void BuscarProducto()
        {
            
            using (var context = new AplicationDbContext())
            {
                var productos = context.Productos.Where(x => x.Nombre.Contains(txtBuscador.Text)).ToList();
                dgvProductos.DataSource = productos;
            }

        }

        private void AgregarProductos()
        {
            using (var context = new AplicationDbContext())
            {
                //paso 1 crear el objeto 
                var producto = new Productos();
                producto.Nombre = txtNombre.Text;
                producto.Marca = txtMarca.Text;
                producto.Cantidad = int.Parse(txtCantidad.Text);
                producto.PrecioCompra = double.Parse(txtPrecioCompra.Text);
                producto.PrecioVenta = double.Parse(txtPrecioVenta.Text);
                producto.Categoria = txtCategoria.Text;

                //Paso 2: Notificamos a EFC que queremos agregar un producto
                context.Productos.Add(producto);

                //Paso 3: Guardamos los cambios
                context.SaveChanges();

            }
        }

        private void TodosProductos()
        {
            using (var context = new AplicationDbContext())
            {
                var productos = context.Productos.ToList();
                dgvProductos.DataSource = productos;
            }
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value.ToString());
            txtNombre.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txtMarca.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            txtCantidad.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            txtPrecioCompra.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            txtPrecioVenta.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
            txtCategoria.Text = dgvProductos.CurrentRow.Cells[6].Value.ToString();
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new AplicationDbContext())
            {
                if (id != 0)
                {
                    //Busqueda ORM
                    var producto = context.Productos.First(x => x.Id == id);
                    if (producto != null)
                    {
                        producto.Nombre = txtNombre.Text;
                        producto.Marca = txtMarca.Text;
                        producto.Cantidad = int.Parse(txtCantidad.Text);
                        producto.PrecioCompra = double.Parse(txtPrecioCompra.Text);
                        producto.PrecioVenta = double.Parse(txtPrecioVenta.Text);
                        producto.Categoria = txtCategoria.Text;
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
                    var producto = context.Productos.First(x => x.Id == id);
                    if (producto != null)
                    {
                        context.Remove(producto);
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
