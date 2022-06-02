using System;
using System.Collections.Generic;

namespace GroupAssignment.Models
{
    public partial class EvaluationReport
    {
        public int Id { get; set; }
        public int OjtRecordId { get; set; }
        public double? FirstHalfPoint { get; set; }
        public double? SecondHalfPoint { get; set; }
        public string? Comment { get; set; }

        public virtual OjtRecord IdNavigation { get; set; } = null!;
    }
}
