using Microsoft.AspNetCore.Mvc;
using PracticeDotnet.Models;
namespace PracticeDotnet.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    [HttpGet]
    public IActionResult test(Student student)
    {
        return Ok(student);
    }

    [HttpGet("{id:min(0)}")]
    public IActionResult Test (int id)
    {
        var show = $"You Are searching for Id {id}";
        return Ok(show);
    }
}

