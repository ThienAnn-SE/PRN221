using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class RequestMsg
{
    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required, ForeignKey("")]
    public string UserId { get; set; }
    public string Type { get; set; }
    public DateTime CreateTime { get; set; }
    public string Status { get; set; }
}
