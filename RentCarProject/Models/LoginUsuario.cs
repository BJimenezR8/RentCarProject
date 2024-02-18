using System.ComponentModel.DataAnnotations;

namespace RentCarProject.Models 

{
    public class LoginUsuario
    {
        [Key]

        public int IdUsuario { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
