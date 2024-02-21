
using Microsoft.EntityFrameworkCore;
using TF_EJ_API.Database.Models;


namespace TF_EJ_API.Database;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :DbContext(options)
{
    public required DbSet<User> Users { get; set; }
}
