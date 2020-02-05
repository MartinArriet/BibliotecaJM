using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Lectores : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Lectores()
        {
            InitializeComponent();
        }

        public FM_Lectores(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
        }

        // metodos para desabilitar los botones al arrancar en modo busqueda o modo edicion
        private void ModoBusqueda()
        {
            lectores.Enabled = true;
            ficha.Enabled = false;
        }
        private void ModoEdicion()
        {
            lectores.Enabled = false;
            ficha.Enabled = true;
        }

        private void bBuscarId_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (tbIdBuscar.Text == "")
                return;
            this.lectoresTableAdapter.FillByIDorNombre(this.dS_Lectores.lectores, int.TryParse(tbIdBuscar.Text, out i) ? i : 0,"");


        }

        private void bBuscarNombre_Click(object sender, EventArgs e)
        {
            if (tbIdBuscar.Text == "")
                return;
            this.lectoresTableAdapter.FillByIDorNombre(this.dS_Lectores.lectores, -1,tbNombreBuscar.Text);
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            this.lectoresBindingSource.AddNew();
            ModoEdicion();
            this.nombre_lecTextBox.Focus();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            ModoEdicion();
            this.dSLectoresBindingSource.EndEdit();
            //
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(",Desea eliminar el lector?", "Confirmar", MessageBoxButtons.YesNo))
            {
                try
                {
                    dSLectoresBindingSource.RemoveCurrent();
                    this.lectoresTableAdapter.Update(this.dS_Lectores.lectores);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se a podido borrar los datos. Error" + ex);
                }
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            dSLectoresBindingSource.CancelEdit();
            ModoBusqueda();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                dSLectoresBindingSource.EndEdit();
                this.lectoresTableAdapter.Update(this.dS_Lectores.lectores);

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se a podido actualizar los datos Error: " + ex);

            }
            finally
            {
                ModoBusqueda();
            }

        }

        private void FM_Lectores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Lectores.lectores' Puede moverla o quitarla según sea necesario.
            this.lectoresTableAdapter.Fill(this.dS_Lectores.lectores);

        }
    }
}
