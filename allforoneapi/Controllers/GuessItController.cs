using Microsoft.AspNetCore.Mvc;
using allforoneapi.Services;

namespace allforoneapi.Services
{
    
[ApiController]
[Route("api/[controller]")]
public class GuessItController : ControllerBase
{
    public readonly GuessItService _service;

    public GuessItController(GuessItService service)
    {
        _service = service;
    }

    [HttpGet]
    [Route("GuessIt/{guess}")]
    public string GuessItGame(int guess)
    {
        if (guess < 1 || guess > 100)
        {
            return "Guess between 1 and 100";
        }
        
        else
            {
            return _service.Play(guess);
                
            }
    }
}

}