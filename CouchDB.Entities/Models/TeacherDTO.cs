using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.Entities.Models
{
    public class TeacherDTO : BaseDTO
    {
        public string Names { get; set; }
        public DateTime Birthdate { get; set; }
        public string Surnames { get; set; }
        public int TeacherFile { get; set; }
        public long Dni { get; set; }
        public long Cuil { get; set; }
        public string Email { get; set; }
        public bool Sex { get; set; }
    }
}
