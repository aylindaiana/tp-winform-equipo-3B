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
    public partial class FrmAddMarcaYCategoria : Form
    {
        public string TablaDestino { get; set; }

        public FrmAddMarcaYCategoria()
        {
            InitializeComponent();
        }

        private void FrmAddMarcaYCategoria_Load(object sender, EventArgs e)
        {
            if (TablaDestino == "Marcas")
                lblTitulo.Text = "Agregamos una Marca nueva";
            else
                lblTitulo.Text = "Agregamos una Categoria nueva";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // falta validacion

            try
            {
                if (TablaDestino == "Marcas")
                    AgregarMarcaNueva();
                else
                    AgregarCategoriaNueva();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            { 
                Close(); 
            }
        }

        private void AgregarMarcaNueva() 
        { 
            MarcaManager marcas = new MarcaManager();
            marcas.Agregar(txtNombre.Text);
        }

        private void AgregarCategoriaNueva()
        { 
            CategoriaManager categorias = new CategoriaManager();
            categorias.Agregar(txtNombre.Text);
        }

    }
}
