using System.ComponentModel.DataAnnotations;

namespace apiUsers.Modelos.Dtos
{
    public class UserLoginDto
    {
        [Required(ErrorMessage = "La identificación del Usuario es obligatorio")]
        public string identificationUser { get; set; }

        [Required(ErrorMessage = "El passrowd del Usuario es obligatorio")]
        public string passwordUser { get; set; }
    }
}
