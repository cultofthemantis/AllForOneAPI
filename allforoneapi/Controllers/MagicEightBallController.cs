using Microsoft.AspNetCore.Mvc;
using allforoneapi.Services;

namespace allforoneapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Magic8BallController : ControllerBase
{
    private readonly Magic8BallService service;

    public Magic8BallController(Magic8BallService service)
    {
        this.service = service;
    }

    [HttpGet]
    public IActionResult Ask(string question)
    {
        if (string.IsNullOrWhiteSpace(question))
        {
            return BadRequest("Question required.");
        }

        return Ok(service.Ask());
    }
}