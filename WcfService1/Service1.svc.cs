using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public Boleta GetData(double subtotal)
        {
            const double IGV_PORC = 0.18;
            Boleta OBoleta = new Boleta();
            OBoleta.id = 100;
            OBoleta.subtotal = subtotal;
            OBoleta.igv = subtotal * IGV_PORC;
            OBoleta.CalcularTotal();
            //
            Boleta OBoleta2 = new Boleta();
            OBoleta2.id = 100;
            OBoleta2.subtotal = subtotal * 2;
            OBoleta2.igv = subtotal * IGV_PORC;
            OBoleta2.CalcularTotal();
            //
            return OBoleta;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
