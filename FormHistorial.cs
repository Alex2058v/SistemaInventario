using SistemaInventario.Repositorios;

namespace SistemaInventario
{
    public partial class FormHistorial : Form
    {
        private readonly VentaRepositorio ventaRepositorio = new VentaRepositorio();

        public FormHistorial()
        {
            InitializeComponent();
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            dgvHistorial.DataSource = ventaRepositorio.ObtenerHistorial();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
