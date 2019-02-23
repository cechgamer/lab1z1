using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Wcfaritmetica
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IsrvSuma
    {

        [OperationContract]
        clsSuma suma(int numero1, int numero2);
    }

    [DataContract]
    public class clsSuma
    {
        [DataMember]
        public int numeroA { get; set; }

        [DataMember]
        public int numeroB { get; set; }

        [DataMember]
        public int resultado { get; set; }


    }
}

 
