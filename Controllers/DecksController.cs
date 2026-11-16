using Microsoft.AspNetCore.Mvc;

namespace Flashcards.Controllers;

[ApiController]
[Route("[controller]")]
public class DecksController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}