public class RecruimentPost
{
    public string Id { get; set; }
    public string SemesterId { get; set; }
    public CompanyManager CompanyManager { get; set; }
    public string Status { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime RegistrationEndDate { get; set; }
    public string Content { get; set; }
    public decimal Salary { get; set; }
    public int EmploymentNumber { get; set; }
    public string WorkingAddress { get; set; }
    public string ContactPhoneNumber { get; set; }
}
