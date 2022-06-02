using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Manager : User
{
    [Required]
    public bool IsActived { get; set; }
}
