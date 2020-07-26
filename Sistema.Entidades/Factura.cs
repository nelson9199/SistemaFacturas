using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sistema.Entidades
{
    public class Factura
    {
        public int FacturaId { get; set; }

        [Required]
        public string NumeroFactura { get; set; }

        public DateTime FechaEmision { get; set; }

        [Required]
        public string ArchivoFactura { get; set; }

        [StringLength(60)]
        public string Estado { get; set; }

        public virtual List<ClienteFacturas> ClienteFacturas { get; set; }

    }
}
