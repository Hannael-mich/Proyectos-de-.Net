using EntityPersonas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebWCFPersonas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicePersonas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicePersonas
    {
        [OperationContract]
        List<EntPersonas> Obtener();

        [OperationContract]
        EntPersonas ObtenerPorId(int id);

        [OperationContract]
        void Agregar(EntPersonas p);
    }

}
