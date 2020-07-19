using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Entidades
{
    public class ClienteFacturas
    {
        public int ClienteId { get; set; }
        public int FacturaId { get; set; }

        public Cliente Cliente { get; set; }
        public Factura Factura { get; set; }
    }
}
