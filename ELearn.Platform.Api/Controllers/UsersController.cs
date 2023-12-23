using ELearn.Platform.Application;
using ELearn.Platform.Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ELearn.Platform.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{

    private readonly ILogger<UsersController> _logger;
    private readonly IUserService _userService;

    public UsersController(ILogger<UsersController> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    [HttpGet]
    public ActionResult<List<User>> Get()
    {
        var result = _userService.GetUsers();
        return Ok(result);
    }

    [HttpPost]
    public ActionResult<User> Post(User user)
    {
        var result = _userService.AddUser(user);
        return Ok(result);
    }
}
