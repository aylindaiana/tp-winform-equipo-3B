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
            ArticuloManager articulos = new ArticuloManager();
            listaArticulos = articulos.listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            cargaImagen(listaArticulos[0].ImagenUrl);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo alta = new FrmAltaArticulo();
            alta.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccion = new Articulo();
            seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            FrmAltaArticulo modificar = new FrmAltaArticulo(seleccion);
            modificar.ShowDialog();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargaImagen(artSeleccionado.ImagenUrl);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            DialogResult dResult = MessageBox.Show("Esta seguro que desea eliminar el Articulo:  (" + artSeleccionado.Codigo + ") " + artSeleccionado.Nombre, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            if (dResult == DialogResult.OK) 
            {
                //baja en DB

                MessageBox.Show("Eliminacion exitosa");
            }
              
        }

        private void cargaImagen(string url) {

            try
            {
                pbxArticulo.Load(url);
            }
            catch (Exception ex)
            {

                pbxArticulo.Load("https://myemotos.cl/wp-content/uploads/2024/06/sin_imagen.jpg");
            }

        }

    }
}
