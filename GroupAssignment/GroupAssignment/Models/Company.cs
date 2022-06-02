using System;
using System.Collections.Generic;

namespace GroupAssignment.Models
{
    public partial class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? Website { get; set; }
        public string? Address { get; set; }

        public virtual RecruimentPost RecruimentPost { get; set; } = null!;
    }
}
