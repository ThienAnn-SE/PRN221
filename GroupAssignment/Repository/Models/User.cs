using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class User
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    [StringLength (30)]
    public string Email { get; set; }
    [Required]
    [StringLength(20)]
    public string Password { get; set; }
    [Required]
    public string Role { get; set; }
    public string? PhoneNumber { get; set; }
}
