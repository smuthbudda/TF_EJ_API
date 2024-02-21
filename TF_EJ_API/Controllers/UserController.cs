using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TF_EJ_API.Database;
using TF_EJ_API.Database.Models;

namespace TF_EJ_API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(ApplicationDbContext context) : ControllerBase
{
    public readonly ApplicationDbContext _context = context;

    [HttpGet(Name = "GetUsers")]
    public IEnumerable<User> Get()
    {
        return new List<User>();
    }

}
