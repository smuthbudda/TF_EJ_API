namespace TF_EJ_API.Database.Models;

public class User
{
    public Guid ID { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime BirthDay { get; set; }
    public int MyProperty { get; set; }
}
