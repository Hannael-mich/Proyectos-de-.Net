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
    public class DatMarcas
    {
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public List<EntMarcas> Obtener()
        {
            SqlCommand cmd = new SqlCommand("spObtenerMarcas", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<EntMarcas> ls = new List<EntMarcas>();

            foreach (DataRow dr in dt.Rows)
            {
                EntMarcas m = new EntMarcas();
                m.Id = Convert.ToInt32(dr["idM"]);
                m.Estatus = Convert.ToBoolean(dr["Estatus"]);
                m.Nombre = Convert.ToString(dr["NombreM"]);

                ls.Add(m);
            }

            return ls;
        }

        public List <EntMarcas> ObtenerReader()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spObtenerMarcas", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<EntMarcas> ls = new List<EntMarcas>();

                while (dr.Read())
                {
                    EntMarcas m = new EntMarcas();
                    m.Id = Convert.ToInt32(dr["idM"]);
                    m.Estatus = Convert.ToBoolean(dr["Estatus"]);
                    m.Nombre = Convert.ToString(dr["NombreM"]);

                    ls.Add(m);
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
