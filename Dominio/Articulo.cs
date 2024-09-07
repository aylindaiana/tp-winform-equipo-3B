using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca TipoMarca { get; set; }   //esto ya lo dejo asi para cuando hagan sus clases chicos
        public Categoria TipoCategoria { get; set; }
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }
    }

}