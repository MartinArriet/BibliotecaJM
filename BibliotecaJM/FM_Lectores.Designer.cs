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
            this.eliminar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bBuscarNombre = new System.Windows.Forms.Button();
            this.bBuscarId = new System.Windows.Forms.Button();
            this.tbNombreBuscar = new System.Windows.Forms.TextBox();
            this.tbIdBuscar = new System.Windows.Forms.TextBox();
            this.lectoresDataGridView = new System.Windows.Forms.DataGridView();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            this.ficha.SuspendLayout();
            this.lectores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.ficha.Location = new System.Drawing.Point(427, 50);
            this.ficha.Name = "ficha";
            this.ficha.Size = new System.Drawing.Size(447, 521);
            this.ficha.TabIndex = 1;
            this.ficha.TabStop = false;
            this.ficha.Text = "Fichar Lector";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(327, 477);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(86, 37);
            this.cancelar.TabIndex = 8;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(219, 477);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(87, 37);
            this.aceptar.TabIndex = 8;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Location = new System.Drawing.Point(25, 40);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(21, 13);
            id_lecLabel.TabIndex = 0;
            id_lecLabel.Text = "ID:";
            // 
            // id_lecTextBox
            // 
            this.id_lecTextBox.Location = new System.Drawing.Point(147, 37);
            this.id_lecTextBox.Name = "id_lecTextBox";
            this.id_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_lecTextBox.TabIndex = 1;
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(25, 66);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(47, 13);
            nombre_lecLabel.TabIndex = 2;
            nombre_lecLabel.Text = "Nombre:";
            // 
            // nombre_lecTextBox
            // 
            this.nombre_lecTextBox.Location = new System.Drawing.Point(147, 63);
            this.nombre_lecTextBox.Name = "nombre_lecTextBox";
            this.nombre_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombre_lecTextBox.TabIndex = 3;
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(25, 92);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(52, 13);
            domicilio_lecLabel.TabIndex = 4;
            domicilio_lecLabel.Text = "Domicilio:";
            // 
            // domicilio_lecTextBox
            // 
            this.domicilio_lecTextBox.Location = new System.Drawing.Point(147, 89);
            this.domicilio_lecTextBox.Name = "domicilio_lecTextBox";
            this.domicilio_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.domicilio_lecTextBox.TabIndex = 5;
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(25, 119);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(103, 13);
            fecha_penalizacion_lecLabel.TabIndex = 6;
            fecha_penalizacion_lecLabel.Text = "Fecha Penalizacion:";
            // 
            // fecha_penalizacion_lecDateTimePicker
            // 
            this.fecha_penalizacion_lecDateTimePicker.Location = new System.Drawing.Point(147, 115);
            this.fecha_penalizacion_lecDateTimePicker.Name = "fecha_penalizacion_lecDateTimePicker";
            this.fecha_penalizacion_lecDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_penalizacion_lecDateTimePicker.TabIndex = 7;
            // 
            // lectores
            // 
            this.lectores.Controls.Add(this.eliminar);
            this.lectores.Controls.Add(this.modificar);
            this.lectores.Controls.Add(this.nuevo);
            this.lectores.Controls.Add(this.label2);
            this.lectores.Controls.Add(this.label1);
            this.lectores.Controls.Add(this.bBuscarNombre);
            this.lectores.Controls.Add(this.bBuscarId);
            this.lectores.Controls.Add(this.tbNombreBuscar);
            this.lectores.Controls.Add(this.tbIdBuscar);
            this.lectores.Controls.Add(this.lectoresDataGridView);
            this.lectores.Location = new System.Drawing.Point(49, 50);
            this.lectores.Name = "lectores";
            this.lectores.Size = new System.Drawing.Size(342, 521);
            this.lectores.TabIndex = 2;
            this.lectores.TabStop = false;
            this.lectores.Text = "Buscar Letores";
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(230, 477);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(105, 37);
            this.eliminar.TabIndex = 5;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(116, 477);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(108, 37);
            this.modificar.TabIndex = 5;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            // 
            // nuevo
            // 
            this.nuevo.Location = new System.Drawing.Point(6, 477);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(104, 37);
            this.nuevo.TabIndex = 5;
            this.nuevo.Text = "Nuevo";
            this.nuevo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // bBuscarNombre
            // 
            this.bBuscarNombre.Location = new System.Drawing.Point(225, 66);
            this.bBuscarNombre.Name = "bBuscarNombre";
            this.bBuscarNombre.Size = new System.Drawing.Size(75, 23);
            this.bBuscarNombre.TabIndex = 3;
            this.bBuscarNombre.Text = "Buscar";
            this.bBuscarNombre.UseVisualStyleBackColor = true;
            // 
            // bBuscarId
            // 
            this.bBuscarId.Location = new System.Drawing.Point(225, 26);
            this.bBuscarId.Name = "bBuscarId";
            this.bBuscarId.Size = new System.Drawing.Size(75, 23);
            this.bBuscarId.TabIndex = 3;
            this.bBuscarId.Text = "Buscar";
            this.bBuscarId.UseVisualStyleBackColor = true;
            // 
            // tbNombreBuscar
            // 
            this.tbNombreBuscar.Location = new System.Drawing.Point(80, 66);
            this.tbNombreBuscar.Name = "tbNombreBuscar";
            this.tbNombreBuscar.Size = new System.Drawing.Size(119, 20);
            this.tbNombreBuscar.TabIndex = 2;
            // 
            // tbIdBuscar
            // 
            this.tbIdBuscar.Location = new System.Drawing.Point(80, 28);
            this.tbIdBuscar.Name = "tbIdBuscar";
            this.tbIdBuscar.Size = new System.Drawing.Size(119, 20);
            this.tbIdBuscar.TabIndex = 1;
            // 
            // lectoresDataGridView
            // 
            this.lectoresDataGridView.AllowUserToAddRows = false;
            this.lectoresDataGridView.AllowUserToDeleteRows = false;
            this.lectoresDataGridView.AllowUserToResizeRows = false;
            this.lectoresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lectoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectoresDataGridView.Location = new System.Drawing.Point(0, 115);
            this.lectoresDataGridView.MultiSelect = false;
            this.lectoresDataGridView.Name = "lectoresDataGridView";
            this.lectoresDataGridView.ReadOnly = true;
            this.lectoresDataGridView.RowHeadersVisible = false;
            this.lectoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lectoresDataGridView.Size = new System.Drawing.Size(341, 356);
            this.lectoresDataGridView.TabIndex = 0;
            // 
            // FM_Lectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.ficha);
            this.Controls.Add(this.lectores);
            this.Name = "FM_Lectores";
            this.ficha.ResumeLayout(false);
            this.ficha.PerformLayout();
            this.lectores.ResumeLayout(false);
            this.lectores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView lectoresDataGridView;
    }
}
