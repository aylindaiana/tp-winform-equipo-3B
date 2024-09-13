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
    public partial class FrmImagenNuevaModificar : Form
    {
        private Imagen nuevaImagen = new Imagen();
        private Articulo articulo = new Articulo();
        public FrmImagenNuevaModificar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ImagenManager manager = new ImagenManager();
            try
            {
                manager.Agregar(txtImagen.Text);
                cboImagenes.Items.Add(txtImagen.Text);
                txtImagen.Text = null;
                MessageBox.Show("se agrego correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
        public void CargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception)
            {

                pbxImagen.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }
        /*
        private void FrmImagenNuevaModificar_Load(object sender, EventArgs e)
        {
            ImagenManager imagenes = new ImagenManager();
            try
            {
                nuevaImagen = imagenes.BuscarImagen(articulo.Id);
                txtImagen.Text = nuevaImagen.ImagenUrl;
                CargarImagen(nuevaImagen.ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        */

        private void txtImagen_TextChanged(object sender, EventArgs e)
        {
            CargarImagen(txtImagen.Text);
        }

        private void cboImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {

              CargarImagen(cboImagenes.SelectedItem.ToString());
            
        }
    }
}
