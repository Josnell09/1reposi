namespace proyecto1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.textBoxdaño = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textBoxnom = new System.Windows.Forms.TextBox();
            this.textBoxbien = new System.Windows.Forms.TextBox();
            this.textBoxries = new System.Windows.Forms.TextBox();
            this.lbDaño = new System.Windows.Forms.Label();
            this.lbRiesgo = new System.Windows.Forms.Label();
            this.lbBienoActivo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGuardar2 = new System.Windows.Forms.Button();
            this.dtgv_valores = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtgv_evaluacion = new System.Windows.Forms.DataGridView();
            this.Fase3Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fase3Riesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fase3Daño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarDeRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PdeRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuanDeRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dtgvClassification = new System.Windows.Forms.DataGridView();
            this.ActivoF4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RiesgoF4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ERF4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassF4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxAcesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxDaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_valores)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_evaluacion)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClassification)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, -4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 343);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSalir);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.textBoxdaño);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.textBoxnom);
            this.tabPage1.Controls.Add(this.textBoxbien);
            this.tabPage1.Controls.Add(this.textBoxries);
            this.tabPage1.Controls.Add(this.lbDaño);
            this.tabPage1.Controls.Add(this.lbRiesgo);
            this.tabPage1.Controls.Add(this.lbBienoActivo);
            this.tabPage1.Controls.Add(this.lbNombre);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fase1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(427, 107);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 31;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(461, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(338, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 26;
            // 
            // textBoxdaño
            // 
            this.textBoxdaño.Location = new System.Drawing.Point(338, 4);
            this.textBoxdaño.Name = "textBoxdaño";
            this.textBoxdaño.Size = new System.Drawing.Size(100, 21);
            this.textBoxdaño.TabIndex = 26;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(263, 109);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(182, 109);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textBoxnom
            // 
            this.textBoxnom.Location = new System.Drawing.Point(95, 5);
            this.textBoxnom.Name = "textBoxnom";
            this.textBoxnom.Size = new System.Drawing.Size(100, 21);
            this.textBoxnom.TabIndex = 22;
            // 
            // textBoxbien
            // 
            this.textBoxbien.Location = new System.Drawing.Point(95, 37);
            this.textBoxbien.Name = "textBoxbien";
            this.textBoxbien.Size = new System.Drawing.Size(100, 21);
            this.textBoxbien.TabIndex = 21;
            // 
            // textBoxries
            // 
            this.textBoxries.Location = new System.Drawing.Point(95, 70);
            this.textBoxries.Name = "textBoxries";
            this.textBoxries.Size = new System.Drawing.Size(100, 21);
            this.textBoxries.TabIndex = 20;
            // 
            // lbDaño
            // 
            this.lbDaño.AutoSize = true;
            this.lbDaño.Location = new System.Drawing.Point(298, 5);
            this.lbDaño.Name = "lbDaño";
            this.lbDaño.Size = new System.Drawing.Size(37, 15);
            this.lbDaño.TabIndex = 19;
            this.lbDaño.Text = "Daño";
            // 
            // lbRiesgo
            // 
            this.lbRiesgo.AutoSize = true;
            this.lbRiesgo.Location = new System.Drawing.Point(19, 73);
            this.lbRiesgo.Name = "lbRiesgo";
            this.lbRiesgo.Size = new System.Drawing.Size(46, 15);
            this.lbRiesgo.TabIndex = 18;
            this.lbRiesgo.Text = "Riesgo";
            // 
            // lbBienoActivo
            // 
            this.lbBienoActivo.AutoSize = true;
            this.lbBienoActivo.Location = new System.Drawing.Point(19, 37);
            this.lbBienoActivo.Name = "lbBienoActivo";
            this.lbBienoActivo.Size = new System.Drawing.Size(76, 15);
            this.lbBienoActivo.TabIndex = 17;
            this.lbBienoActivo.Text = "Bien o Activo";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(19, 5);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(52, 15);
            this.lbNombre.TabIndex = 16;
            this.lbNombre.Text = "Nombre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TxID,
            this.TxNombre,
            this.TxAcesor,
            this.TxRiesgo,
            this.TxDaño});
            this.dataGridView1.Location = new System.Drawing.Point(9, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(563, 150);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGuardar2);
            this.tabPage2.Controls.Add(this.dtgv_valores);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fase2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGuardar2
            // 
            this.btnGuardar2.Location = new System.Drawing.Point(7, 66);
            this.btnGuardar2.Name = "btnGuardar2";
            this.btnGuardar2.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar2.TabIndex = 1;
            this.btnGuardar2.Text = "Guardar";
            this.btnGuardar2.UseVisualStyleBackColor = true;
            this.btnGuardar2.Click += new System.EventHandler(this.btnGuardar2_Click);
            // 
            // dtgv_valores
            // 
            this.dtgv_valores.AllowUserToAddRows = false;
            this.dtgv_valores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_valores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.S,
            this.F,
            this.P,
            this.A,
            this.V,
            this.E});
            this.dtgv_valores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv_valores.Location = new System.Drawing.Point(3, 167);
            this.dtgv_valores.Name = "dtgv_valores";
            this.dtgv_valores.Size = new System.Drawing.Size(790, 145);
            this.dtgv_valores.TabIndex = 4;
            this.dtgv_valores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_valores_CellContentClick);
            this.dtgv_valores.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_valores_CellEndEdit);
            this.dtgv_valores.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dtgv_valores_CellValidating);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 150F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Bien o Activo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 144.6584F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Riesgo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 96;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 140.2071F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Daño";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 94;
            // 
            // S
            // 
            this.S.FillWeight = 72.39065F;
            this.S.HeaderText = "S";
            this.S.Name = "S";
            this.S.Width = 49;
            // 
            // F
            // 
            this.F.FillWeight = 68.24884F;
            this.F.HeaderText = "F";
            this.F.Name = "F";
            this.F.Width = 45;
            // 
            // P
            // 
            this.P.FillWeight = 76.18731F;
            this.P.HeaderText = "P";
            this.P.Name = "P";
            this.P.Width = 50;
            // 
            // A
            // 
            this.A.FillWeight = 79.66757F;
            this.A.HeaderText = "A";
            this.A.Name = "A";
            this.A.Width = 54;
            // 
            // V
            // 
            this.V.FillWeight = 82.85783F;
            this.V.HeaderText = "V";
            this.V.Name = "V";
            this.V.Width = 55;
            // 
            // E
            // 
            this.E.FillWeight = 85.78222F;
            this.E.HeaderText = "E";
            this.E.Name = "E";
            this.E.Width = 57;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dtgv_evaluacion);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(796, 315);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Fase3";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dtgv_evaluacion
            // 
            this.dtgv_evaluacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_evaluacion.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtgv_evaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_evaluacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fase3Activo,
            this.Fase3Riesgo,
            this.Fase3Daño,
            this.CarDeRiesgo,
            this.PdeRiesgo,
            this.CuanDeRiesgo});
            this.dtgv_evaluacion.Location = new System.Drawing.Point(0, 149);
            this.dtgv_evaluacion.Name = "dtgv_evaluacion";
            this.dtgv_evaluacion.RowHeadersWidth = 51;
            this.dtgv_evaluacion.RowTemplate.Height = 24;
            this.dtgv_evaluacion.Size = new System.Drawing.Size(664, 133);
            this.dtgv_evaluacion.TabIndex = 1;
            this.dtgv_evaluacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_evaluacion_CellContentClick);
            // 
            // Fase3Activo
            // 
            this.Fase3Activo.HeaderText = "Bien o Activo";
            this.Fase3Activo.MinimumWidth = 6;
            this.Fase3Activo.Name = "Fase3Activo";
            this.Fase3Activo.ReadOnly = true;
            // 
            // Fase3Riesgo
            // 
            this.Fase3Riesgo.HeaderText = "Riesgo";
            this.Fase3Riesgo.MinimumWidth = 6;
            this.Fase3Riesgo.Name = "Fase3Riesgo";
            this.Fase3Riesgo.ReadOnly = true;
            // 
            // Fase3Daño
            // 
            this.Fase3Daño.HeaderText = "Daño";
            this.Fase3Daño.MinimumWidth = 6;
            this.Fase3Daño.Name = "Fase3Daño";
            this.Fase3Daño.ReadOnly = true;
            // 
            // CarDeRiesgo
            // 
            this.CarDeRiesgo.HeaderText = "Carácter de Riesgo";
            this.CarDeRiesgo.MinimumWidth = 6;
            this.CarDeRiesgo.Name = "CarDeRiesgo";
            this.CarDeRiesgo.ReadOnly = true;
            // 
            // PdeRiesgo
            // 
            this.PdeRiesgo.HeaderText = "Prob. de Riesgo \"Pb\"";
            this.PdeRiesgo.MinimumWidth = 6;
            this.PdeRiesgo.Name = "PdeRiesgo";
            this.PdeRiesgo.ReadOnly = true;
            // 
            // CuanDeRiesgo
            // 
            this.CuanDeRiesgo.HeaderText = "Cuantificación de Riesgo \"ER\"";
            this.CuanDeRiesgo.MinimumWidth = 6;
            this.CuanDeRiesgo.Name = "CuanDeRiesgo";
            this.CuanDeRiesgo.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dtgvClassification);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(796, 315);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Fase4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dtgvClassification
            // 
            this.dtgvClassification.AllowUserToAddRows = false;
            this.dtgvClassification.AllowUserToDeleteRows = false;
            this.dtgvClassification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvClassification.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dtgvClassification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClassification.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActivoF4,
            this.RiesgoF4,
            this.ERF4,
            this.ClassF4});
            this.dtgvClassification.Location = new System.Drawing.Point(0, 122);
            this.dtgvClassification.Name = "dtgvClassification";
            this.dtgvClassification.ReadOnly = true;
            this.dtgvClassification.RowHeadersWidth = 51;
            this.dtgvClassification.RowTemplate.Height = 24;
            this.dtgvClassification.Size = new System.Drawing.Size(664, 160);
            this.dtgvClassification.TabIndex = 1;
            // 
            // ActivoF4
            // 
            this.ActivoF4.HeaderText = "Bien o Activo";
            this.ActivoF4.MinimumWidth = 6;
            this.ActivoF4.Name = "ActivoF4";
            this.ActivoF4.ReadOnly = true;
            // 
            // RiesgoF4
            // 
            this.RiesgoF4.HeaderText = "Riesgo";
            this.RiesgoF4.MinimumWidth = 6;
            this.RiesgoF4.Name = "RiesgoF4";
            this.RiesgoF4.ReadOnly = true;
            // 
            // ERF4
            // 
            this.ERF4.HeaderText = "ER";
            this.ERF4.MinimumWidth = 6;
            this.ERF4.Name = "ERF4";
            this.ERF4.ReadOnly = true;
            // 
            // ClassF4
            // 
            this.ClassF4.HeaderText = "Clasificación de Riesgo";
            this.ClassF4.MinimumWidth = 6;
            this.ClassF4.Name = "ClassF4";
            this.ClassF4.ReadOnly = true;
            // 
            // TxID
            // 
            this.TxID.HeaderText = "ID";
            this.TxID.Name = "TxID";
            this.TxID.Width = 50;
            // 
            // TxNombre
            // 
            this.TxNombre.HeaderText = "Nombre";
            this.TxNombre.Name = "TxNombre";
            // 
            // TxAcesor
            // 
            this.TxAcesor.HeaderText = "Bien o Activo";
            this.TxAcesor.Name = "TxAcesor";
            // 
            // TxRiesgo
            // 
            this.TxRiesgo.HeaderText = "Riesgo";
            this.TxRiesgo.Name = "TxRiesgo";
            // 
            // TxDaño
            // 
            this.TxDaño.HeaderText = "Daño";
            this.TxDaño.Name = "TxDaño";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 376);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_valores)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_evaluacion)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClassification)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxdaño;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textBoxnom;
        private System.Windows.Forms.TextBox textBoxbien;
        private System.Windows.Forms.TextBox textBoxries;
        private System.Windows.Forms.Label lbDaño;
        private System.Windows.Forms.Label lbRiesgo;
        private System.Windows.Forms.Label lbBienoActivo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dtgv_valores;
        private System.Windows.Forms.Button btnGuardar2;
        private System.Windows.Forms.DataGridView dtgv_evaluacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fase3Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fase3Riesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fase3Daño;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarDeRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PdeRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuanDeRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn S;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn V;
        private System.Windows.Forms.DataGridViewTextBoxColumn E;
        private System.Windows.Forms.DataGridView dtgvClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivoF4;
        private System.Windows.Forms.DataGridViewTextBoxColumn RiesgoF4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ERF4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassF4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxAcesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxDaño;
    }
}

