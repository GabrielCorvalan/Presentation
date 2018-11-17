using System;

namespace Presentation.Entities.Models
{
    public class BaseDTO
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Deleted { get; set; }
    }
}