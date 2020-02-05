namespace BibliotecaJM
{
    partial class FM_Lectores
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_lecLabel;
            System.Windows.Forms.Label nombre_lecLabel;
            System.Windows.Forms.Label domicilio_lecLabel;
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            this.ficha = new System.Windows.Forms.GroupBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.id_lecTextBox = new System.Windows.Forms.TextBox();
            this.nombre_lecTextBox = new System.Windows.Forms.TextBox();
            this.domicilio_lecTextBox = new System.Windows.Forms.TextBox();
            this.fecha_penalizacion_lecDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lectores = new System.Windows.Forms.GroupBox();
            this.lectoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.eliminar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bBuscarNombre = new System.Windows.Forms.Button();
            this.bBuscarId = new System.Windows.Forms.Button();
            this.tbNombreBuscar = new System.Windows.Forms.TextBox();
            this.tbIdBuscar = new System.Windows.Forms.TextBox();
            this.dSLectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            this.ficha.SuspendLayout();
            this.lectores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLectoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Location = new System.Drawing.Point(63, 65);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(21, 13);
            id_lecLabel.TabIndex = 0;
            id_lecLabel.Text = "ID:";
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(63, 91);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(47, 13);
            nombre_lecLabel.TabIndex = 2;
            nombre_lecLabel.Text = "Nombre:";
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(63, 117);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(52, 13);
            domicilio_lecLabel.TabIndex = 4;
            domicilio_lecLabel.Text = "Domicilio:";
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(63, 144);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(103, 13);
            fecha_penalizacion_lecLabel.TabIndex = 6;
            fecha_penalizacion_lecLabel.Text = "Fecha Penalizacion:";
            // 
            // ficha
            // 
            this.ficha.Controls.Add(this.cancelar);
            this.ficha.Controls.Add(this.aceptar);
            this.ficha.Controls.Add(id_lecLabel);
            this.ficha.Controls.Add(this.id_lecTextBox);
            this.ficha.Controls.Add(nombre_lecLabel);
            this.ficha.Controls.Add(this.nombre_lecTextBox);
            this.ficha.Controls.Add(domicilio_lecLabel);
            this.ficha.Controls.Add(this.domicilio_lecTextBox);
            this.ficha.Controls.Add(fecha_penalizacion_lecLabel);
            this.ficha.Controls.Add(this.fecha_penalizacion_lecDateTimePicker);
            this.ficha.Location = new System.Drawing.Point(468, 30);
            this.ficha.Name = "ficha";
            this.ficha.Size = new System.Drawing.Size(498, 624);
            this.ficha.TabIndex = 1;
            this.ficha.TabStop = false;
            this.ficha.Text = "Fichar Lector";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(342, 529);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(102, 48);
            this.cancelar.TabIndex = 8;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(234, 529);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(103, 48);
            this.aceptar.TabIndex = 8;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // id_lecTextBox
            // 
            this.id_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "id_lec", true));
            this.id_lecTextBox.Location = new System.Drawing.Point(185, 62);
            this.id_lecTextBox.Name = "id_lecTextBox";
            this.id_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_lecTextBox.TabIndex = 1;
            // 
            // nombre_lecTextBox
            // 
            this.nombre_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "nombre_lec", true));
            this.nombre_lecTextBox.Location = new System.Drawing.Point(185, 88);
            this.nombre_lecTextBox.Name = "nombre_lecTextBox";
            this.nombre_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombre_lecTextBox.TabIndex = 3;
            // 
            // domicilio_lecTextBox
            // 
            this.domicilio_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "domicilio_lec", true));
            this.domicilio_lecTextBox.Location = new System.Drawing.Point(185, 114);
            this.domicilio_lecTextBox.Name = "domicilio_lecTextBox";
            this.domicilio_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.domicilio_lecTextBox.TabIndex = 5;
            // 
            // fecha_penalizacion_lecDateTimePicker
            // 
            this.fecha_penalizacion_lecDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "fecha_nacimiento_lec", true));
            this.fecha_penalizacion_lecDateTimePicker.Location = new System.Drawing.Point(185, 140);
            this.fecha_penalizacion_lecDateTimePicker.Name = "fecha_penalizacion_lecDateTimePicker";
            this.fecha_penalizacion_lecDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_penalizacion_lecDateTimePicker.TabIndex = 7;
            // 
            // lectores
            // 
            this.lectores.Controls.Add(this.lectoresDataGridView);
            this.lectores.Controls.Add(this.eliminar);
            this.lectores.Controls.Add(this.modificar);
            this.lectores.Controls.Add(this.nuevo);
            this.lectores.Controls.Add(this.label2);
            this.lectores.Controls.Add(this.label1);
            this.lectores.Controls.Add(this.bBuscarNombre);
            this.lectores.Controls.Add(this.bBuscarId);
            this.lectores.Controls.Add(this.tbNombreBuscar);
            this.lectores.Controls.Add(this.tbIdBuscar);
            this.lectores.Location = new System.Drawing.Point(29, 30);
            this.lectores.Name = "lectores";
            this.lectores.Size = new System.Drawing.Size(399, 624);
            this.lectores.TabIndex = 2;
            this.lectores.TabStop = false;
            this.lectores.Text = "Buscar Letores";
            // 
            // lectoresDataGridView
            // 
            this.lectoresDataGridView.AllowUserToAddRows = false;
            this.lectoresDataGridView.AllowUserToDeleteRows = false;
            this.lectoresDataGridView.AllowUserToResizeRows = false;
            this.lectoresDataGridView.AutoGenerateColumns = false;
            this.lectoresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lectoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.lectoresDataGridView.DataSource = this.lectoresBindingSource;
            this.lectoresDataGridView.Location = new System.Drawing.Point(0, 140);
            this.lectoresDataGridView.MultiSelect = false;
            this.lectoresDataGridView.Name = "lectoresDataGridView";
            this.lectoresDataGridView.ReadOnly = true;
            this.lectoresDataGridView.RowHeadersVisible = false;
            this.lectoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lectoresDataGridView.Size = new System.Drawing.Size(399, 388);
            this.lectoresDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lec";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_lec";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataMember = "lectores";
            this.lectoresBindingSource.DataSource = this.dS_Lectores;
            // 
            // dS_Lectores
            // 
            this.dS_Lectores.DataSetName = "DS_Lectores";
            this.dS_Lectores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(268, 563);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(105, 37);
            this.eliminar.TabIndex = 5;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(145, 563);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(108, 37);
            this.modificar.TabIndex = 5;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // nuevo
            // 
            this.nuevo.Location = new System.Drawing.Point(24, 563);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(104, 37);
            this.nuevo.TabIndex = 5;
            this.nuevo.Text = "Nuevo";
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // bBuscarNombre
            // 
            this.bBuscarNombre.Location = new System.Drawing.Point(283, 79);
            this.bBuscarNombre.Name = "bBuscarNombre";
            this.bBuscarNombre.Size = new System.Drawing.Size(75, 23);
            this.bBuscarNombre.TabIndex = 3;
            this.bBuscarNombre.Text = "Buscar";
            this.bBuscarNombre.UseVisualStyleBackColor = true;
            this.bBuscarNombre.Click += new System.EventHandler(this.bBuscarNombre_Click);
            // 
            // bBuscarId
            // 
            this.bBuscarId.Location = new System.Drawing.Point(283, 39);
            this.bBuscarId.Name = "bBuscarId";
            this.bBuscarId.Size = new System.Drawing.Size(75, 23);
            this.bBuscarId.TabIndex = 3;
            this.bBuscarId.Text = "Buscar";
            this.bBuscarId.UseVisualStyleBackColor = true;
            this.bBuscarId.Click += new System.EventHandler(this.bBuscarId_Click);
            // 
            // tbNombreBuscar
            // 
            this.tbNombreBuscar.Location = new System.Drawing.Point(90, 79);
            this.tbNombreBuscar.Name = "tbNombreBuscar";
            this.tbNombreBuscar.Size = new System.Drawing.Size(163, 20);
            this.tbNombreBuscar.TabIndex = 2;
            // 
            // tbIdBuscar
            // 
            this.tbIdBuscar.Location = new System.Drawing.Point(90, 41);
            this.tbIdBuscar.Name = "tbIdBuscar";
            this.tbIdBuscar.Size = new System.Drawing.Size(163, 20);
            this.tbIdBuscar.TabIndex = 1;
            // 
            // dSLectoresBindingSource
            // 
            this.dSLectoresBindingSource.DataSource = this.dS_Lectores;
            this.dSLectoresBindingSource.Position = 0;
            // 
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // FM_Lectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.ficha);
            this.Controls.Add(this.lectores);
            this.Name = "FM_Lectores";
            this.Load += new System.EventHandler(this.FM_Lectores_Load);
            this.ficha.ResumeLayout(false);
            this.ficha.PerformLayout();
            this.lectores.ResumeLayout(false);
            this.lectores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLectoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ficha;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.TextBox id_lecTextBox;
        private System.Windows.Forms.TextBox nombre_lecTextBox;
        private System.Windows.Forms.TextBox domicilio_lecTextBox;
        private System.Windows.Forms.DateTimePicker fecha_penalizacion_lecDateTimePicker;
        private System.Windows.Forms.GroupBox lectores;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bBuscarNombre;
        private System.Windows.Forms.Button bBuscarId;
        private System.Windows.Forms.TextBox tbNombreBuscar;
        private System.Windows.Forms.TextBox tbIdBuscar;
        private System.Windows.Forms.BindingSource dSLectoresBindingSource;
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private System.Windows.Forms.DataGridView lectoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
