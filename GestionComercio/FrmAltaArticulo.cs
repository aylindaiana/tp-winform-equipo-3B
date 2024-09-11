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
    public partial class FrmAltaArticulo : Form
    {
        private Articulo articulo = null; //para saber si es agregar un articulo nuevo
        private OpenFileDialog archivo = null;

        Imagen img = new Imagen();
        Articulo arti = new Articulo();


        public FrmAltaArticulo()
        {
            InitializeComponent();
            //agregar articulo
            lblTitulo.Text = "Agregar Articulo: ";
        }

        public FrmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            //modifica articulo
            this.articulo = articulo;
            lblTitulo.Text = "Modificar Articulo: ";        
        }

        private void FrmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaManager marcas = new MarcaManager();
            CategoriaManager categorias = new CategoriaManager();
            //ImagenManager imagen = new ImagenManager();

            try
            {
                cboMarca.DataSource = marcas.Listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categorias.Listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";


               

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    cboMarca.SelectedValue = articulo.TipoMarca.Id;
                    cboCategoria.SelectedValue = articulo.TipoCategoria.Id;
                    img.Id = articulo.Id;
                    txtUrlImagen.Text = img.ImagenUrl;


                    //CargarImagen(img.ImagenUrl);
                    txtPrecio.Text = articulo.Precio.ToString();
                }
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
         
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloManager articuloManager = new ArticuloManager();

            try
            {
                if(articulo ==null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.TipoMarca = (Marca)cboMarca.SelectedItem;
                articulo.TipoCategoria = (Categoria)cboCategoria.SelectedItem;
                decimal precio;
                if (decimal.TryParse(txtPrecio.Text, out precio))
                {
                    articulo.Precio = precio;
                }


                if (articulo.Id != 0)
                {
                    articuloManager.modificar(articulo);
                    MessageBox.Show("Modificado Exitosamente!");
                }else
                {
                    articuloManager.Agregar(articulo);
                    MessageBox.Show("Agregado Exitosamente!");
                }
                

                Close();                

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
                pbxAgregado.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxAgregado.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            CargarImagen(txtUrlImagen.Text);
        }
    }
}
