using SistemaInventario.Repositorios;
using System.Data;

namespace SistemaInventario
{
    public partial class FormVentas : Form
    {
        private readonly ProductoRepositorio productoRepositorio = new ProductoRepositorio();
        private readonly VentaRepositorio ventaRepositorio = new VentaRepositorio();

        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource = productoRepositorio.ObtenerTodos();
            dgvProductos.ClearSelection();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdProducto.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Ingrese un ID de producto válido.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            try
            {
                ventaRepositorio.RegistrarVenta(id, cantidad);
                MessageBox.Show("Venta realizada correctamente.");
                txtIdProducto.Clear();
                txtCantidad.Clear();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var fila = dgvProductos.Rows[e.RowIndex];
            txtIdProducto.Text = fila.Cells["Id"].Value?.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
