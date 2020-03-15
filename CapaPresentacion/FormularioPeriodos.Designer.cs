namespace CapaPresentacion
{
    partial class FormularioPeriodos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtValor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAño = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNumeroAño = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtidParametro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(359, 465);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(83, 36);
            this.btnEliminar.TabIndex = 40;
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
            this.btnGuardar.Location = new System.Drawing.Point(359, 465);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(84, 36);
            this.btnGuardar.TabIndex = 39;
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
            this.btnActualizar.Location = new System.Drawing.Point(348, 465);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 36);
            this.btnActualizar.TabIndex = 38;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Depth = 0;
            this.txtValor.Hint = "Valor";
            this.txtValor.Location = new System.Drawing.Point(552, 340);
            this.txtValor.MaxLength = 32767;
            this.txtValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.Size = new System.Drawing.Size(210, 23);
            this.txtValor.TabIndex = 37;
            this.txtValor.TabStop = false;
            this.txtValor.UseSystemPasswordChar = false;
            // 
            // txtAño
            // 
            this.txtAño.Depth = 0;
            this.txtAño.Hint = "Año";
            this.txtAño.Location = new System.Drawing.Point(278, 340);
            this.txtAño.MaxLength = 32767;
            this.txtAño.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAño.Name = "txtAño";
            this.txtAño.PasswordChar = '\0';
            this.txtAño.SelectedText = "";
            this.txtAño.SelectionLength = 0;
            this.txtAño.SelectionStart = 0;
            this.txtAño.Size = new System.Drawing.Size(210, 23);
            this.txtAño.TabIndex = 36;
            this.txtAño.TabStop = false;
            this.txtAño.UseSystemPasswordChar = false;
            // 
            // txtNumeroAño
            // 
            this.txtNumeroAño.Depth = 0;
            this.txtNumeroAño.Hint = "Numero de Año";
            this.txtNumeroAño.Location = new System.Drawing.Point(31, 340);
            this.txtNumeroAño.MaxLength = 32767;
            this.txtNumeroAño.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumeroAño.Name = "txtNumeroAño";
            this.txtNumeroAño.PasswordChar = '\0';
            this.txtNumeroAño.SelectedText = "";
            this.txtNumeroAño.SelectionLength = 0;
            this.txtNumeroAño.SelectionStart = 0;
            this.txtNumeroAño.Size = new System.Drawing.Size(206, 23);
            this.txtNumeroAño.TabIndex = 35;
            this.txtNumeroAño.TabStop = false;
            this.txtNumeroAño.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(344, 36);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(69, 19);
            this.materialLabel4.TabIndex = 34;
            this.materialLabel4.Text = "Periodos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(31, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(740, 221);
            this.dataGridView1.TabIndex = 33;
            // 
            // txtidParametro
            // 
            this.txtidParametro.Depth = 0;
            this.txtidParametro.Hint = "id Paràmetro";
            this.txtidParametro.Location = new System.Drawing.Point(278, 416);
            this.txtidParametro.MaxLength = 32767;
            this.txtidParametro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtidParametro.Name = "txtidParametro";
            this.txtidParametro.PasswordChar = '\0';
            this.txtidParametro.SelectedText = "";
            this.txtidParametro.SelectionLength = 0;
            this.txtidParametro.SelectionStart = 0;
            this.txtidParametro.Size = new System.Drawing.Size(210, 23);
            this.txtidParametro.TabIndex = 41;
            this.txtidParametro.TabStop = false;
            this.txtidParametro.UseSystemPasswordChar = false;
            // 
            // FormularioPeriodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 537);
            this.Controls.Add(this.txtidParametro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtNumeroAño);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioPeriodos";
            this.Text = "FormularioPeriodos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        public MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        public MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtValor;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtAño;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtNumeroAño;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtidParametro;
    }
}