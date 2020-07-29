using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sistema.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public int? RolId { get; set; }
        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string TipoDocumento { get; set; }
        [Required]
        [StringLength(30)]
        public string NumeroDocumento { get; set; }
        [StringLength(200)]
        public string Direccion { get; set; }
        [StringLength(20)]
        public string Telefono { get; set; }
        [Required]
        [StringLength(100)]
        public string Username { get; set; }
        [Required]
        public string Clave { get; set; }
        [Required]
        public string Salt { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public bool Estado { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
