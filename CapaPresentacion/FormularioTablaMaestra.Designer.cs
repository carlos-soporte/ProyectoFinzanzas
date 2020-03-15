namespace CapaPresentacion
{
    partial class FormularioTablaMaestra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNit = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCedula = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPeriodos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtProveedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtVidaUtil = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtValor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dateFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.txtUnidadDeTiempo = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtResponsable = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdArea = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(328, 480);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 36);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(39, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(740, 156);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(-15, -15);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(75, 23);
            this.materialSingleLineTextField1.TabIndex = 2;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.Text = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(56, 209);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(210, 23);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TabStop = false;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtNit
            // 
            this.txtNit.Depth = 0;
            this.txtNit.Hint = "Nit";
            this.txtNit.Location = new System.Drawing.Point(296, 343);
            this.txtNit.MaxLength = 32767;
            this.txtNit.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNit.Name = "txtNit";
            this.txtNit.PasswordChar = '\0';
            this.txtNit.SelectedText = "";
            this.txtNit.SelectionLength = 0;
            this.txtNit.SelectionStart = 0;
            this.txtNit.Size = new System.Drawing.Size(210, 23);
            this.txtNit.TabIndex = 4;
            this.txtNit.TabStop = false;
            this.txtNit.UseSystemPasswordChar = false;
            // 
            // txtCedula
            // 
            this.txtCedula.Depth = 0;
            this.txtCedula.Hint = "Cedula";
            this.txtCedula.Location = new System.Drawing.Point(296, 404);
            this.txtCedula.MaxLength = 32767;
            this.txtCedula.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PasswordChar = '\0';
            this.txtCedula.SelectedText = "";
            this.txtCedula.SelectionLength = 0;
            this.txtCedula.SelectionStart = 0;
            this.txtCedula.Size = new System.Drawing.Size(210, 23);
            this.txtCedula.TabIndex = 5;
            this.txtCedula.TabStop = false;
            this.txtCedula.UseSystemPasswordChar = false;
            // 
            // txtPeriodos
            // 
            this.txtPeriodos.Depth = 0;
            this.txtPeriodos.Hint = "Periodos";
            this.txtPeriodos.Location = new System.Drawing.Point(544, 276);
            this.txtPeriodos.MaxLength = 32767;
            this.txtPeriodos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPeriodos.Name = "txtPeriodos";
            this.txtPeriodos.PasswordChar = '\0';
            this.txtPeriodos.SelectedText = "";
            this.txtPeriodos.SelectionLength = 0;
            this.txtPeriodos.SelectionStart = 0;
            this.txtPeriodos.Size = new System.Drawing.Size(210, 23);
            this.txtPeriodos.TabIndex = 7;
            this.txtPeriodos.TabStop = false;
            this.txtPeriodos.UseSystemPasswordChar = false;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Depth = 0;
            this.txtProveedor.Hint = "Proveedor";
            this.txtProveedor.Location = new System.Drawing.Point(544, 343);
            this.txtProveedor.MaxLength = 32767;
            this.txtProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.PasswordChar = '\0';
            this.txtProveedor.SelectedText = "";
            this.txtProveedor.SelectionLength = 0;
            this.txtProveedor.SelectionStart = 0;
            this.txtProveedor.Size = new System.Drawing.Size(210, 23);
            this.txtProveedor.TabIndex = 8;
            this.txtProveedor.TabStop = false;
            this.txtProveedor.UseSystemPasswordChar = false;
            // 
            // txtVidaUtil
            // 
            this.txtVidaUtil.Depth = 0;
            this.txtVidaUtil.Hint = "Vida Util";
            this.txtVidaUtil.Location = new System.Drawing.Point(544, 209);
            this.txtVidaUtil.MaxLength = 32767;
            this.txtVidaUtil.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtVidaUtil.Name = "txtVidaUtil";
            this.txtVidaUtil.PasswordChar = '\0';
            this.txtVidaUtil.SelectedText = "";
            this.txtVidaUtil.SelectionLength = 0;
            this.txtVidaUtil.SelectionStart = 0;
            this.txtVidaUtil.Size = new System.Drawing.Size(210, 23);
            this.txtVidaUtil.TabIndex = 9;
            this.txtVidaUtil.TabStop = false;
            this.txtVidaUtil.UseSystemPasswordChar = false;
            // 
            // txtValor
            // 
            this.txtValor.Depth = 0;
            this.txtValor.Hint = "Valor";
            this.txtValor.Location = new System.Drawing.Point(296, 209);
            this.txtValor.MaxLength = 32767;
            this.txtValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.Size = new System.Drawing.Size(210, 23);
            this.txtValor.TabIndex = 10;
            this.txtValor.TabStop = false;
            this.txtValor.UseSystemPasswordChar = false;
            // 
            // dateFechaInicial
            // 
            this.dateFechaInicial.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateFechaInicial.Location = new System.Drawing.Point(56, 279);
            this.dateFechaInicial.Name = "dateFechaInicial";
            this.dateFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dateFechaInicial.TabIndex = 11;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(109, 257);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(93, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Fecha Inicial";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(346, 257);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(85, 19);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "Fecha Final";
            // 
            // dateFechaFinal
            // 
            this.dateFechaFinal.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateFechaFinal.Location = new System.Drawing.Point(296, 279);
            this.dateFechaFinal.Name = "dateFechaFinal";
            this.dateFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dateFechaFinal.TabIndex = 14;
            // 
            // txtUnidadDeTiempo
            // 
            this.txtUnidadDeTiempo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtUnidadDeTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtUnidadDeTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidadDeTiempo.FormattingEnabled = true;
            this.txtUnidadDeTiempo.Items.AddRange(new object[] {
            "Año",
            "Mes",
            "Semestre"});
            this.txtUnidadDeTiempo.Location = new System.Drawing.Point(56, 343);
            this.txtUnidadDeTiempo.Name = "txtUnidadDeTiempo";
            this.txtUnidadDeTiempo.Size = new System.Drawing.Size(200, 24);
            this.txtUnidadDeTiempo.TabIndex = 16;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(85, 322);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(128, 18);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Unidad de Tiempo";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(303, 9);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(128, 19);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "TABLA MAESTRA";
            // 
            // txtResponsable
            // 
            this.txtResponsable.Depth = 0;
            this.txtResponsable.Hint = "Responsable";
            this.txtResponsable.Location = new System.Drawing.Point(56, 404);
            this.txtResponsable.MaxLength = 32767;
            this.txtResponsable.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.PasswordChar = '\0';
            this.txtResponsable.SelectedText = "";
            this.txtResponsable.SelectionLength = 0;
            this.txtResponsable.SelectionStart = 0;
            this.txtResponsable.Size = new System.Drawing.Size(210, 23);
            this.txtResponsable.TabIndex = 19;
            this.txtResponsable.TabStop = false;
            this.txtResponsable.UseSystemPasswordChar = false;
            // 
            // txtIdArea
            // 
            this.txtIdArea.Depth = 0;
            this.txtIdArea.Hint = "ID Area";
            this.txtIdArea.Location = new System.Drawing.Point(544, 404);
            this.txtIdArea.MaxLength = 32767;
            this.txtIdArea.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdArea.Name = "txtIdArea";
            this.txtIdArea.PasswordChar = '\0';
            this.txtIdArea.SelectedText = "";
            this.txtIdArea.SelectionLength = 0;
            this.txtIdArea.SelectionStart = 0;
            this.txtIdArea.Size = new System.Drawing.Size(210, 23);
            this.txtIdArea.TabIndex = 20;
            this.txtIdArea.TabStop = false;
            this.txtIdArea.UseSystemPasswordChar = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(336, 480);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(84, 36);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(337, 480);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(83, 36);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormularioTablaMaestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(803, 537);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtIdArea);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtUnidadDeTiempo);
            this.Controls.Add(this.dateFechaFinal);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dateFechaInicial);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtVidaUtil);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtPeriodos);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioTablaMaestra";
            this.Text = "FormularioTablaMaestra";
            this.Load += new System.EventHandler(this.FormularioTablaMaestra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        public MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtNit;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtCedula;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtPeriodos;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtProveedor;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtVidaUtil;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtValor;
        public System.Windows.Forms.DateTimePicker dateFechaInicial;
        public System.Windows.Forms.DateTimePicker dateFechaFinal;
        public System.Windows.Forms.ComboBox txtUnidadDeTiempo;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtResponsable;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtIdArea;
        public MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        public MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
    }
}