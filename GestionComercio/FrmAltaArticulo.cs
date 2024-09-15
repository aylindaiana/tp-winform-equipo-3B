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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionComercio
{
    public partial class FrmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private List<Imagen> imagenesArt = null;


        public FrmAltaArticulo()
        {
            InitializeComponent();
            //agregar articulo
            lblTitulo.Text = "Agregar Articulo: ";

            btnModificarUrlImagen.Enabled = false;
            btnModificarUrlImagen.Visible = false;
        }

        public FrmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            //modifica articulo
            this.articulo = articulo;
            lblTitulo.Text = "Modificar Articulo: ";

            btnModificarUrlImagen.Enabled = true;
            btnModificarUrlImagen.Visible = true;
        }

        private void FrmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaManager marcas = new MarcaManager();
            CategoriaManager categorias = new CategoriaManager();
            imagenesArt = new List<Imagen>();

            try
            {
                cboMarca.DataSource = marcas.Listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categorias.Listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                    cargarDatosArticulo();

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
            if (validarFiltro() != true)
                return;


            if (articulo == null) articulo = new Articulo();

            try
            {
                obtenerDatosCargados();


                if (articulo.Id != 0)
                {
                    modificarArt();
                }
                else
                {
                    crearNuevoArt();
                }


                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnNuevaImagen_Click(object sender, EventArgs e)
        {
            Imagen nuevaImagen = new Imagen();

            nuevaImagen.ImagenUrl = txtUrlImagen.Text;
            imagenesArt.Add(nuevaImagen);

            txtUrlImagen.TextChanged -= txtUrlImagen_TextChanged;
            txtUrlImagen.Clear();
            txtUrlImagen.TextChanged += txtUrlImagen_TextChanged;

            try
            {
                CargarImagen(nuevaImagen.ImagenUrl);
                CargarCbx();

                MessageBox.Show("se agrego correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cmbImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbImagenes.DataSource != null)
                CargarImagen(cmbImagenes.SelectedItem.ToString());
        }

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            CargarImagen(txtUrlImagen.Text);
        }

        private void btnModificarUrlImagen_Click(object sender, EventArgs e)
        {

            int index = imagenesArt.FindIndex(x => x.ImagenUrl == cmbImagenes.SelectedItem.ToString());

            if (index != -1)
            {
                imagenesArt[index].ImagenUrl = txtUrlImagen.Text;
            }
            else
            {   
                Imagen aux = new Imagen();
                aux.ImagenUrl = txtUrlImagen.Text;
                imagenesArt.Add(aux);
                index = 0;
            }
 
            
            txtUrlImagen.TextChanged -= txtUrlImagen_TextChanged;
            txtUrlImagen.Clear();
            txtUrlImagen.TextChanged += txtUrlImagen_TextChanged;

            try
            {    
                CargarImagen(imagenesArt[index].ImagenUrl);   
                CargarCbx();

                MessageBox.Show("se Modifico correctamente");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }





        private bool validarFiltro()
        {
            bool correcto = true;
            decimal precio;

            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                lblValidacionPrecio.ForeColor = Color.Red;
                lblValidacionPrecio.Text = "*";
                lblValidacionPrecio.Visible = true;
                lblValidacionPrecio.Font = new Font(lblValidacionPrecio.Font.FontFamily, 14); // el 14 es el tamaño que le puse al *

                MessageBox.Show("Precio Invalido, Ingrese uno correcto");
                correcto = false;
            }
            else if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                lblValidacionPrecio.ForeColor = Color.Red;
                lblValidacionPrecio.Text = "*";
                lblValidacionPrecio.Visible = true;
                lblValidacionPrecio.Font = new Font(lblValidacionPrecio.Font.FontFamily, 14);

                MessageBox.Show("El campo PRECIO debe completarse");
                correcto = false;
            }
            else
            {
                lblValidacionPrecio.ForeColor = Color.DarkGray;
                lblValidacionPrecio.Visible = false;
            }

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                lblValidacionCodigo.ForeColor = Color.Red;
                lblValidacionCodigo.Text = "*";
                lblValidacionCodigo.Visible = true;
                lblValidacionCodigo.Font = new Font(lblValidacionCodigo.Font.FontFamily, 14);

                MessageBox.Show("El campo CODIGO debe completarse");
                correcto = false;
            }
            else
            {
                lblValidacionCodigo.ForeColor = Color.DarkGray;
                lblValidacionCodigo.Visible = false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                lblValidacionNombre.ForeColor = Color.Red;
                lblValidacionNombre.Text = "*";
                lblValidacionNombre.Visible = true;
                lblValidacionNombre.Font = new Font(lblValidacionNombre.Font.FontFamily, 14);

                MessageBox.Show("El campo NOMBRE debe completarse");
                correcto = false;
            }
            else if (soloNumeros(txtNombre.Text))
            {
                lblValidacionNombre.ForeColor = Color.Red;
                lblValidacionNombre.Text = "*";
                lblValidacionNombre.Visible = true;
                lblValidacionNombre.Font = new Font(lblValidacionNombre.Font.FontFamily, 14);

                MessageBox.Show("Ingrese un nombre correcto que NO lleve Numeros");
                correcto = false;
            }
            else
            {
                lblValidacionNombre.ForeColor = Color.DarkGray;
                lblValidacionNombre.Visible = false;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                lblValidacionDescripcion.ForeColor = Color.Red;
                lblValidacionDescripcion.Text = "*";
                lblValidacionDescripcion.Visible = true;
                lblValidacionDescripcion.Font = new Font(lblValidacionDescripcion.Font.FontFamily, 14); // Ajusta el tamaño según sea necesario

                MessageBox.Show("El campo DESCRIPCION debe completarse");
                correcto = false;
            }
            else if (soloNumeros(txtDescripcion.Text))
            {
                lblValidacionDescripcion.ForeColor = Color.Red;
                lblValidacionDescripcion.Text = "*";
                lblValidacionDescripcion.Visible = true;
                lblValidacionDescripcion.Font = new Font(lblValidacionDescripcion.Font.FontFamily, 14); // Ajusta el tamaño según sea necesario

                MessageBox.Show("Ingrese una descripcion correcta que NO lleve Numeros");
                correcto = false;
            }
            else
            {
                lblValidacionDescripcion.ForeColor = Color.DarkGray;
                lblValidacionDescripcion.Visible = false;
            }


            return correcto;
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

        private void obtenerDatosCargados()
        {
            decimal precio;

            try
            {
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.TipoMarca = (Marca)cboMarca.SelectedItem;
                articulo.TipoCategoria = (Categoria)cboCategoria.SelectedItem;

                //nuevaImagen.ImagenUrl = txtUrlImagen.Text;

                if (decimal.TryParse(txtPrecio.Text, out precio))
                {
                    articulo.Precio = precio;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cargarDatosArticulo()
        {
            ImagenManager imagenes = new ImagenManager();

            try
            {
                txtCodigo.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                cboMarca.SelectedValue = articulo.TipoMarca.Id;
                cboCategoria.SelectedValue = articulo.TipoCategoria.Id;
                txtPrecio.Text = articulo.Precio.ToString();

                imagenesArt = new List<Imagen>(imagenes.ListarPorArticuloId(articulo.Id));

                if (imagenesArt.Count != 0)
                {
                    txtUrlImagen.Text = imagenesArt[0].ImagenUrl;
                    CargarCbx();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void modificarArt()
        {
            ArticuloManager articuloManager = new ArticuloManager();
            ImagenManager imagenManager = new ImagenManager();

            articuloManager.modificar(articulo);

            foreach (Imagen item in imagenesArt)
            {
                item.IdArticulo = articulo.Id;

                if (item.Id != 0)
                {
                    imagenManager.modificar(item);
                }
                else
                {
                    imagenManager.Agregar(item.ImagenUrl,articulo.Id);
                }
                        
            }

            MessageBox.Show("Modificado Exitosamente!");
        }

        private void crearNuevoArt()
        {
            ArticuloManager articuloManager = new ArticuloManager();
            ImagenManager imagenManager = new ImagenManager();

            articuloManager.Agregar(articulo);
            //hay que agregar una lista

            foreach (Imagen item in imagenesArt)
            {
                imagenManager.Agregar(item.ImagenUrl);
            }

            MessageBox.Show("Agregado Exitosamente!");
        }

        private void CargarCbx()
        {
            cmbImagenes.DataSource = null;

            cmbImagenes.DataSource = imagenesArt;
            cmbImagenes.ValueMember = "Id";
            cmbImagenes.DisplayMember = "ImagenUrl";
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbxAgregado.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxAgregado.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");

                if (!string.IsNullOrWhiteSpace(txtUrlImagen.Text))
                    MessageBox.Show(ex.ToString());
            }
        }

    }
}
