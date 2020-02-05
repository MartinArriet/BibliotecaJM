using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Prestamos : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Prestamos()
        {
            InitializeComponent();
        }

        public FM_Prestamos(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
        }

        private void FM_Prestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Lectores.lectores' Puede moverla o quitarla según sea necesario.
            this.lectoresTableAdapter.Fill(this.dS_Lectores.lectores);
            // TODO: esta línea de código carga datos en la tabla 'dS_Libros.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.dS_Libros.libros);
            // TODO: esta línea de código carga datos en la tabla 'dS_LibrosPrestados.LibrosPrestados' Puede moverla o quitarla según sea necesario.
            //this.librosPrestadosTableAdapter.Fill(this.dS_LibrosPrestados.LibrosPrestados);

        }

        private void bBuscarIDprestamo_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(tbIdLectorPrestamo.Text) !=-1)
            {
                this.lectoresTableAdapter.FillByIDorNombre(this.dS_Lectores.lectores, Int32.Parse(tbIdLectorPrestamo.Text),null);
                //this.librosPrestadosTableAdapter.FillByID(this.dS_LibrosPrestados.LibrosPrestados,);
            }
        }

        private void bBuscarNombrePrestamo_Click(object sender, EventArgs e)
        {
            if (tbNombrePrestamo.Text !="")
            {
                this.lectoresTableAdapter.FillByIDorNombre(this.dS_Lectores.lectores, -1, tbNombrePrestamo.Text);
            }
        }
    }
}
