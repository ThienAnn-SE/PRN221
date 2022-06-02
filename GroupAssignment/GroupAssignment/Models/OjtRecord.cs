using System;
using System.Collections.Generic;

namespace GroupAssignment.Models
{
    public partial class OjtRecord
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Status { get; set; }
        public string? Note { get; set; }

        public virtual OjtRequestMsg IdNavigation { get; set; } = null!;
        public virtual EvaluationReport EvaluationReport { get; set; } = null!;
    }
}
