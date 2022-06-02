using System;
using System.Collections.Generic;

namespace GroupAssignment.Models
{
    public partial class CancelOjtRequestMsg
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SemesterId { get; set; }
        public string? Reason { get; set; }
        public DateTime CreateTime { get; set; }
        public string Status { get; set; } = null!;

        public virtual Student Id1 { get; set; } = null!;
        public virtual Semester IdNavigation { get; set; } = null!;
    }
}
