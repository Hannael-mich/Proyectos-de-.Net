using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebMusica.Models;

namespace WebMusica.Datos
{
    public class D_Cancion
    {
        //Obteniendo cadena de conexion desde el webconfig
        protected string CadenaConexion = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        public void AbrirConexion()
        {

            SqlConnection conexion = new SqlConnection(CadenaConexion);

            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {

                throw ex; //Lanzamos la excepcion
            }
            finally //Este bloque se ejecuta siempre, haya error o no.
            {
                conexion.Close();
            }
        }

        public void Agregar(E_Cancion cancion) 
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            try
            {
                conexion.Open();
                string query = "INSERT INTO	Canciones(titulo, artista, album, duracion, fechaLanzamiento, Genero) " +
                "VALUES (@Titulo, @Artista, @Album, @Duracion, @FechaLanzamiento, @Genero)";

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Titulo", cancion.Titulo);
                comando.Parameters.AddWithValue("@Artista",cancion.Artista );
                comando.Parameters.AddWithValue("@Album", cancion.Album);
                comando.Parameters.AddWithValue("@Duracion", cancion.Duracion);
                comando.Parameters.AddWithValue("@FechaLanzamiento", cancion.FechaLanzamiento);
                comando.Parameters.AddWithValue("@Genero", cancion.Genero);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<E_Cancion> ObtenerTodos()
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            //Declarando la lista de Empleados vacia.
            List<E_Cancion> lista = new List<E_Cancion>();
            try
            {
                conexion.Open();

                string query = "SELECT idCancion, titulo, artista, album, duracion, fechaLanzamiento, Genero FROM Canciones;";
                SqlCommand comando = new SqlCommand(query, conexion);
                //Objeto SqlDataReader para leer el conjunto de resultados que devuelve el SELECT
                SqlDataReader reader = comando.ExecuteReader();
                //Recorremos el conjunto de resultados para llenar la lista

                while (reader.Read())
                {
                    //Creando un objeto de la clase empleado
                    E_Cancion obj = new E_Cancion();
                    //Asignamos sus propiedades 
                    obj.idCancion = Convert.ToInt32(reader["idCancion"]);//Convierte el tipo object a int
                    obj.Titulo = reader["titulo"].ToString();//Convierte el tipo object a string 
                    obj.Artista = reader["artista"].ToString();//Convierte el tipo object a string 
                    obj.Album = reader["album"].ToString();//Convierte el tipo object a decimal }
                    obj.Duracion = reader["duracion"].ToString();
                    obj.FechaLanzamiento = Convert.ToDateTime(reader["fechaLanzamiento"]);//Convierte el tipo object a DateTime 
                    obj.Genero = reader["Genero"].ToString();//Convierte el tipo object a string 

                    //Agregando el objeto a la lista
                    lista.Add(obj);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return lista;
        }

        public void Eliminar(int idCancion)
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            try
            {
                conexion.Open();
                string query = "DELETE FROM Canciones WHERE idCancion = @idCancion";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idCancion", idCancion);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public E_Cancion obtenerCancionPorId(int idCancion)
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            //Creando un objeto de la clase empleado
            E_Cancion obj = new E_Cancion();
            try
            {
                conexion.Open();
                string query = "SELECT idCancion, titulo, artista, album, duracion, fechaLanzamiento, Genero " +
                    "FROM Canciones WHERE idCancion= @idCancion";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idCancion", idCancion);

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {

                    //Asignamos sus propiedades 
                    obj.idCancion = Convert.ToInt32(reader["idCancion"]);//Convierte el tipo object a int
                    obj.Titulo = reader["titulo"].ToString();//Convierte el tipo object a string 
                    obj.Artista = reader["artista"].ToString();//Convierte el tipo object a string 
                    obj.Album = reader["album"].ToString();//Convierte el tipo object a decimal }
                    obj.Duracion = reader["duracion"].ToString();
                    obj.FechaLanzamiento = Convert.ToDateTime(reader["fechaLanzamiento"]);//Convierte el tipo object a DateTime 
                    obj.Genero = reader["Genero"].ToString();//Convierte el tipo object a string 

                }
                return obj;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void Editar(E_Cancion cancion)
        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            try
            {
                conexion.Open();
                string query = "UPDATE Canciones SET titulo =@titulo, artista=@artista," + 
                    "Album = @album, duracion = @duracion, fechaLanzamiento = @fechaLanzamiento, Genero = @Genero "+
                    "WHERE idCancion = @idCancion; ";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@titulo", cancion.Titulo);
                comando.Parameters.AddWithValue("@artista", cancion.Artista);
                comando.Parameters.AddWithValue("@album", cancion.Album);
                comando.Parameters.AddWithValue("@duracion", cancion.Duracion);
                comando.Parameters.AddWithValue("@fechaLanzamiento", cancion.FechaLanzamiento);
                comando.Parameters.AddWithValue("@Genero", cancion.Genero);
                comando.Parameters.AddWithValue("@idCancion", cancion.idCancion);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}