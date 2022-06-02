using System;
using System.Collections.Generic;

namespace GroupAssignment.Models
{
    public partial class RecruimentPost
    {
        public int Id { get; set; }
        public int SemesterId { get; set; }
        public int CompanyId { get; set; }
        public string Status { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime RegistrationEndDate { get; set; }
        public string Content { get; set; } = null!;
        public double Salary { get; set; }
        public int EmploymentNumber { get; set; }
        public string? WorkingAddress { get; set; }
        public string? ContactPhoneNumber { get; set; }

        public virtual Semester Id1 { get; set; } = null!;
        public virtual Company IdNavigation { get; set; } = null!;
        public virtual OjtRequestMsg OjtRequestMsg { get; set; } = null!;
    }
}
