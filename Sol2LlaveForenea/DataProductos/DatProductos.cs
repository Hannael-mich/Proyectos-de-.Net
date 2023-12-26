using EntityProductos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProductos
{
    public class DatProductos
    {
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public List<EntProductos> Obtener() 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spObtenerProductos", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                List<EntProductos> ls = new List<EntProductos>();

                while (dr.Read())
                {
                    EntProductos p = new EntProductos();
                    EntMarcas m = new EntMarcas();
                    EntDepartamentos d = new EntDepartamentos();

                    
                    p.Id = Convert.ToInt32(dr["id"]);
                    p.Nombre = Convert.ToString(dr["Nombre"]);
                    p.FechaCaducidad = Convert.ToDateTime(dr["FechaCaducidad"]);
                    p.MarcaId = Convert.ToInt32(dr["Marcaid"]);
                    p.DepartamentoId = Convert.ToInt32(dr["Departamentoid"]);

                    m.Id = Convert.ToInt32(dr["idM"]);
                    m.Estatus = Convert.ToBoolean(dr["Estatus"]);
                    m.Nombre = Convert.ToString(dr["NombreM"]);

                    d.Id = Convert.ToInt32(dr["idD"]);
                    d.Nombre = Convert.ToString(dr["NombreD"]);

                    p.EntMarcas = m;
                    p.EntDepartamentos = d;

                    ls.Add(p);
                }
                return ls;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public EntProductos Obtener(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spObtenerProductosPorId", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
     
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                //List<EntProductos> ls = new List<EntProductos>();

                EntProductos p = new EntProductos();
                EntMarcas m = new EntMarcas();
                EntDepartamentos d = new EntDepartamentos();

                if (dr.Read())
                {

                    p.Id = Convert.ToInt32(dr["id"]);
                    p.Nombre = Convert.ToString(dr["Nombre"]);
                    p.FechaCaducidad = Convert.ToDateTime(dr["FechaCaducidad"]);
                    p.MarcaId = Convert.ToInt32(dr["Marcaid"]);
                    p.DepartamentoId = Convert.ToInt32(dr["Departamentoid"]);

                    m.Id = Convert.ToInt32(dr["idM"]);
                    m.Estatus = Convert.ToBoolean(dr["Estatus"]);
                    m.Nombre = Convert.ToString(dr["NombreM"]);

                    d.Id = Convert.ToInt32(dr["idD"]);
                    d.Nombre = Convert.ToString(dr["NombreD"]);

                    p.EntMarcas = m;
                    p.EntDepartamentos = d;

                    //ls.Add(p);
                }
                return p;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// Valida, si producto con marca no existe lo agrega, si no, manda error
        /// </summary>
        /// <param name="p">es la entidad producto</param>
        public void Agregar (EntProductos p) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spAgregarProducto", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@FechaCaducidad", p.FechaCaducidad);
                cmd.Parameters.AddWithValue("@Marcaid", p.MarcaId);
                cmd.Parameters.AddWithValue("@Departamentoid", p.DepartamentoId);


                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public void Editar(EntProductos p)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spEditarProducto", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@FechaCaducidad", p.FechaCaducidad);
                cmd.Parameters.AddWithValue("@Marcaid", p.MarcaId);
                cmd.Parameters.AddWithValue("@Departamentoid", p.DepartamentoId);
                cmd.Parameters.AddWithValue("@id", p.Id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public List<EntProductos> Buscar(string texto) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spObtenerProductosSimple", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@texto", texto);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                List<EntProductos> ls = new List<EntProductos>();

                while (dr.Read())
                {
                    EntProductos p = new EntProductos();
                    EntMarcas m = new EntMarcas();
                    EntDepartamentos d = new EntDepartamentos();


                    p.Id = Convert.ToInt32(dr["id"]);
                    p.Nombre = Convert.ToString(dr["Nombre"]);
                    p.FechaCaducidad = Convert.ToDateTime(dr["FechaCaducidad"]);
                    p.MarcaId = Convert.ToInt32(dr["Marcaid"]);
                    p.DepartamentoId = Convert.ToInt32(dr["Departamentoid"]);

                    m.Id = Convert.ToInt32(dr["idM"]);
                    m.Estatus = Convert.ToBoolean(dr["Estatus"]);
                    m.Nombre = Convert.ToString(dr["NombreM"]);

                    d.Id = Convert.ToInt32(dr["idD"]);
                    d.Nombre = Convert.ToString(dr["NombreD"]);

                    p.EntMarcas = m;
                    p.EntDepartamentos = d;

                    ls.Add(p);
                }
                return ls;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public void Borrar(int id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spBorrarProducto", con);
                cmd.Parameters.AddWithValue("@productoid", id);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id",id);

                //con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
