namespace BibliotecaJM
{
    partial class FM_Prestamos
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
            System.Windows.Forms.Label id_libLabel;
            System.Windows.Forms.Label titulo_libLabel;
            System.Windows.Forms.Label autor_libLabel;
            System.Windows.Forms.Label lbIdLector;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label lbNombre;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label lbDomicilio;
            System.Windows.Forms.Label domicilio_lecLabel;
            System.Windows.Forms.Label lbFechaPenalizacion;
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            System.Windows.Forms.Label id_lecLabel;
            System.Windows.Forms.Label nombre_lecLabel;
            this.librosPrestadosDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Prestamar = new System.Windows.Forms.Button();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.bBuscarAutor = new System.Windows.Forms.Button();
            this.bBuscarTitulo = new System.Windows.Forms.Button();
            this.bBuscarIdentificador = new System.Windows.Forms.Button();
            this.tbIdentificador = new System.Windows.Forms.TextBox();
            this.tbTituto = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.gbPrestamos = new System.Windows.Forms.GroupBox();
            this.bBuscarNombrePrestamo = new System.Windows.Forms.Button();
            this.bBuscarIDprestamo = new System.Windows.Forms.Button();
            this.tbIdLectorPrestamo = new System.Windows.Forms.TextBox();
            this.tbNombrePrestamo = new System.Windows.Forms.TextBox();
            this.dS_LibrosPrestados = new BibliotecaJM.DS_LibrosPrestados();
            this.dSLibrosPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosPrestadosTableAdapter = new BibliotecaJM.DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter();
            this.idlibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulolibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaprestapreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadevolpreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.idlibDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulolibDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorlibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestadosnlibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_libLabel = new System.Windows.Forms.Label();
            titulo_libLabel = new System.Windows.Forms.Label();
            autor_libLabel = new System.Windows.Forms.Label();
            lbIdLector = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lbNombre = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lbDomicilio = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            lbFechaPenalizacion = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            this.gbPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLibrosPrestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // librosPrestadosDataGridView
            // 
            this.librosPrestadosDataGridView.AllowUserToAddRows = false;
            this.librosPrestadosDataGridView.AllowUserToDeleteRows = false;
            this.librosPrestadosDataGridView.AllowUserToResizeRows = false;
            this.librosPrestadosDataGridView.AutoGenerateColumns = false;
            this.librosPrestadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.librosPrestadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosPrestadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlibDataGridViewTextBoxColumn,
            this.titulolibDataGridViewTextBoxColumn,
            this.fechaprestapreDataGridViewTextBoxColumn,
            this.fechadevolpreDataGridViewTextBoxColumn});
            this.librosPrestadosDataGridView.DataSource = this.librosPrestadosBindingSource;
            this.librosPrestadosDataGridView.Location = new System.Drawing.Point(23, 335);
            this.librosPrestadosDataGridView.Name = "librosPrestadosDataGridView";
            this.librosPrestadosDataGridView.ReadOnly = true;
            this.librosPrestadosDataGridView.RowHeadersVisible = false;
            this.librosPrestadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosPrestadosDataGridView.Size = new System.Drawing.Size(419, 353);
            this.librosPrestadosDataGridView.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Prestamar);
            this.groupBox1.Controls.Add(this.librosDataGridView);
            this.groupBox1.Controls.Add(this.bBuscarAutor);
            this.groupBox1.Controls.Add(this.bBuscarTitulo);
            this.groupBox1.Controls.Add(this.bBuscarIdentificador);
            this.groupBox1.Controls.Add(id_libLabel);
            this.groupBox1.Controls.Add(this.tbIdentificador);
            this.groupBox1.Controls.Add(titulo_libLabel);
            this.groupBox1.Controls.Add(this.tbTituto);
            this.groupBox1.Controls.Add(autor_libLabel);
            this.groupBox1.Controls.Add(this.tbAutor);
            this.groupBox1.Location = new System.Drawing.Point(460, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 666);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Libro";
            // 
            // Prestamar
            // 
            this.Prestamar.Location = new System.Drawing.Point(17, 615);
            this.Prestamar.Name = "Prestamar";
            this.Prestamar.Size = new System.Drawing.Size(489, 35);
            this.Prestamar.TabIndex = 10;
            this.Prestamar.Text = "REALIZAR PRESTAMO";
            this.Prestamar.UseVisualStyleBackColor = true;
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AllowUserToAddRows = false;
            this.librosDataGridView.AllowUserToDeleteRows = false;
            this.librosDataGridView.AllowUserToResizeRows = false;
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlibDataGridViewTextBoxColumn1,
            this.titulolibDataGridViewTextBoxColumn1,
            this.autorlibDataGridViewTextBoxColumn,
            this.prestadosnlibDataGridViewTextBoxColumn});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(17, 175);
            this.librosDataGridView.MultiSelect = false;
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.ReadOnly = true;
            this.librosDataGridView.RowHeadersVisible = false;
            this.librosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosDataGridView.Size = new System.Drawing.Size(489, 418);
            this.librosDataGridView.TabIndex = 9;
            // 
            // bBuscarAutor
            // 
            this.bBuscarAutor.Location = new System.Drawing.Point(392, 106);
            this.bBuscarAutor.Name = "bBuscarAutor";
            this.bBuscarAutor.Size = new System.Drawing.Size(75, 23);
            this.bBuscarAutor.TabIndex = 6;
            this.bBuscarAutor.Text = "Buscar";
            this.bBuscarAutor.UseVisualStyleBackColor = true;
            // 
            // bBuscarTitulo
            // 
            this.bBuscarTitulo.Location = new System.Drawing.Point(392, 67);
            this.bBuscarTitulo.Name = "bBuscarTitulo";
            this.bBuscarTitulo.Size = new System.Drawing.Size(75, 23);
            this.bBuscarTitulo.TabIndex = 6;
            this.bBuscarTitulo.Text = "Buscar";
            this.bBuscarTitulo.UseVisualStyleBackColor = true;
            // 
            // bBuscarIdentificador
            // 
            this.bBuscarIdentificador.Location = new System.Drawing.Point(392, 30);
            this.bBuscarIdentificador.Name = "bBuscarIdentificador";
            this.bBuscarIdentificador.Size = new System.Drawing.Size(75, 23);
            this.bBuscarIdentificador.TabIndex = 6;
            this.bBuscarIdentificador.Text = "Buscar";
            this.bBuscarIdentificador.UseVisualStyleBackColor = true;
            // 
            // id_libLabel
            // 
            id_libLabel.AutoSize = true;
            id_libLabel.Location = new System.Drawing.Point(29, 33);
            id_libLabel.Name = "id_libLabel";
            id_libLabel.Size = new System.Drawing.Size(68, 13);
            id_libLabel.TabIndex = 0;
            id_libLabel.Text = "Identificador:";
            // 
            // tbIdentificador
            // 
            this.tbIdentificador.Location = new System.Drawing.Point(113, 30);
            this.tbIdentificador.Name = "tbIdentificador";
            this.tbIdentificador.Size = new System.Drawing.Size(262, 20);
            this.tbIdentificador.TabIndex = 1;
            // 
            // titulo_libLabel
            // 
            titulo_libLabel.AutoSize = true;
            titulo_libLabel.Location = new System.Drawing.Point(29, 70);
            titulo_libLabel.Name = "titulo_libLabel";
            titulo_libLabel.Size = new System.Drawing.Size(36, 13);
            titulo_libLabel.TabIndex = 2;
            titulo_libLabel.Text = "Titulo:";
            // 
            // tbTituto
            // 
            this.tbTituto.Location = new System.Drawing.Point(113, 67);
            this.tbTituto.Name = "tbTituto";
            this.tbTituto.Size = new System.Drawing.Size(262, 20);
            this.tbTituto.TabIndex = 3;
            // 
            // autor_libLabel
            // 
            autor_libLabel.AutoSize = true;
            autor_libLabel.Location = new System.Drawing.Point(29, 111);
            autor_libLabel.Name = "autor_libLabel";
            autor_libLabel.Size = new System.Drawing.Size(35, 13);
            autor_libLabel.TabIndex = 4;
            autor_libLabel.Text = "Autor:";
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(113, 108);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(262, 20);
            this.tbAutor.TabIndex = 5;
            // 
            // gbPrestamos
            // 
            this.gbPrestamos.Controls.Add(lbIdLector);
            this.gbPrestamos.Controls.Add(label1);
            this.gbPrestamos.Controls.Add(lbNombre);
            this.gbPrestamos.Controls.Add(label2);
            this.gbPrestamos.Controls.Add(lbDomicilio);
            this.gbPrestamos.Controls.Add(domicilio_lecLabel);
            this.gbPrestamos.Controls.Add(lbFechaPenalizacion);
            this.gbPrestamos.Controls.Add(fecha_penalizacion_lecLabel);
            this.gbPrestamos.Controls.Add(this.bBuscarNombrePrestamo);
            this.gbPrestamos.Controls.Add(this.bBuscarIDprestamo);
            this.gbPrestamos.Controls.Add(id_lecLabel);
            this.gbPrestamos.Controls.Add(this.tbIdLectorPrestamo);
            this.gbPrestamos.Controls.Add(nombre_lecLabel);
            this.gbPrestamos.Controls.Add(this.tbNombrePrestamo);
            this.gbPrestamos.Location = new System.Drawing.Point(23, 17);
            this.gbPrestamos.Name = "gbPrestamos";
            this.gbPrestamos.Size = new System.Drawing.Size(419, 297);
            this.gbPrestamos.TabIndex = 3;
            this.gbPrestamos.TabStop = false;
            this.gbPrestamos.Text = "Buscqueda Lector";
            // 
            // lbIdLector
            // 
            lbIdLector.AutoSize = true;
            lbIdLector.Location = new System.Drawing.Point(239, 156);
            lbIdLector.Name = "lbIdLector";
            lbIdLector.Size = new System.Drawing.Size(54, 13);
            lbIdLector.TabIndex = 7;
            lbIdLector.Text = "ID Lector:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(36, 156);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 13);
            label1.TabIndex = 7;
            label1.Text = "ID Lector:";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new System.Drawing.Point(239, 186);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new System.Drawing.Size(47, 13);
            lbNombre.TabIndex = 8;
            lbNombre.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(36, 186);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 13);
            label2.TabIndex = 8;
            label2.Text = "Nombre:";
            // 
            // lbDomicilio
            // 
            lbDomicilio.AutoSize = true;
            lbDomicilio.Location = new System.Drawing.Point(239, 216);
            lbDomicilio.Name = "lbDomicilio";
            lbDomicilio.Size = new System.Drawing.Size(52, 13);
            lbDomicilio.TabIndex = 4;
            lbDomicilio.Text = "Domicilio:";
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(36, 216);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(52, 13);
            domicilio_lecLabel.TabIndex = 4;
            domicilio_lecLabel.Text = "Domicilio:";
            // 
            // lbFechaPenalizacion
            // 
            lbFechaPenalizacion.AutoSize = true;
            lbFechaPenalizacion.Location = new System.Drawing.Point(239, 248);
            lbFechaPenalizacion.Name = "lbFechaPenalizacion";
            lbFechaPenalizacion.Size = new System.Drawing.Size(103, 13);
            lbFechaPenalizacion.TabIndex = 6;
            lbFechaPenalizacion.Text = "Fecha Penalizacion:";
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(36, 248);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(103, 13);
            fecha_penalizacion_lecLabel.TabIndex = 6;
            fecha_penalizacion_lecLabel.Text = "Fecha Penalizacion:";
            // 
            // bBuscarNombrePrestamo
            // 
            this.bBuscarNombrePrestamo.Location = new System.Drawing.Point(320, 74);
            this.bBuscarNombrePrestamo.Name = "bBuscarNombrePrestamo";
            this.bBuscarNombrePrestamo.Size = new System.Drawing.Size(75, 23);
            this.bBuscarNombrePrestamo.TabIndex = 4;
            this.bBuscarNombrePrestamo.Text = "Buscar";
            this.bBuscarNombrePrestamo.UseVisualStyleBackColor = true;
            // 
            // bBuscarIDprestamo
            // 
            this.bBuscarIDprestamo.Location = new System.Drawing.Point(320, 37);
            this.bBuscarIDprestamo.Name = "bBuscarIDprestamo";
            this.bBuscarIDprestamo.Size = new System.Drawing.Size(75, 23);
            this.bBuscarIDprestamo.TabIndex = 4;
            this.bBuscarIDprestamo.Text = "Buscar";
            this.bBuscarIDprestamo.UseVisualStyleBackColor = true;
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Location = new System.Drawing.Point(36, 40);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(54, 13);
            id_lecLabel.TabIndex = 0;
            id_lecLabel.Text = "ID Lector:";
            // 
            // tbIdLectorPrestamo
            // 
            this.tbIdLectorPrestamo.Location = new System.Drawing.Point(93, 37);
            this.tbIdLectorPrestamo.Name = "tbIdLectorPrestamo";
            this.tbIdLectorPrestamo.Size = new System.Drawing.Size(200, 20);
            this.tbIdLectorPrestamo.TabIndex = 1;
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(36, 77);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(47, 13);
            nombre_lecLabel.TabIndex = 2;
            nombre_lecLabel.Text = "Nombre:";
            // 
            // tbNombrePrestamo
            // 
            this.tbNombrePrestamo.Location = new System.Drawing.Point(93, 74);
            this.tbNombrePrestamo.Name = "tbNombrePrestamo";
            this.tbNombrePrestamo.Size = new System.Drawing.Size(200, 20);
            this.tbNombrePrestamo.TabIndex = 3;
            // 
            // dS_LibrosPrestados
            // 
            this.dS_LibrosPrestados.DataSetName = "DS_LibrosPrestados";
            this.dS_LibrosPrestados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSLibrosPrestadosBindingSource
            // 
            this.dSLibrosPrestadosBindingSource.DataSource = this.dS_LibrosPrestados;
            this.dSLibrosPrestadosBindingSource.Position = 0;
            // 
            // librosPrestadosBindingSource
            // 
            this.librosPrestadosBindingSource.DataMember = "LibrosPrestados";
            this.librosPrestadosBindingSource.DataSource = this.dSLibrosPrestadosBindingSource;
            // 
            // librosPrestadosTableAdapter
            // 
            this.librosPrestadosTableAdapter.ClearBeforeFill = true;
            // 
            // idlibDataGridViewTextBoxColumn
            // 
            this.idlibDataGridViewTextBoxColumn.DataPropertyName = "id_lib";
            this.idlibDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idlibDataGridViewTextBoxColumn.Name = "idlibDataGridViewTextBoxColumn";
            this.idlibDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titulolibDataGridViewTextBoxColumn
            // 
            this.titulolibDataGridViewTextBoxColumn.DataPropertyName = "titulo_lib";
            this.titulolibDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.titulolibDataGridViewTextBoxColumn.Name = "titulolibDataGridViewTextBoxColumn";
            this.titulolibDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaprestapreDataGridViewTextBoxColumn
            // 
            this.fechaprestapreDataGridViewTextBoxColumn.DataPropertyName = "fecha_presta_pre";
            this.fechaprestapreDataGridViewTextBoxColumn.HeaderText = "Fecha Préstamo";
            this.fechaprestapreDataGridViewTextBoxColumn.Name = "fechaprestapreDataGridViewTextBoxColumn";
            this.fechaprestapreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechadevolpreDataGridViewTextBoxColumn
            // 
            this.fechadevolpreDataGridViewTextBoxColumn.DataPropertyName = "fecha_devol_pre";
            this.fechadevolpreDataGridViewTextBoxColumn.HeaderText = "Fecha Devolución";
            this.fechadevolpreDataGridViewTextBoxColumn.Name = "fechadevolpreDataGridViewTextBoxColumn";
            this.fechadevolpreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dS_Libros
            // 
            this.dS_Libros.DataSetName = "DS_Libros";
            this.dS_Libros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "libros";
            this.librosBindingSource.DataSource = this.dS_Libros;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // idlibDataGridViewTextBoxColumn1
            // 
            this.idlibDataGridViewTextBoxColumn1.DataPropertyName = "id_lib";
            this.idlibDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.idlibDataGridViewTextBoxColumn1.Name = "idlibDataGridViewTextBoxColumn1";
            this.idlibDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // titulolibDataGridViewTextBoxColumn1
            // 
            this.titulolibDataGridViewTextBoxColumn1.DataPropertyName = "titulo_lib";
            this.titulolibDataGridViewTextBoxColumn1.HeaderText = "Titulo";
            this.titulolibDataGridViewTextBoxColumn1.Name = "titulolibDataGridViewTextBoxColumn1";
            this.titulolibDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // autorlibDataGridViewTextBoxColumn
            // 
            this.autorlibDataGridViewTextBoxColumn.DataPropertyName = "autor_lib";
            this.autorlibDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorlibDataGridViewTextBoxColumn.Name = "autorlibDataGridViewTextBoxColumn";
            this.autorlibDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prestadosnlibDataGridViewTextBoxColumn
            // 
            this.prestadosnlibDataGridViewTextBoxColumn.DataPropertyName = "prestado_sn_lib";
            this.prestadosnlibDataGridViewTextBoxColumn.HeaderText = "Prestamos";
            this.prestadosnlibDataGridViewTextBoxColumn.Name = "prestadosnlibDataGridViewTextBoxColumn";
            this.prestadosnlibDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FM_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.librosPrestadosDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPrestamos);
            this.Name = "FM_Prestamos";
            this.Load += new System.EventHandler(this.FM_Prestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            this.gbPrestamos.ResumeLayout(false);
            this.gbPrestamos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLibrosPrestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView librosPrestadosDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Prestamar;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.Button bBuscarAutor;
        private System.Windows.Forms.Button bBuscarTitulo;
        private System.Windows.Forms.Button bBuscarIdentificador;
        private System.Windows.Forms.TextBox tbIdentificador;
        private System.Windows.Forms.TextBox tbTituto;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.GroupBox gbPrestamos;
        private System.Windows.Forms.Button bBuscarNombrePrestamo;
        private System.Windows.Forms.Button bBuscarIDprestamo;
        private System.Windows.Forms.TextBox tbIdLectorPrestamo;
        private System.Windows.Forms.TextBox tbNombrePrestamo;
        private System.Windows.Forms.BindingSource dSLibrosPrestadosBindingSource;
        private DS_LibrosPrestados dS_LibrosPrestados;
        private System.Windows.Forms.BindingSource librosPrestadosBindingSource;
        private DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter librosPrestadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulolibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaprestapreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadevolpreDataGridViewTextBoxColumn;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlibDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulolibDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorlibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prestadosnlibDataGridViewTextBoxColumn;
    }
}
