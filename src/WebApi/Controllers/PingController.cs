namespace Cuculus.WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController, Route("[controller]")]
public sealed class PingController : ControllerBase
{
    [HttpGet(Name = "ping")] public string Get() => "Pong";
}
