namespace Cuculus.WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController, Route("[controller]")]
public class PingController : ControllerBase
{
    [HttpGet(Name = "ping")]
    public string Get()
    {
        return "Pong";
    }
}
