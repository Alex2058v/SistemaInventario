using SistemaInventario.Modelos;
using SistemaInventario.Repositorios;
using System.Data;

namespace SistemaInventario
{
    public partial class FormProductos : Form
    {
        private readonly ProductoRepositorio productoRepositorio = new ProductoRepositorio();
        private int productoSeleccionadoId = 0;

        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource = productoRepositorio.ObtenerTodos();
            dgvProductos.ClearSelection();
        }

        private bool ValidarCampos(out decimal precio, out int stock)
        {
            precio = 0;
            stock = 0;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto.");
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio < 0)
            {
                MessageBox.Show("Ingrese un precio válido.");
                return false;
            }

            if (!int.TryParse(txtStock.Text, out stock) || stock < 0)
            {
                MessageBox.Show("Ingrese un stock válido.");
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            productoSeleccionadoId = 0;
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtNombre.Focus();
            dgvProductos.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(out decimal precio, out int stock)) return;

            var producto = new Producto
            {
                Nombre = txtNombre.Text.Trim(),
                Precio = precio,
                Stock = stock
            };

            productoRepositorio.Agregar(producto);
            MessageBox.Show("Producto guardado correctamente.");
            CargarProductos();
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionadoId == 0)
            {
                MessageBox.Show("Seleccione un producto de la tabla.");
                return;
            }

            if (!ValidarCampos(out decimal precio, out int stock)) return;

            var producto = new Producto
            {
                Id = productoSeleccionadoId,
                Nombre = txtNombre.Text.Trim(),
                Precio = precio,
                Stock = stock
            };

            productoRepositorio.Actualizar(producto);
            MessageBox.Show("Producto actualizado correctamente.");
            CargarProductos();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionadoId == 0)
            {
                MessageBox.Show("Seleccione un producto de la tabla.");
                return;
            }

            var respuesta = MessageBox.Show("¿Desea eliminar el producto seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta != DialogResult.Yes) return;

            try
            {
                productoRepositorio.Eliminar(productoSeleccionadoId);
                MessageBox.Show("Producto eliminado correctamente.");
                CargarProductos();
                LimpiarCampos();
            }
            catch
            {
                MessageBox.Show("No se puede eliminar este producto porque tiene ventas registradas.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                CargarProductos();
                return;
            }

            dgvProductos.DataSource = productoRepositorio.Buscar(txtBuscar.Text.Trim());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            LimpiarCampos();
            CargarProductos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
            if (fila.Cells["Id"].Value == null) return;

            productoSeleccionadoId = Convert.ToInt32(fila.Cells["Id"].Value);
            txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
            txtPrecio.Text = fila.Cells["Precio"].Value?.ToString();
            txtStock.Text = fila.Cells["Stock"].Value?.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
