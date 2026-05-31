namespace SistemaInventario
{
    partial class FormHistorial
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvHistorial;
        private Button btnVolver;
        private Label lblTitulo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvHistorial = new DataGridView();
            btnVolver = new Button();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BackgroundColor = Color.White;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(63, 115);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersWidth = 62;
            dgvHistorial.Size = new Size(1005, 401);
            dgvHistorial.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DimGray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(63, 546);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(173, 43);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver al menú";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(63, 46);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(288, 45);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Historial de Ventas";
            // 
            // FormHistorial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1143, 650);
            Controls.Add(lblTitulo);
            Controls.Add(btnVolver);
            Controls.Add(dgvHistorial);
            Name = "FormHistorial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historial de Ventas";
            Load += FormHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
