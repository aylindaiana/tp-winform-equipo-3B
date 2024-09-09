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
        private Articulo articulo = null;
        private List<Categoria> listaCategorias = new List<Categoria>();
        private List<Marca> listaMarcas = new List<Marca>();



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
            CategoriaManager categorias = new CategoriaManager();
            MarcaManager marcas = new MarcaManager();

            try
            {
                listaCategorias = categorias.Listar();
                listaMarcas = marcas.Listar();

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron obtener los datos");
            }
            finally
            {
                cboCategoria.DataSource = listaCategorias;
                cboMarca.DataSource = listaMarcas;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

    }
}
