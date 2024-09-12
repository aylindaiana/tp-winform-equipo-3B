using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class ImagenManager
    {
        public List<Imagen> listar()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.IdArticulo = (int)datos.Lector["IdArticulo"];
                   
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConeccion();
            }
        }

        public Imagen BuscarImagen(int IdArt)
        {
            Imagen imagenBuscada = new Imagen();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES WHERE IdArticulo = @IdArt");
                datos.SetearParametro("@IdArt", IdArt);
                datos.EjecutarLectura();

                datos.Lector.Read();
                
                imagenBuscada.Id = (int)datos.Lector["Id"];
                imagenBuscada.IdArticulo = (int)datos.Lector["IdArticulo"];

                if (!(datos.Lector["ImagenUrl"] is DBNull))
                    imagenBuscada.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                

                return imagenBuscada;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConeccion();
            }
        }
    }
}
