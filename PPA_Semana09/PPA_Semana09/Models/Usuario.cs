using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PPA_Semana09.Models
{
    [Table("usuarios", Schema = "dbo")]
    public class Usuario
    {
        [Key]
        [Column("id_usuario")]
        public int IdUsuario { get; set; }

        [Required]
        [MaxLength(120)]
        [Column("nombre_completo", TypeName = "nvarchar(120)")]
        public string NombreCompleto { get; set; } = string.Empty;

        [Required]
        [MaxLength(150)]
        [Column("correo_fidelitas", TypeName = "nvarchar(150)")]
        public string CorreoFidelitas { get; set; } = string.Empty;

        [Required]
        [MaxLength(25)]
        [Column("telefono", TypeName = "nvarchar(25)")]
        public string Telefono { get; set; } = string.Empty;

        [Column("id_carrera")]
        public int IdCarrera { get; set; }

        [Column("id_rol")]
        public int IdRol { get; set; }

        [Column("creado_el", TypeName = "datetime2(0)")]
        public DateTime CreadoEl { get; set; }

        [Column("actualizado_el", TypeName = "datetime2(0)")]
        public DateTime ActualizadoEl { get; set; }
    }
}
