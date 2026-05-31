using SistemaInventario.Repositorios;
using System.Data;

namespace SistemaInventario
{
    public partial class FormDashboard : Form
    {
        private readonly VentaRepositorio ventaRepositorio = new VentaRepositorio();
        private readonly ProductoRepositorio productoRepositorio = new ProductoRepositorio();
        private DataTable ventasPorProducto = new DataTable();

        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            var productos = productoRepositorio.ObtenerTodos();
            var historial = ventaRepositorio.ObtenerHistorial();
            ventasPorProducto = ventaRepositorio.VentasPorProducto();

            decimal totalVentas = 0;
            foreach (DataRow row in historial.Rows)
            {
                totalVentas += Convert.ToDecimal(row["Total"]);
            }

            lblProductos.Text = $"Productos registrados: {productos.Rows.Count}";
            lblVentas.Text = $"Ventas registradas: {historial.Rows.Count}";
            lblTotal.Text = $"Total vendido: ${totalVentas:0.00}";
            panelGrafica.Invalidate();
        }

        private void panelGrafica_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawString("Ventas por producto", new Font("Segoe UI", 13, FontStyle.Bold), Brushes.Black, 20, 15);

            if (ventasPorProducto.Rows.Count == 0)
            {
                e.Graphics.DrawString("Aún no hay ventas registradas.", new Font("Segoe UI", 11), Brushes.DimGray, 20, 65);
                return;
            }

            decimal max = 0;
            foreach (DataRow rowMax in ventasPorProducto.Rows)
            {
                decimal valor = Convert.ToDecimal(rowMax["TotalVendido"]);
                if (valor > max) max = valor;
            }
            int y = 70;
            int maxAncho = panelGrafica.Width - 260;

            foreach (DataRow row in ventasPorProducto.Rows)
            {
                string producto = row["Producto"].ToString() ?? "Producto";
                decimal total = Convert.ToDecimal(row["TotalVendido"]);
                int ancho = max == 0 ? 0 : (int)((total / max) * maxAncho);

                e.Graphics.DrawString(producto, new Font("Segoe UI", 9), Brushes.Black, 20, y);
                e.Graphics.FillRectangle(Brushes.SteelBlue, 190, y, ancho, 24);
                e.Graphics.DrawString($"${total:0.00}", new Font("Segoe UI", 9), Brushes.Black, 200 + ancho, y);
                y += 45;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
