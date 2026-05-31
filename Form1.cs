namespace SistemaInventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos frm = new FormProductos();
            frm.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVentas frm = new FormVentas();
            frm.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial frm = new FormHistorial();
            frm.ShowDialog();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard frm = new FormDashboard();
            frm.ShowDialog();
        }
    }
}
