using EntityPersonas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusinessPersonas
{
    public class DBPersonas
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public List<EntPersonas> Obtener()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from personas", con);
            da.Fill(dt);

            List<EntPersonas> ls = new List<EntPersonas>();
            foreach(DataRow dr in dt.Rows)
            {
                EntPersonas p = new EntPersonas();
                p.ApellidoMaterno = dr["materno"].ToString();
                p.ApellidoPaterno = dr["paterno"].ToString();
                p.Edad = Convert.ToInt32(dr["edad"]);
                p.FechaAlta = Convert.ToDateTime(dr["fechaAlta"]);
                p.Id = Convert.ToInt32(dr["id"]);
                p.Nombre = dr["nombre"].ToString();

                ls.Add(p);
            }
            return ls; 
        }

        public EntPersonas Obtener(int id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from personas where id ="+ id, con);
            da.Fill(dt);
            DataRow dr = dt.Rows[0];

            EntPersonas p = new EntPersonas();
            p.ApellidoMaterno = dr["materno"].ToString();
            p.ApellidoPaterno = dr["paterno"].ToString();
            p.Edad = Convert.ToInt32(dr["edad"]);
            p.FechaAlta = Convert.ToDateTime(dr["fechaAlta"]);
            p.Id = Convert.ToInt32(dr["id"]);
            p.Nombre = dr["nombre"].ToString();

            return p;
        }

        public void Agregar (EntPersonas p)
        {
            int filasAfectadas = 0;
            SqlCommand com = new SqlCommand ($"Insert into personas values ('{p.Nombre}',{p.Edad},'{DateTime.Now.ToString("yyyy/MM/dd")}','{p.ApellidoPaterno}','{p.ApellidoMaterno}')", con);
            try
            {
                con.Open();
                filasAfectadas = com.ExecuteNonQuery();
                con.Close();

                if (filasAfectadas != 1)
                {
                    throw new ApplicationException("Error al agregar");
                }
            }
            catch (Exception)
            {
                con.Close();
                throw;
            }
        
        }

        public void Editar(EntPersonas p)
        {
            int filasAfectadas = 0;
            SqlCommand com = new SqlCommand($"update Personas set nombre = '{p.Nombre}', edad ={p.Edad}, fechaAlta={DateTime.Now.ToString("yyyy/MM/dd")}, paterno={p.ApellidoMaterno}, materno={p.ApellidoMaterno}  WHERE Id = {p.Id}", con);
            try
            {
                con.Open();
                filasAfectadas = com.ExecuteNonQuery();
                con.Close();

                if (filasAfectadas != 1)
                {
                    throw new ApplicationException("Error al editar");
                }
            }
            catch (Exception)
            {
                con.Close();
                throw;
            }

        }

        public void Borrar(EntPersonas p)
        {
            int filasAfectadas = 0;
            SqlCommand com = new SqlCommand($"delecte personas where id= {p.Id}", con);
            try
            {
                con.Open();
                filasAfectadas = com.ExecuteNonQuery();
                con.Close();

                if (filasAfectadas != 1)
                {
                    throw new ApplicationException("Error al editar");
                }
            }
            catch (Exception)
            {
                con.Close();
                throw;
            }

        }
    }
}
