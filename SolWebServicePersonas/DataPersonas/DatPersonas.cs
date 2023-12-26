using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPersonas
{
    public class DatPersonas
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        
        /*public DataTable ObtenerDatos()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from personas3",con);
            da.Fill(dt);

            return dt;
        }*/

        public DataTable Obtener()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Personas", con))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }


        public DataRow ObtenerPorId(int id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Personas where id ="+ id,con);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
                return dt.Rows[0];
            else
                return null; // o lanzar una excepción, dependiendo de tus requisitos

            //return dt.Rows[0];
        }

        public int Agregar (string nombre, int edad, string paterno, string materno) //Regresa un int
        {
            int filasAfectadas = 0;
            SqlCommand com = new SqlCommand($"Insert into Personas values ('{nombre}',{edad},'{2016-03-16}','{paterno}','{materno}')",con);
            try
            {
                con.Open();
                filasAfectadas = com.ExecuteNonQuery();
                con.Close();
                return filasAfectadas;
            }
            catch (Exception)
            {
                con.Close();
                throw ;
            }

        }

        public void Editar (string nombre, string paterno, string materno, int edad, int id) //Regresa un int
        {
            int filasAfectadas = 0;
            SqlCommand com = new SqlCommand($"update Personas set nombre = '{ nombre}', edad ={edad}, fechaAlta={DateTime.Now.ToString()}, paterno={paterno}, materno={materno}  WHERE Id = {id}",con);
            try
            {
                con.Open();
                filasAfectadas = com.ExecuteNonQuery();
                con.Close();
                //return filasAfectadas;
            }
            catch (Exception)
            {
                con.Close();
                throw;
            }

        }

        public void Borrar (int id) //regresa un int
        {
            int filasAfectadas = 0;
            SqlCommand com = new SqlCommand($"delecte Personas where id= {id}", con);
            try
            {
                con.Open();
                filasAfectadas = com.ExecuteNonQuery();
                con.Close();
                //return filasAfectadas;
            }
            catch (Exception)
            {
                con.Close();
                throw;
            }
        }
    }
}
