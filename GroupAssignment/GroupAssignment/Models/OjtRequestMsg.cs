using System;
using System.Collections.Generic;

namespace GroupAssignment.Models
{
    public partial class OjtRequestMsg
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime CreateTime { get; set; }
        public int RecruimentPostId { get; set; }
        public string Status { get; set; } = null!;

        public virtual Student Id1 { get; set; } = null!;
        public virtual RecruimentPost IdNavigation { get; set; } = null!;
        public virtual OjtRecord OjtRecord { get; set; } = null!;
    }
}
