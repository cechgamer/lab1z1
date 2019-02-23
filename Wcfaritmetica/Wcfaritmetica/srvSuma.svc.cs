using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Wcfaritmetica
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class srvSuma : IsrvSuma
    {
        clsSuma IsrvSuma.suma(int numero1, int numero2)
        {
            clsSuma obj = new clsSuma();
            obj.numeroA = numero1;
            obj.numeroB = numero2;
            obj.resultado = obj.numeroA + obj.numeroB;


        }
    }
}
