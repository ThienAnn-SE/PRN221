using System;
using System.Collections.Generic;

namespace GroupAssignment.Models
{
    public partial class Semester
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual CancelOjtRequestMsg CancelOjtRequestMsg { get; set; } = null!;
        public virtual RecruimentPost RecruimentPost { get; set; } = null!;
    }
}
