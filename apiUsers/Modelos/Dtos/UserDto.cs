using System.ComponentModel.DataAnnotations;

namespace apiUsers.Modelos.Dtos
{
    public class UserDto
    {
        public int idUser { get; set; }
        public string identificationUser { get; set; }
        public string nameUser { get; set; }
        public string emailUser { get; set; }
        public string passwordUser { get; set; }
        public DateTime createUser { get; set; }
    }
}
