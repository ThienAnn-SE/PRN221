public class OjtRecord
{
    public string ID { get; set; }
    public OjtRequestMsg Request { get; set; }
    public DateTime StartDate   { get; set; }
    public DateTime EndDate { get; set; }
    public string Status { get; set; }
    public string? Note { get; set; }

}
