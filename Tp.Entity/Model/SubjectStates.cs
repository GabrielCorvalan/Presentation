using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class SubjectStates
    {
        public SubjectStates()
        {
            StudensPerSubject = new HashSet<StudensPerSubject>();
        }

        public int Id { get; set; }
        public string StateName { get; set; }

        public ICollection<StudensPerSubject> StudensPerSubject { get; set; }
    }
}
