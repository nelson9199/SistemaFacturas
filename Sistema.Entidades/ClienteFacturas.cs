using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entidades
{
    public class ClienteFacturas
    {
        public int ClienteId { get; set; }
        public int FacturaId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Factura Factura { get; set; }
    }
}
