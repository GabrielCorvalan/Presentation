namespace Presentation.Entities.Models
{
    public class UserDTO : BaseDTO
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Names { get; set; }
        public string Surnames { get; set; }
        public int? RolId { get; set; }

        public RolDTO Rol { get; set; }
    }
}
