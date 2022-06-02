using System;
using System.Collections.Generic;

namespace GroupAssignment.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string StudentId { get; set; } = null!;
        public DateTime DoB { get; set; }
        public string Major { get; set; } = null!;
        public double? Gpa { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public string? Cvlink { get; set; }
        public bool? IsRegister { get; set; }

        public virtual CancelOjtRequestMsg CancelOjtRequestMsg { get; set; } = null!;
        public virtual OjtRequestMsg OjtRequestMsg { get; set; } = null!;
    }
}
