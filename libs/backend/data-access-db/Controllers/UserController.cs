using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAccessDb;

namespace User.Controlllers
{
  /// <summary>
  /// Represents a controller for managing user operations.
  /// </summary>
  [ApiController]
  [Route("[controller]")]
  public class UserController : ControllerBase
  {
    private readonly AppDbContext _context;

    public UserController(AppDbContext context)
    {
      _context = context;
    }

    /// <summary>
    /// Creates a new user.
    /// </summary>
    /// <param name="user">The user object to be created.</param>
    /// <returns>The created user.</returns>
    [HttpPost]
    public async Task<ActionResult<DotnetTemplate.Models.User>> Post(DotnetTemplate.Models.User user)
    {
      _context.Users.Add(user);
      await _context.SaveChangesAsync();
      return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
    }

    /// <summary>
    /// Retrieves all users.
    /// </summary>
    /// <returns>A collection of all users.</returns>
    [HttpGet]
    public async Task<IEnumerable<DotnetTemplate.Models.User>> Get()
    {
      return await _context.Users.ToListAsync();
    }

    /// <summary>
    /// Retrieves a user by ID.
    /// </summary>
    /// <param name="id">The ID of the user to retrieve.</param>
    /// <returns>The user with the specified ID.</returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<DotnetTemplate.Models.User>> Get(int id)
    {
      var user = await _context.Users.FindAsync(id);
      if (user == null)
      {
        return NotFound();
      }
      return user;
    }
  }
}
