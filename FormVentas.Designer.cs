namespace SistemaInventario
{
    partial class FormVentas
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
            txtIdProducto = new TextBox();
            txtCantidad = new TextBox();
            btnVender = new Button();
            btnVolver = new Button();
            label1 = new Label();
            label2 = new Label();
            dgvProductos = new DataGridView();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(284, 144);
            txtIdProducto.Margin = new Padding(4, 5, 4, 5);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(141, 31);
            txtIdProducto.TabIndex = 0;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(284, 219);
            txtCantidad.Margin = new Padding(4, 5, 4, 5);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(141, 31);
            txtCantidad.TabIndex = 1;
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.SeaGreen;
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.ForeColor = Color.White;
            btnVender.Location = new Point(83, 312);
            btnVender.Margin = new Padding(4, 5, 4, 5);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(158, 43);
            btnVender.TabIndex = 2;
            btnVender.Text = "Registrar venta";
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DimGray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(267, 312);
            btnVolver.Margin = new Padding(4, 5, 4, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(158, 43);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver al menú";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 147);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 4;
            label1.Text = "ID del producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 222);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 5;
            label2.Text = "Cantidad";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(489, 89);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(606, 345);
            dgvProductos.TabIndex = 6;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(83, 55);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(260, 45);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Registro de Venta";
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1143, 500);
            Controls.Add(lblTitulo);
            Controls.Add(dgvProductos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(btnVender);
            Controls.Add(txtCantidad);
            Controls.Add(txtIdProducto);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Venta";
            Load += FormVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtIdProducto;
        private TextBox txtCantidad;
        private Button btnVender;
        private Button btnVolver;
        private Label label1;
        private Label label2;
        private DataGridView dgvProductos;
        private Label lblTitulo;
    }
}
