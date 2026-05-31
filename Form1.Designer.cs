namespace SistemaInventario
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Productos = new Button();
            btnVentas = new Button();
            label1 = new Label();
            btnHistorial = new Button();
            btnDashboard = new Button();
            SuspendLayout();
            // 
            // Productos
            // 
            Productos.BackColor = Color.SteelBlue;
            Productos.FlatStyle = FlatStyle.Flat;
            Productos.ForeColor = Color.White;
            Productos.Location = new Point(250, 175);
            Productos.Margin = new Padding(4, 5, 4, 5);
            Productos.Name = "Productos";
            Productos.Size = new Size(280, 100);
            Productos.TabIndex = 0;
            Productos.Text = "Productos";
            Productos.UseVisualStyleBackColor = false;
            Productos.Click += btnProductos_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.SeaGreen;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(610, 175);
            btnVentas.Margin = new Padding(4, 5, 4, 5);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(280, 100);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(354, 72);
            label1.Name = "label1";
            label1.Size = new Size(441, 48);
            label1.TabIndex = 2;
            label1.Text = "Sistema de Inventario";
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.DarkOrange;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.ForeColor = Color.White;
            btnHistorial.Location = new Point(250, 342);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(280, 100);
            btnHistorial.TabIndex = 3;
            btnHistorial.Text = "Historial de Ventas";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.MediumPurple;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(610, 342);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(280, 100);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1143, 650);
            Controls.Add(btnDashboard);
            Controls.Add(btnHistorial);
            Controls.Add(label1);
            Controls.Add(btnVentas);
            Controls.Add(Productos);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button Productos;
        private Button btnVentas;
        private Label label1;
        private Button btnHistorial;
        private Button btnDashboard;
    }
}
