namespace GestionProductos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnBuscar = new Button();
            btnDatosEjemplo = new Button();
            btnAgregar2 = new Button();
            btnAgregar1 = new Button();
            txtPrecio = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            lblResultado = new Label();
            label3 = new Label();
            dgvLista1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            label4 = new Label();
            dgvLista2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            dgvMezclada = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            btnOrdenar1 = new Button();
            btnOrdenar2 = new Button();
            btnMezclar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLista2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMezclada).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(btnDatosEjemplo);
            groupBox1.Controls.Add(btnAgregar2);
            groupBox1.Controls.Add(btnAgregar1);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(908, 154);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del producto";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ButtonFace;
            btnBuscar.Location = new Point(379, 96);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 37);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnDatosEjemplo
            // 
            btnDatosEjemplo.BackColor = Color.Tomato;
            btnDatosEjemplo.ForeColor = SystemColors.ButtonFace;
            btnDatosEjemplo.Location = new Point(672, 96);
            btnDatosEjemplo.Name = "btnDatosEjemplo";
            btnDatosEjemplo.Size = new Size(199, 37);
            btnDatosEjemplo.TabIndex = 6;
            btnDatosEjemplo.Text = "Datos de ejemplo";
            btnDatosEjemplo.UseVisualStyleBackColor = false;
            btnDatosEjemplo.Click += btnDatosEjemplo_Click;
            // 
            // btnAgregar2
            // 
            btnAgregar2.BackColor = SystemColors.Highlight;
            btnAgregar2.ForeColor = SystemColors.ButtonFace;
            btnAgregar2.Location = new Point(198, 96);
            btnAgregar2.Name = "btnAgregar2";
            btnAgregar2.Size = new Size(160, 37);
            btnAgregar2.TabIndex = 5;
            btnAgregar2.Text = "Agregar a Lista 2";
            btnAgregar2.UseVisualStyleBackColor = false;
            btnAgregar2.Click += btnAgregar2_Click;
            // 
            // btnAgregar1
            // 
            btnAgregar1.BackColor = SystemColors.Highlight;
            btnAgregar1.ForeColor = SystemColors.ButtonFace;
            btnAgregar1.Location = new Point(32, 96);
            btnAgregar1.Name = "btnAgregar1";
            btnAgregar1.Size = new Size(160, 37);
            btnAgregar1.TabIndex = 4;
            btnAgregar1.Text = "Agregar a Lista 1";
            btnAgregar1.UseVisualStyleBackColor = false;
            btnAgregar1.Click += btnAgregar1_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(672, 55);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(199, 23);
            txtPrecio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(672, 30);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Precio S/.";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(32, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(612, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 30);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // lblResultado
            // 
            lblResultado.BackColor = SystemColors.ControlLight;
            lblResultado.BorderStyle = BorderStyle.Fixed3D;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(12, 182);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(908, 40);
            lblResultado.TabIndex = 1;
            lblResultado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(12, 233);
            label3.Name = "label3";
            label3.Size = new Size(358, 26);
            label3.TabIndex = 2;
            label3.Text = "Lista 1";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvLista1
            // 
            dgvLista1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Precio });
            dgvLista1.Location = new Point(12, 262);
            dgvLista1.Name = "dgvLista1";
            dgvLista1.Size = new Size(437, 134);
            dgvLista1.TabIndex = 3;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 250;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio (S/)";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(483, 233);
            label4.Name = "label4";
            label4.Size = new Size(358, 26);
            label4.TabIndex = 5;
            label4.Text = "Lista 2";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvLista2
            // 
            dgvLista2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dgvLista2.Location = new Point(483, 262);
            dgvLista2.Name = "dgvLista2";
            dgvLista2.Size = new Size(437, 134);
            dgvLista2.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Precio (S/)";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(12, 448);
            label5.Name = "label5";
            label5.Size = new Size(908, 38);
            label5.TabIndex = 7;
            label5.Text = "Lista mezclada resultante";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvMezclada
            // 
            dgvMezclada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMezclada.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvMezclada.Location = new Point(12, 489);
            dgvMezclada.Name = "dgvMezclada";
            dgvMezclada.Size = new Size(908, 214);
            dgvMezclada.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 600;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Precio (S/)";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // btnOrdenar1
            // 
            btnOrdenar1.BackColor = SystemColors.ActiveCaption;
            btnOrdenar1.Location = new Point(12, 403);
            btnOrdenar1.Name = "btnOrdenar1";
            btnOrdenar1.Size = new Size(204, 36);
            btnOrdenar1.TabIndex = 9;
            btnOrdenar1.Text = "Ordenar lista 1";
            btnOrdenar1.UseVisualStyleBackColor = false;
            btnOrdenar1.Click += btnOrdenar1_Click;
            // 
            // btnOrdenar2
            // 
            btnOrdenar2.BackColor = SystemColors.ActiveCaption;
            btnOrdenar2.Location = new Point(222, 403);
            btnOrdenar2.Name = "btnOrdenar2";
            btnOrdenar2.Size = new Size(204, 36);
            btnOrdenar2.TabIndex = 10;
            btnOrdenar2.Text = "Ordenar lista 2";
            btnOrdenar2.UseVisualStyleBackColor = false;
            btnOrdenar2.Click += btnOrdenar2_Click;
            // 
            // btnMezclar
            // 
            btnMezclar.BackColor = Color.FromArgb(0, 192, 192);
            btnMezclar.Location = new Point(483, 403);
            btnMezclar.Name = "btnMezclar";
            btnMezclar.Size = new Size(204, 36);
            btnMezclar.TabIndex = 11;
            btnMezclar.Text = "Mezclar lista";
            btnMezclar.UseVisualStyleBackColor = false;
            btnMezclar.Click += btnMezclar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 715);
            Controls.Add(btnMezclar);
            Controls.Add(btnOrdenar2);
            Controls.Add(btnOrdenar1);
            Controls.Add(dgvMezclada);
            Controls.Add(label5);
            Controls.Add(dgvLista2);
            Controls.Add(label4);
            Controls.Add(dgvLista1);
            Controls.Add(label3);
            Controls.Add(lblResultado);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Gestión de Productos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLista2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMezclada).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnDatosEjemplo;
        private Button btnAgregar2;
        private Button btnAgregar1;
        private TextBox txtPrecio;
        private Label label2;
        private TextBox txtNombre;
        private Button btnBuscar;
        private Label lblResultado;
        private Label label3;
        private DataGridView dgvLista1;
        private Label label4;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridView dgvLista2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label label5;
        private DataGridView dgvMezclada;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button btnOrdenar1;
        private Button btnOrdenar2;
        private Button btnMezclar;
    }
}
