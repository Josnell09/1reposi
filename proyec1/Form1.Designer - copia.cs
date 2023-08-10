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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbBienoActivo = new System.Windows.Forms.Label();
            this.lbRiesgo = new System.Windows.Forms.Label();
            this.lbDaño = new System.Windows.Forms.Label();
            this.textBoxries = new System.Windows.Forms.TextBox();
            this.textBoxbien = new System.Windows.Forms.TextBox();
            this.textBoxnom = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBoxdaño = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.TxID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxAcesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxDaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TxID,
            this.TxNombre,
            this.TxAcesor,
            this.TxRiesgo,
            this.TxDaño,
            this.BtEditar});
            this.dataGridView1.Location = new System.Drawing.Point(12, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(563, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(22, 24);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbBienoActivo
            // 
            this.lbBienoActivo.AutoSize = true;
            this.lbBienoActivo.Location = new System.Drawing.Point(22, 56);
            this.lbBienoActivo.Name = "lbBienoActivo";
            this.lbBienoActivo.Size = new System.Drawing.Size(70, 13);
            this.lbBienoActivo.TabIndex = 2;
            this.lbBienoActivo.Text = "Bien o Activo";
            // 
            // lbRiesgo
            // 
            this.lbRiesgo.AutoSize = true;
            this.lbRiesgo.Location = new System.Drawing.Point(22, 92);
            this.lbRiesgo.Name = "lbRiesgo";
            this.lbRiesgo.Size = new System.Drawing.Size(40, 13);
            this.lbRiesgo.TabIndex = 3;
            this.lbRiesgo.Text = "Riesgo";
            // 
            // lbDaño
            // 
            this.lbDaño.AutoSize = true;
            this.lbDaño.Location = new System.Drawing.Point(301, 24);
            this.lbDaño.Name = "lbDaño";
            this.lbDaño.Size = new System.Drawing.Size(33, 13);
            this.lbDaño.TabIndex = 4;
            this.lbDaño.Text = "Daño";
            // 
            // textBoxries
            // 
            this.textBoxries.Location = new System.Drawing.Point(98, 89);
            this.textBoxries.Name = "textBoxries";
            this.textBoxries.Size = new System.Drawing.Size(100, 20);
            this.textBoxries.TabIndex = 5;
            // 
            // textBoxbien
            // 
            this.textBoxbien.Location = new System.Drawing.Point(98, 56);
            this.textBoxbien.Name = "textBoxbien";
            this.textBoxbien.Size = new System.Drawing.Size(100, 20);
            this.textBoxbien.TabIndex = 5;
            // 
            // textBoxnom
            // 
            this.textBoxnom.Location = new System.Drawing.Point(98, 24);
            this.textBoxnom.Name = "textBoxnom";
            this.textBoxnom.Size = new System.Drawing.Size(100, 20);
            this.textBoxnom.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(185, 128);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(266, 128);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(104, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxdaño
            // 
            this.textBoxdaño.Location = new System.Drawing.Point(341, 23);
            this.textBoxdaño.Name = "textBoxdaño";
            this.textBoxdaño.Size = new System.Drawing.Size(100, 20);
            this.textBoxdaño.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(307, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(304, 49);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 13);
            this.lbID.TabIndex = 11;
            this.lbID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(341, 49);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 10;
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
            // BtEditar
            // 
            this.BtEditar.HeaderText = "Editar";
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Width = 50;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(348, 127);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(430, 126);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 319);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxdaño);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textBoxnom);
            this.Controls.Add(this.textBoxbien);
            this.Controls.Add(this.textBoxries);
            this.Controls.Add(this.lbDaño);
            this.Controls.Add(this.lbRiesgo);
            this.Controls.Add(this.lbBienoActivo);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbBienoActivo;
        private System.Windows.Forms.Label lbRiesgo;
        private System.Windows.Forms.Label lbDaño;
        private System.Windows.Forms.TextBox textBoxries;
        private System.Windows.Forms.TextBox textBoxbien;
        private System.Windows.Forms.TextBox textBoxnom;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBoxdaño;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxAcesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxDaño;
        private System.Windows.Forms.DataGridViewButtonColumn BtEditar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
    }
}

