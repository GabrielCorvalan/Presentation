using System;
using System.Collections.Generic;

namespace Tp.Entity.Tp.Entity.Models
{
    public partial class Commisions
    {
        public Guid Id { get; set; }
        public string CommisionName { get; set; }
        public bool Deleted { get; set; }
    }
}
