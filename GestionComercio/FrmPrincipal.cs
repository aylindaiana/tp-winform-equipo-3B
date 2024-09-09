using Dominio;
using Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionComercio
{
    public partial class FrmPrincipal : Form
    {

        List<Articulo> listaArticulos = new List<Articulo>();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            cargarDgv();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo alta = new FrmAltaArticulo();
            alta.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccion = new Articulo();

            if (dgvArticulos.RowCount != 0)
            {
                seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                FrmAltaArticulo modificar = new FrmAltaArticulo(seleccion);
                modificar.ShowDialog();
            }
            else 
            { 
                MessageBox.Show("Agrege articulos antes de realizar una modificacion...", "Error al modificar el articulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.RowCount != 0)
            {
                Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargaImagen(artSeleccionado.ImagenUrl);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.RowCount != 0)
            {
                Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                DialogResult dResult = MessageBox.Show("Esta seguro que desea eliminar el Articulo:  (" + artSeleccionado.Codigo + ") " + artSeleccionado.Nombre, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                if (dResult == DialogResult.OK)
                {
                    //baja en DB

                    MessageBox.Show("Eliminacion exitosa");
                }
            }
            else 
            { 
                MessageBox.Show("Agrege articulos antes de realizar una Eliminacion...", "Error al Eliminar el articulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
        }

        private void cargaImagen(string url) {

            try
            {
                pbxArticulo.Load(url);
            }
            catch (Exception)
            {

                pbxArticulo.Load("https://myemotos.cl/wp-content/uploads/2024/06/sin_imagen.jpg");
            }

        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            if (dgvArticulos.RowCount != 0)
                cargaImagen(listaArticulos[0].ImagenUrl);
        }

        private void cargarDgv()
        {
            ArticuloManager articulos = new ArticuloManager();

            try
            {
                listaArticulos = articulos.listar();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar datos...");
            }
            finally
            {
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
            }
        }

        private void txtFitro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;

            if (txtFitro.Text.Length >= 3)
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(txtFitro.Text.ToString().ToLower()));
            else 
                listaFiltrada = listaArticulos;

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
            cargaImagen(listaFiltrada[0].ImagenUrl);

        }
    }
}
