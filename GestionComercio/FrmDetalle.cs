using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Manager;

namespace GestionComercio
{
    public partial class FrmDetalle : Form
    {
        private Articulo _articulo;

        public FrmDetalle(Articulo articulo)
        {
            InitializeComponent();
            _articulo = articulo;
        }

        private void FrmDetalle_Load(object sender, EventArgs e)
        {
            if (_articulo != null)
            {
                // Asigno los datos del artículo a los txt
                labelCodigo.Text = _articulo.Codigo;
                labelNombre.Text = _articulo.Nombre;
                labelDescripcion.Text = _articulo.Descripcion;
                labelMarca.Text = _articulo.TipoMarca.ToString();
                labelCategoria.Text = _articulo.TipoCategoria.ToString();
                labelPrecio.Text = _articulo.Precio.ToString();

                lblTitulo.Text = _articulo.Nombre; //el titulo
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

