using System;
using System.Collections.Generic;

namespace Tp.Entity.Tp.Entity.Models
{
    public partial class SubjectsStates
    {
        public SubjectsStates()
        {
            StudentsMaters = new HashSet<StudentsMaters>();
        }

        public Guid Id { get; set; }
        public string StateName { get; set; }

        public ICollection<StudentsMaters> StudentsMaters { get; set; }
    }
}
