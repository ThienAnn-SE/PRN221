using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Student : User
{
    [Required]
    [StringLength(8)]
    public string StudentId { get; set; }
    [Required]
    [Timestamp]
    public DateTime DoB { get; set; }
    [Required]
    public string Major { get; set; }
    [Required]
    public float GPA { get; set; }
    public string? Address { get; set; }
    public string? Description { get; set; }
    public string? CVLink { get; set; }
    public bool? IsRegister { get; set; }

}
