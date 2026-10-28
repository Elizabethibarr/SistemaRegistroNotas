namespace SistemaRegistroNotas
{
    partial class FrmRegistrarNota
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCodigo = new TextBox();
            txtLaboratorio = new TextBox();
            txtParcial = new TextBox();
            txtAsistencia = new TextBox();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            dgvRegistro = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRegistro).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(81, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(87, 70);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(87, 146);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 2;
            // 
            // txtLaboratorio
            // 
            txtLaboratorio.Location = new Point(439, 77);
            txtLaboratorio.Name = "txtLaboratorio";
            txtLaboratorio.Size = new Size(125, 27);
            txtLaboratorio.TabIndex = 3;
            // 
            // txtParcial
            // 
            txtParcial.Location = new Point(439, 131);
            txtParcial.Name = "txtParcial";
            txtParcial.Size = new Size(125, 27);
            txtParcial.TabIndex = 4;
            // 
            // txtAsistencia
            // 
            txtAsistencia.Location = new Point(439, 20);
            txtAsistencia.Name = "txtAsistencia";
            txtAsistencia.Size = new Size(125, 27);
            txtAsistencia.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(34, 409);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar estudiante";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(205, 409);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvRegistro
            // 
            dgvRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistro.Location = new Point(320, 250);
            dgvRegistro.Name = "dgvRegistro";
            dgvRegistro.RowHeadersWidth = 51;
            dgvRegistro.Size = new Size(896, 188);
            dgvRegistro.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 9;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 10;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 146);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 11;
            label3.Text = "Código:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 23);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 12;
            label4.Text = "Asistencia:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(343, 80);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 13;
            label5.Text = "Laboratorio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(343, 131);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 14;
            label6.Text = "Parcial:";
            // 
            // FrmRegistrarNota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvRegistro);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(txtAsistencia);
            Controls.Add(txtParcial);
            Controls.Add(txtLaboratorio);
            Controls.Add(txtCodigo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "FrmRegistrarNota";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvRegistro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCodigo;
        private TextBox txtLaboratorio;
        private TextBox txtParcial;
        private TextBox txtAsistencia;
        private Button btnAgregar;
        private Button btnLimpiar;
        private DataGridView dgvRegistro;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
