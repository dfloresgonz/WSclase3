using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1
{
    [DataContract]
    public class Boleta
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public double subtotal { get; set; }
        [DataMember]
        public double igv { get; set; }
        [DataMember]
        public double total { get; set; }

        public double CalcularTotal()
        {
            this.total = this.subtotal + this.igv;
            return this.total;
        }
    }
}