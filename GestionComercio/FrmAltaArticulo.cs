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
        private Imagen nuevaImagen = new Imagen();

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
            

            if (articulo == null)
                articulo = new Articulo();

            try
            {
                obtenerDatosCargados();


                if (articulo.Id != 0)
                {
                    modificarArt();
                }else
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


        public void CargarImagen(string imagen)
        {
            try
            {
                pbxAgregado.Load(imagen);
            }
            catch (Exception)
            {

                pbxAgregado.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            CargarImagen(txtUrlImagen.Text);
        }

        private bool validarFiltro()
        {
            bool correcto = true;
            decimal precio;

            if(!decimal.TryParse(txtPrecio.Text,out precio))
            {
                lblValidacionPrecio.ForeColor = Color.Red;
                MessageBox.Show("Precio Invalido, Ingrese uno correcto");
                correcto = false;
            } else if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                lblValidacionPrecio.ForeColor = Color.Red;
                MessageBox.Show("El campo PRECIO debe completarse");
                correcto = false;
            } else
            {
                lblValidacionPrecio.ForeColor = Color.DarkGray;
            }

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                lblValidacionCodigo.ForeColor = Color.Red;
                MessageBox.Show("El campo CODIGO debe completarse");
                correcto = false;
            } else
            {
                lblValidacionCodigo.ForeColor= Color.DarkGray;
            }

            if(string.IsNullOrEmpty(txtNombre.Text))
            {
                lblValidacionNombre.ForeColor = Color.Red;
                MessageBox.Show("El campo NOMBRE debe completarse");
                correcto = false;
            } else if(soloNumeros(txtNombre.Text))
            {
                lblValidacionNombre.ForeColor= Color.Red;
                MessageBox.Show("Ingrese un nombre correcto que NO lleve Numeros");
                correcto = false;
            }else
            {
                lblValidacionNombre.ForeColor = Color.DarkGray;
            }

            if(string.IsNullOrEmpty(txtDescripcion.Text))
            {
                lblValidacionDescripcion.ForeColor = Color.Red;
                MessageBox.Show("El campo DESCRIPCION debe completarse");
                correcto = false;
            } else if(soloNumeros(txtDescripcion.Text))
            {
                lblValidacionDescripcion.ForeColor = Color.Red;
                MessageBox.Show("Ingrese una descripcion correcta que NO lleve Numeros");
                correcto = false;
            } else
            {
                lblValidacionDescripcion.ForeColor= Color.DarkGray;
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

                nuevaImagen.ImagenUrl = txtUrlImagen.Text;

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

                nuevaImagen = imagenes.BuscarImagen(articulo.Id);
                txtUrlImagen.Text = nuevaImagen.ImagenUrl;
                CargarImagen(nuevaImagen.ImagenUrl);
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
            nuevaImagen.IdArticulo = articulo.Id;
            imagenManager.modificar(nuevaImagen);

            MessageBox.Show("Modificado Exitosamente!");
        }

        private void crearNuevoArt()
        {
            ArticuloManager articuloManager = new ArticuloManager();
            ImagenManager imagenManager = new ImagenManager();

            articuloManager.Agregar(articulo);
            imagenManager.Agregar(nuevaImagen.ImagenUrl);

            MessageBox.Show("Agregado Exitosamente!");
        }
    }
}
