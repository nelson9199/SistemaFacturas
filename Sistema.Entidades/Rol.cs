using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sistema.Entidades
{
    public class Rol
    {
        public int RolId { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public bool Estado { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
}
