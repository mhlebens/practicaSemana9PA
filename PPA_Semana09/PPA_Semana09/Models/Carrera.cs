using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PPA_Semana09.Models
{
    [Table("carreras", Schema = "dbo")]
    public class Carrera
    {
        [Key]
        [Column("id_carrera")]
        public int IdCarrera { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("nombre", TypeName = "nvarchar(100)")]
        public string Nombre { get; set; } = string.Empty;
    }
}
