
namespace PuntodeVenta2
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.lbBuscador = new System.Windows.Forms.Label();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.lbRFC = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbFechaNacimiento = new System.Windows.Forms.Label();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.lbSexo = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lbApellidoMaterno = new System.Windows.Forms.Label();
            this.lbApellidoPaterno = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(104, -4);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(496, 23);
            this.txtBuscador.TabIndex = 39;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // lbBuscador
            // 
            this.lbBuscador.AutoSize = true;
            this.lbBuscador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBuscador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbBuscador.Location = new System.Drawing.Point(50, 2);
            this.lbBuscador.Name = "lbBuscador";
            this.lbBuscador.Size = new System.Drawing.Size(48, 17);
            this.lbBuscador.TabIndex = 38;
            this.lbBuscador.Text = "Buscar";

            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(608, 408);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(174, 23);
            this.BtnRegresar.TabIndex = 37;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(606, 346);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(174, 23);
            this.BtnEliminar.TabIndex = 36;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(606, 317);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(174, 23);
            this.BtnModificar.TabIndex = 35;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(607, 288);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(174, 23);
            this.BtnRegistrar.TabIndex = 34;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(606, 249);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(175, 23);
            this.txtRFC.TabIndex = 33;
            // 
            // lbRFC
            // 
            this.lbRFC.AutoSize = true;
            this.lbRFC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRFC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbRFC.Location = new System.Drawing.Point(607, 229);
            this.lbRFC.Name = "lbRFC";
            this.lbRFC.Size = new System.Drawing.Size(31, 17);
            this.lbRFC.TabIndex = 32;
            this.lbRFC.Text = "RFC";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(607, 203);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(185, 23);
            this.dtpFechaNacimiento.TabIndex = 31;
            // 
            // lbFechaNacimiento
            // 
            this.lbFechaNacimiento.AutoSize = true;
            this.lbFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFechaNacimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFechaNacimiento.Location = new System.Drawing.Point(606, 183);
            this.lbFechaNacimiento.Name = "lbFechaNacimiento";
            this.lbFechaNacimiento.Size = new System.Drawing.Size(137, 17);
            this.lbFechaNacimiento.TabIndex = 30;
            this.lbFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnMasculino.Location = new System.Drawing.Point(691, 161);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbtnMasculino.TabIndex = 29;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Checked = true;
            this.rbtnFemenino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnFemenino.Location = new System.Drawing.Point(607, 161);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(78, 19);
            this.rbtnFemenino.TabIndex = 28;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSexo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSexo.Location = new System.Drawing.Point(606, 141);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(37, 17);
            this.lbSexo.TabIndex = 27;
            this.lbSexo.Text = "Sexo";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(606, 115);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(175, 23);
            this.txtApellidoMaterno.TabIndex = 26;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(607, 69);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(175, 23);
            this.txtApellidoPaterno.TabIndex = 25;
            // 
            // lbApellidoMaterno
            // 
            this.lbApellidoMaterno.AutoSize = true;
            this.lbApellidoMaterno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbApellidoMaterno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbApellidoMaterno.Location = new System.Drawing.Point(606, 95);
            this.lbApellidoMaterno.Name = "lbApellidoMaterno";
            this.lbApellidoMaterno.Size = new System.Drawing.Size(116, 17);
            this.lbApellidoMaterno.TabIndex = 24;
            this.lbApellidoMaterno.Text = "Apellido Materno";
            // 
            // lbApellidoPaterno
            // 
            this.lbApellidoPaterno.AutoSize = true;
            this.lbApellidoPaterno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbApellidoPaterno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbApellidoPaterno.Location = new System.Drawing.Point(606, 49);
            this.lbApellidoPaterno.Name = "lbApellidoPaterno";
            this.lbApellidoPaterno.Size = new System.Drawing.Size(112, 17);
            this.lbApellidoPaterno.TabIndex = 23;
            this.lbApellidoPaterno.Text = "Apellido Paterno";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(606, 23);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(175, 23);
            this.txtNombres.TabIndex = 22;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNombre.Location = new System.Drawing.Point(606, 5);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(74, 17);
            this.lbNombre.TabIndex = 21;
            this.lbNombre.Text = "Nombre(s)";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(6, 23);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(594, 408);
            this.dgvClientes.TabIndex = 20;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(799, 440);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.lbBuscador);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.lbRFC);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lbFechaNacimiento);
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.rbtnFemenino);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.lbApellidoMaterno);
            this.Controls.Add(this.lbApellidoPaterno);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Label lbBuscador;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label lbRFC;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lbFechaNacimiento;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label lbApellidoMaterno;
        private System.Windows.Forms.Label lbApellidoPaterno;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}