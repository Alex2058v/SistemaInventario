namespace SistemaInventario
{
    partial class FormDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblProductos;
        private Label lblVentas;
        private Label lblTotal;
        private Panel panelGrafica;
        private Button btnVolver;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblProductos = new Label();
            lblVentas = new Label();
            lblTotal = new Label();
            panelGrafica = new Panel();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(63, 45);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(195, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Dashboard";
            // 
            // lblProductos
            // 
            lblProductos.BackColor = Color.White;
            lblProductos.BorderStyle = BorderStyle.FixedSingle;
            lblProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProductos.Location = new Point(63, 116);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(315, 80);
            lblProductos.TabIndex = 1;
            lblProductos.Text = "Productos registrados: 0";
            lblProductos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVentas
            // 
            lblVentas.BackColor = Color.White;
            lblVentas.BorderStyle = BorderStyle.FixedSingle;
            lblVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblVentas.Location = new Point(414, 116);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(315, 80);
            lblVentas.TabIndex = 2;
            lblVentas.Text = "Ventas registradas: 0";
            lblVentas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.White;
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(765, 116);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(315, 80);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total vendido: $0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelGrafica
            // 
            panelGrafica.BackColor = Color.White;
            panelGrafica.BorderStyle = BorderStyle.FixedSingle;
            panelGrafica.Location = new Point(63, 230);
            panelGrafica.Name = "panelGrafica";
            panelGrafica.Size = new Size(1017, 320);
            panelGrafica.TabIndex = 4;
            panelGrafica.Paint += panelGrafica_Paint;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DimGray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(63, 580);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(173, 43);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver al menú";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1143, 650);
            Controls.Add(btnVolver);
            Controls.Add(panelGrafica);
            Controls.Add(lblTotal);
            Controls.Add(lblVentas);
            Controls.Add(lblProductos);
            Controls.Add(lblTitulo);
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += FormDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
