using System.ComponentModel.DataAnnotations;

namespace PPA_Semana09.Models
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MinLength(3, ErrorMessage = "Mínimo 3 caracteres")]
        [RegularExpression(@"^[A-Za-zÁÉÍÓÚáéíóúÑñ ]+$",
            ErrorMessage = "Solo letras y espacios, sin números")]
        public string NombreCompleto { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        // Regla de la práctica: debe contener @ y .
        [RegularExpression(@".+@.+\..+",
            ErrorMessage = "Debe ser un formato legible de correo electrónico")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [RegularExpression(@"^\d{9,}$",
            ErrorMessage = "Solo dígitos, mínimo 9")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Seleccione su carrera")]
        public string Carrera { get; set; }
    }
}
