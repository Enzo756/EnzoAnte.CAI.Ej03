namespace EnzoAnte.CAI.Ej03
{
    partial class FormPrincipal
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
            cmbPaís = new ComboBox();
            lblPaís = new Label();
            cmbProvincia = new ComboBox();
            lblProvincia = new Label();
            cmbLocalidad = new ComboBox();
            lblLocalidad = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtDepartamento = new TextBox();
            lblDepartamento = new Label();
            txtPiso = new TextBox();
            lblPiso = new Label();
            txtNúmero = new TextBox();
            txtCalle = new TextBox();
            lblNúmero = new Label();
            lblCalle = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbPaís
            // 
            cmbPaís.FormattingEnabled = true;
            cmbPaís.Location = new Point(23, 29);
            cmbPaís.Name = "cmbPaís";
            cmbPaís.Size = new Size(121, 23);
            cmbPaís.TabIndex = 0;
            // 
            // lblPaís
            // 
            lblPaís.AutoSize = true;
            lblPaís.Location = new Point(23, 11);
            lblPaís.Name = "lblPaís";
            lblPaís.Size = new Size(28, 15);
            lblPaís.TabIndex = 1;
            lblPaís.Text = "País";
            // 
            // cmbProvincia
            // 
            cmbProvincia.FormattingEnabled = true;
            cmbProvincia.Location = new Point(23, 93);
            cmbProvincia.Name = "cmbProvincia";
            cmbProvincia.Size = new Size(121, 23);
            cmbProvincia.TabIndex = 2;
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Location = new Point(23, 75);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(98, 15);
            lblProvincia.TabIndex = 3;
            lblProvincia.Text = "Provincia/Región";
            // 
            // cmbLocalidad
            // 
            cmbLocalidad.FormattingEnabled = true;
            cmbLocalidad.Location = new Point(23, 159);
            cmbLocalidad.Name = "cmbLocalidad";
            cmbLocalidad.Size = new Size(121, 23);
            cmbLocalidad.TabIndex = 4;
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Location = new Point(23, 141);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(58, 15);
            lblLocalidad.TabIndex = 5;
            lblLocalidad.Text = "Localidad";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDepartamento);
            groupBox1.Controls.Add(lblDepartamento);
            groupBox1.Controls.Add(txtPiso);
            groupBox1.Controls.Add(lblPiso);
            groupBox1.Controls.Add(txtNúmero);
            groupBox1.Controls.Add(txtCalle);
            groupBox1.Location = new Point(184, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 105);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dirección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 30);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Número";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 8;
            label1.Text = "Calle";
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(324, 44);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(100, 23);
            txtDepartamento.TabIndex = 7;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(324, 30);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(83, 15);
            lblDepartamento.TabIndex = 6;
            lblDepartamento.Text = "Departamento";
            // 
            // txtPiso
            // 
            txtPiso.Location = new Point(218, 44);
            txtPiso.Name = "txtPiso";
            txtPiso.Size = new Size(100, 23);
            txtPiso.TabIndex = 5;
            // 
            // lblPiso
            // 
            lblPiso.AutoSize = true;
            lblPiso.Location = new Point(218, 30);
            lblPiso.Name = "lblPiso";
            lblPiso.Size = new Size(29, 15);
            lblPiso.TabIndex = 4;
            lblPiso.Text = "Piso";
            // 
            // txtNúmero
            // 
            txtNúmero.Location = new Point(112, 44);
            txtNúmero.Name = "txtNúmero";
            txtNúmero.Size = new Size(100, 23);
            txtNúmero.TabIndex = 3;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(6, 44);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(100, 23);
            txtCalle.TabIndex = 1;
            // 
            // lblNúmero
            // 
            lblNúmero.Location = new Point(0, 0);
            lblNúmero.Name = "lblNúmero";
            lblNúmero.Size = new Size(100, 23);
            lblNúmero.TabIndex = 0;
            // 
            // lblCalle
            // 
            lblCalle.Location = new Point(0, 0);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(100, 23);
            lblCalle.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(476, 159);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(557, 159);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 208);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(groupBox1);
            Controls.Add(lblLocalidad);
            Controls.Add(cmbLocalidad);
            Controls.Add(lblProvincia);
            Controls.Add(cmbProvincia);
            Controls.Add(lblPaís);
            Controls.Add(cmbPaís);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPrincipal";
            Text = "Prototipos - Ejercicio 3";
            Load += FormPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPaís;
        private Label lblPaís;
        private ComboBox cmbProvincia;
        private Label lblProvincia;
        private ComboBox cmbLocalidad;
        private Label lblLocalidad;
        private GroupBox groupBox1;
        private Label lblCalle;
        private TextBox txtPiso;
        private Label lblPiso;
        private TextBox txtNúmero;
        private Label lblNúmero;
        private TextBox txtCalle;
        private TextBox txtDepartamento;
        private Label lblDepartamento;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
    }
}