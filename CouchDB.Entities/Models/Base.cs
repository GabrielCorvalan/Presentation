using System;

namespace Presentation.Entities.Models
{
    public class Base
    {
        public string _id { get; set; }
        public string _rev { get; set; }
        public DateTime DateCreated { get; set; }
    }
}