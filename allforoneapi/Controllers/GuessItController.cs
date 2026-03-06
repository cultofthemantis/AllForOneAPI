using Microsoft.AspNetCore.Mvc;
using allforoneapi.Services;

namespace allforoneapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GuessItController : ControllerBase
{
    private readonly GuessItService service;

    public GuessItController(GuessItService service)
    {
        this.service = service;
    }

    [HttpGet("easy")]
    public IActionResult Easy(int guess)
    {
        if (guess < 1 || guess > 10)
        {
            return BadRequest("Guess between 1 and 10.");
        }

        return Ok(service.Play(guess, 10));
    }

    [HttpGet("medium")]
    public IActionResult Medium(int guess)
    {
        if (guess < 1 || guess > 50)
        {
            return BadRequest("Guess between 1 and 50.");
        }

        return Ok(service.Play(guess, 50));
    }

    [HttpGet("hard")]
    public IActionResult Hard(int guess)
    {
        if (guess < 1 || guess > 100)
        {
            return BadRequest("Guess between 1 and 100.");
        }

        return Ok(service.Play(guess, 100));
    }
}