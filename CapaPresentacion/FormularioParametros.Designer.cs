namespace CapaPresentacion
{
    partial class FormularioParametros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtConcepto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUnidadDeMedida = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtValorDeMedida = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtidMaestro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(339, 24);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(87, 19);
            this.materialLabel4.TabIndex = 25;
            this.materialLabel4.Text = "Paràmetros";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(26, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(740, 292);
            this.dataGridView1.TabIndex = 24;
            // 
            // txtConcepto
            // 
            this.txtConcepto.Depth = 0;
            this.txtConcepto.Hint = "Concepto";
            this.txtConcepto.Location = new System.Drawing.Point(38, 372);
            this.txtConcepto.MaxLength = 32767;
            this.txtConcepto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.PasswordChar = '\0';
            this.txtConcepto.SelectedText = "";
            this.txtConcepto.SelectionLength = 0;
            this.txtConcepto.SelectionStart = 0;
            this.txtConcepto.Size = new System.Drawing.Size(206, 23);
            this.txtConcepto.TabIndex = 27;
            this.txtConcepto.TabStop = false;
            this.txtConcepto.UseSystemPasswordChar = false;
            // 
            // txtUnidadDeMedida
            // 
            this.txtUnidadDeMedida.Depth = 0;
            this.txtUnidadDeMedida.Hint = "Unidad de Medida";
            this.txtUnidadDeMedida.Location = new System.Drawing.Point(280, 372);
            this.txtUnidadDeMedida.MaxLength = 32767;
            this.txtUnidadDeMedida.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUnidadDeMedida.Name = "txtUnidadDeMedida";
            this.txtUnidadDeMedida.PasswordChar = '\0';
            this.txtUnidadDeMedida.SelectedText = "";
            this.txtUnidadDeMedida.SelectionLength = 0;
            this.txtUnidadDeMedida.SelectionStart = 0;
            this.txtUnidadDeMedida.Size = new System.Drawing.Size(210, 23);
            this.txtUnidadDeMedida.TabIndex = 28;
            this.txtUnidadDeMedida.TabStop = false;
            this.txtUnidadDeMedida.UseSystemPasswordChar = false;
            // 
            // txtValorDeMedida
            // 
            this.txtValorDeMedida.Depth = 0;
            this.txtValorDeMedida.Hint = "Valor de Medida";
            this.txtValorDeMedida.Location = new System.Drawing.Point(545, 372);
            this.txtValorDeMedida.MaxLength = 32767;
            this.txtValorDeMedida.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtValorDeMedida.Name = "txtValorDeMedida";
            this.txtValorDeMedida.PasswordChar = '\0';
            this.txtValorDeMedida.SelectedText = "";
            this.txtValorDeMedida.SelectionLength = 0;
            this.txtValorDeMedida.SelectionStart = 0;
            this.txtValorDeMedida.Size = new System.Drawing.Size(210, 23);
            this.txtValorDeMedida.TabIndex = 29;
            this.txtValorDeMedida.TabStop = false;
            this.txtValorDeMedida.UseSystemPasswordChar = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(352, 477);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(83, 36);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(352, 477);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(84, 36);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(343, 477);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 36);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // txtidMaestro
            // 
            this.txtidMaestro.Depth = 0;
            this.txtidMaestro.Hint = "id Maestro";
            this.txtidMaestro.Location = new System.Drawing.Point(280, 430);
            this.txtidMaestro.MaxLength = 32767;
            this.txtidMaestro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtidMaestro.Name = "txtidMaestro";
            this.txtidMaestro.PasswordChar = '\0';
            this.txtidMaestro.SelectedText = "";
            this.txtidMaestro.SelectionLength = 0;
            this.txtidMaestro.SelectionStart = 0;
            this.txtidMaestro.Size = new System.Drawing.Size(210, 23);
            this.txtidMaestro.TabIndex = 33;
            this.txtidMaestro.TabStop = false;
            this.txtidMaestro.UseSystemPasswordChar = false;
            // 
            // FormularioParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 537);
            this.Controls.Add(this.txtidMaestro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtValorDeMedida);
            this.Controls.Add(this.txtUnidadDeMedida);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(197, 63);
            this.Name = "FormularioParametros";
            this.Text = "FormularioParametros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtConcepto;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtUnidadDeMedida;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtValorDeMedida;
        public MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        public MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        public MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtidMaestro;
    }
}