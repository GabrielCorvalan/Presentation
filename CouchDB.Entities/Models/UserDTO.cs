namespace Presentation.Entities.Models
{
    public class UserDTO : BaseDTO
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RolId { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }

        public TeacherDTO Teacher { get; set; }
        public StudentDTO Student { get; set; }
        public RolDTO Rol { get; set; }
    }
}
