using DataPersonas;
using EntityPersonas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessPersonas
{
    public class BusPersonas
    {
        DatPersonas dat = new DatPersonas();
        private DatPersonas dataPersonas = new DatPersonas();

        public List<EntPersonas> Obtener()
        {
            List<EntPersonas> listaPersonas = new List<EntPersonas>();
            DataTable dt = dat.Obtener();

            // Aquí deberías mapear los datos del DataTable a tu lista de EntPersonas
            // Puedes usar un bucle foreach o LINQ para hacer la conversión

            // Ejemplo utilizando LINQ
            listaPersonas = dt.AsEnumerable()
                              .Select(row => new EntPersonas
                              {
                                  Id = Convert.ToInt32(row["Id"]),
                                  Nombre = row["Nombre"].ToString(),
                                  Edad = Convert.ToInt32(row["Edad"]),
                                  FechaAlta = Convert.ToDateTime(row["FechaAlta"]),
                                  ApellidoPaterno = row["Paterno"].ToString(),
                                  ApellidoMaterno = row["Materno"].ToString()
                                  // Otros campos
                              })
                              .ToList();

            return listaPersonas;
        }
        public EntPersonas ObtenerPorId(int id) 
        {
            DataRow row = dataPersonas.ObtenerPorId(id);

            if (row != null)
            {
                EntPersonas persona = new EntPersonas
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nombre = row["Nombre"].ToString(),
                    Edad = Convert.ToInt32(row["Edad"]),
                    FechaAlta = Convert.ToDateTime(row["FechaAlta"]),
                    ApellidoPaterno = row["Paterno"].ToString(),
                    ApellidoMaterno = row["Materno"].ToString()
                    // Otros campos
                };

                return persona;
            }
            else
            {
                return null; // o lanzar una excepción, dependiendo de tus requisitos
            }
        }

        public void Agregar(EntPersonas p) 
        {
            // Aquí podrías hacer validaciones adicionales antes de pasar los datos a la capa de datos
            dat.Agregar(p.Nombre, p.Edad, p.ApellidoPaterno, p.ApellidoMaterno);
        }
        public void Editar(EntPersonas p) 
        {
            // Aquí podrías hacer validaciones adicionales antes de pasar los datos a la capa de datos
            dat.Editar(p.Nombre, p.ApellidoPaterno, p.ApellidoMaterno, p.Edad, p.Id);
        }
        public void Borrar(EntPersonas p) 
        {
            dat.Borrar(p.Id);
        }
    }
}
