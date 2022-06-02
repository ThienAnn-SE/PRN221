using System.ComponentModel.DataAnnotations;

public class CompanyManager : User
{
    [Required]
    public string Website { get; set; }
    [Required]
    public string Address { get; set; }
}
