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
        List<Imagen> listaImagenes = new List<Imagen>();
        

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
            cargarDgv(); 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccion = new Articulo();

            if (dgvArticulos.RowCount != 0)
            {
                seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                FrmAltaArticulo modificar = new FrmAltaArticulo(seleccion);
                modificar.ShowDialog();
                cargarDgv();       
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
                cargaImagen(artSeleccionado.Id);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloManager ArtiManager = new ArticuloManager();
            Articulo ArtiSeleccionado = new Articulo();

            try
            {   
                //modificar

                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    ArtiSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    ArtiManager.eliminarLogico(ArtiSeleccionado.Id);
                    cargarDgv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BotonFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloManager ArtiManager = new ArticuloManager();
            try
            {
                if (validarFiltro()) //si hay q validar corta la ejecucion
                {
                    cargarDgv();
                    return; 
                }

                string campo = ComboBoxCampo.SelectedItem.ToString();
                string criterio = ComboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxFiltroAvanzado.Text;
                dgvArticulos.DataSource = ArtiManager.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFitro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;

            string texto = txtFitro.Text.ToString().ToLower();

            if (txtFitro.Text.Length >= 3)
                listaFiltrada = listaArticulos.FindAll(
                    x => x.Nombre.ToLower().Contains(texto) ||
                    x.Codigo.ToLower().Contains(texto) ||
                    x.TipoMarca.Descripcion.ToLower().Contains(texto)
                    );
            else
                listaFiltrada = listaArticulos;

            dgvArticulos.DataSource = null;
            
            if (listaFiltrada.Count != 0)
            {
                dgvArticulos.DataSource = listaFiltrada;
                cargaImagen(listaFiltrada[0].Id);
            }
        }

        private void ComboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = ComboBoxCampo.SelectedItem.ToString(); //capturo la seleccion
            if (opcion == "precio")
            {
                ComboBoxCriterio.Items.Clear();
                ComboBoxCriterio.Items.Add("Mayor a");
                ComboBoxCriterio.Items.Add("Menor a");
                ComboBoxCriterio.Items.Add("Igual a");
            }
            else
            {
                ComboBoxCriterio.Items.Clear();
                ComboBoxCriterio.Items.Add("Comienza con");
                ComboBoxCriterio.Items.Add("Termina con");
                ComboBoxCriterio.Items.Add("Contiene");
            }
        }

        private void cargaImagen(int IdArt) {

            try
            {
                Imagen nuevaImagen = listaImagenes.Find(x => x.IdArticulo == IdArt);
                if(nuevaImagen != null)
                    pbxArticulo.Load(nuevaImagen.ImagenUrl);
                else
                    pbxArticulo.Load("https://myemotos.cl/wp-content/uploads/2024/06/sin_imagen.jpg");
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://myemotos.cl/wp-content/uploads/2024/06/sin_imagen.jpg");

            }

        }

        private void cargarDgv()
        {
            ArticuloManager articulos = new ArticuloManager();
            ImagenManager imagenes = new ImagenManager();

            try
            {
                listaArticulos = articulos.listar();
                listaImagenes = imagenes.listar();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar datos...");
            }
            finally
            {
                dgvArticulos.DataSource = listaArticulos;
                ComboBoxCampo.Items.Clear();
                ComboBoxCampo.Items.Add("precio");
                ComboBoxCampo.Items.Add("nombre");
                ComboBoxCampo.Items.Add("categoría");
            }
        }

        private bool validarFiltro()
        {
            if (ComboBoxCampo.SelectedIndex < 0) //pregunto si campo no tiene nada seleccionado
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (ComboBoxCriterio.SelectedIndex < 0) //pregunto si criterio no tiene nada seleccionado
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (ComboBoxCampo.SelectedItem.ToString() == "precio")//pregunto si campo es precio
            {
                if (string.IsNullOrEmpty(textBoxFiltroAvanzado.Text))//si el filtro esta vacio o null
                {
                    MessageBox.Show("Debes cargar el filtro...");
                    return true;
                }
                if (!(soloNumeros(textBoxFiltroAvanzado.Text))) //por q esta en op numumerico
                {
                    MessageBox.Show("Solo nros para filtrar por un campo numerico...");
                    return true;
                }
            }
            if (ComboBoxCampo.SelectedItem.ToString() == "nombre" || ComboBoxCampo.SelectedItem.ToString() == "categoría")
            {
                if (string.IsNullOrEmpty(textBoxFiltroAvanzado.Text))//si el filtro esta vacio o null
                {
                    MessageBox.Show("Debes cargar el filtro...");
                    return true;
                }
                if ((soloNumeros(textBoxFiltroAvanzado.Text))) //por q esta en op text
                {
                    MessageBox.Show("Solo letras para filtrar por un campo de texto...");
                    return true;
                }
            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void tsmAgregarMarca_Click(object sender, EventArgs e)
        {
            FrmAddMarcaYCategoria frmMarcaCategoria = new FrmAddMarcaYCategoria();


            
        }

        private void tsmAgregarCategoria_Click(object sender, EventArgs e)
        {

        }
    }
    
}
