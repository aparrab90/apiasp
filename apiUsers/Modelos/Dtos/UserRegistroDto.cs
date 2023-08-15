using System.ComponentModel.DataAnnotations;

namespace apiUsers.Modelos.Dtos
{
    public class UserRegistroDto
    {
        [Required(ErrorMessage = "La identificación del Usuario es obligatorio")]
        public string identificationUser { get; set; }

        [Required(ErrorMessage = "El nombre del Usuario es obligatorio")]
        public string nameUser { get; set; }

        [Required(ErrorMessage = "El mail del Usuario es obligatorio")]
        public string emailUser { get; set; }

        [Required(ErrorMessage = "El passrowd del Usuario es obligatorio")]
        public string passwordUser { get; set; }
    }
}