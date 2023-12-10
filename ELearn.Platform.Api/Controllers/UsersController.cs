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
    public IEnumerable<User> Get()
    {
        return _userService.GetUsers();
    }
}
