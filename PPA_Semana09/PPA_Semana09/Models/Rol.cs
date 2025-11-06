using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PPA_Semana09.Models
{
    [Table("roles", Schema = "dbo")]
    public class Rol
    {
        [Key]
        [Column("id_rol")]
        public int IdRol { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("nombre", TypeName = "nvarchar(50)")]
        public string Nombre { get; set; } = string.Empty;
    }
}
