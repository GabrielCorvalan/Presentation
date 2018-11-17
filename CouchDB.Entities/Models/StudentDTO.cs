using System;

namespace Presentation.Entities.Models
{
    public class StudentDTO : BaseDTO
    {
        public string Names { get; set; }
        public DateTime Birthdate { get; set; }
        public string Surnames { get; set; }
        public int StudentFile { get; set; }
        public long Dni { get; set; }
        public long Cuil { get; set; }
        public string Email { get; set; }
        public bool Sex { get; set; }

        public AddressDTO Address { get; set; }

    }
}
