using Microsoft.AspNetCore.Mvc;
using allforoneapi.Services;

namespace allforoneapi.Controllers;

[ApiController]
[Route("Chinese/Mexican/Italian/[controller]")]
public class RestaurantPickerController : ControllerBase
{
    private readonly RestaurantPickerService service;

    public RestaurantPickerController(RestaurantPickerService service)
    {
        this.service = service;
    }

    [HttpGet]
    public IActionResult Pick(string category)
    {
        var result = service.Pick(category);

        if (result == null)
        {
            return BadRequest(new
            {
                message = "Invalid category",
                categories = service.restaurants.Keys
            });
        }

        return Ok(result);
    }
}