using EntityProductos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProductos
{
    public class DatDepartamentos
    {
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public List<EntDepartamentos> Obtener()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spObtenerDepartamentos", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<EntDepartamentos> ls = new List<EntDepartamentos>();

                while (dr.Read())
                {
                    EntDepartamentos d = new EntDepartamentos();
                    d.Id = Convert.ToInt32(dr["idD"]);
                    d.Nombre = Convert.ToString(dr["NombreD"]);

                    ls.Add(d);
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



    }
}
