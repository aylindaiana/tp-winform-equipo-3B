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
        private List<Imagen> _imagenes;
        private int PosicionImg;

        public FrmDetalle(Articulo articulo)
        {
            InitializeComponent();
            _articulo = articulo;

            _imagenes = new List<Imagen>(); 
            PosicionImg = 0; //indice inicial de la imagen
        }

        private void FrmDetalle_Load(object sender, EventArgs e)
        {
            if (_articulo != null)
            {
                ImagenManager ImgManager = new ImagenManager();

                // Asigno los datos del artículo a los txt
                labelCodigo.Text = _articulo.Codigo;
                labelNombre.Text = _articulo.Nombre;
                labelDescripcion.Text = _articulo.Descripcion;
                labelMarca.Text = _articulo.TipoMarca.ToString();
                labelCategoria.Text = _articulo.TipoCategoria.ToString();
                labelPrecio.Text = _articulo.Precio.ToString();

                lblTitulo.Text = _articulo.Nombre; //el titulo

                _imagenes = ImgManager.ListarPorArticuloId(_articulo.Id); // Lista todas las imágenes del artículo
                if (_imagenes.Count > 0)
                {
                    CargarImagen(_imagenes[0].ImagenUrl);
                } //hago un else?


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

        private void flecha_izq_Click(object sender, EventArgs e)
        {
            if (_imagenes.Count > 0)
            {
                PosicionImg--;
                if (PosicionImg < 0)
                {
                    PosicionImg = _imagenes.Count - 1; // Volver al ultimo si estamos en el primero
                }
                CargarImagen(_imagenes[PosicionImg].ImagenUrl);
            }
        }

        private void flecha_der_Click(object sender, EventArgs e)
        {
            if (_imagenes.Count > 0)
            {
                PosicionImg++;
                if (PosicionImg >= _imagenes.Count)
                {
                    PosicionImg = 0; // Volver al primero si estamos en el ultimo
                }
                CargarImagen(_imagenes[PosicionImg].ImagenUrl);
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

