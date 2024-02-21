namespace TF_EJ_API.Database.Models;

public class User
{
    public Guid ID { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime BirthDay { get; set; }
    public string? PostCode { get; set; }
    public string? Address { get; set; }
    public required string Email { get; set; }
    public bool IsActive { get; set; }
}
