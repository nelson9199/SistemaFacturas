using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sistema.Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Required]
        [StringLength(150)]
        public string PrimerNombre { get; set; }

        [StringLength(150)]
        public string SegundoNombre { get; set; }

        [Required]
        [StringLength(150)]
        public string PrimerApellido { get; set; }

        [StringLength(150)]
        public string SegundoApellido { get; set; }

        [Required]
        [StringLength(20)]
        public string TipoDocumento { get; set; }

        [Required]
        [StringLength(20)]
        public string NumeroDocumento { get; set; }

        [Required]
        [StringLength(20)]
        public string RUC { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public bool Estado { get; set; }

        public bool EstaBorrado { get; set; }

        public List<ClienteFacturas> ClienteFacturas { get; set; }
    }
}
